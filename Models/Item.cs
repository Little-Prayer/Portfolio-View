using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_View.Models;

public class Item
{
    public int ItemId { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    public int? SwapFrequency { get; set; }
    public IList<Category>? Categories { get; set;}
    public IList<Event>? Events { get; set;}
}