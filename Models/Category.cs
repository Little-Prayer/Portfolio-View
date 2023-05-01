using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Portfolio_View.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    public String? Name { get; set; } 
    [JsonIgnore]
    public List<Item> Items { get; } = new();

}