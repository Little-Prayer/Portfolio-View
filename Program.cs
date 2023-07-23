using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Portfolio_View;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Portfolio-API.ServerAPI", client =>
    client.BaseAddress = new Uri("https://localhost:5184"))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
    .CreateClient("Portfolio_API.ServerAPI"));

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAdB2C", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add("https://ExpendablesManagementApp.onmicrosoft.com/1f47fe80-c7f5-4cef-a27e-da7560f63d4f/API.Access");
    options.ProviderOptions.LoginMode = "redirect";
});

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5184") });

await builder.Build().RunAsync();
