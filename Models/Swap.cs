using System.ComponentModel.DataAnnotations;

namespace Portfolio_View.Models;

public class Swap
{
    public int SwapId { get; set; }
    [Required]
    public DateTime Date { get; set; }
    public Item? Item { get; set; }

    public string? Memo { get; set; }
}