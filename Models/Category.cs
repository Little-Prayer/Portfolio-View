using System.ComponentModel.DataAnnotations;

namespace Portfolio_View.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    public String? Name { get; set; } 
    public IList<Item>? Items { get; set;}

}