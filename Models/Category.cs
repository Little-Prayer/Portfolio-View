using System.ComponentModel.DataAnnotations;

namespace Portfolio_View.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    public String? Name { get; set; } 
    public IList<Item>? Items { get; set;}

    public override int GetHashCode()
    {
        return Name!.GetHashCode() ^ CategoryId!.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if(obj is null) return false;
        Category? cat = obj as Category;
        if(cat == null)return false;
        return Name == cat.Name && CategoryId == cat.CategoryId;
    }

}