using System.ComponentModel.DataAnnotations;

namespace Portfolio_View.Models;

public class Event
{
    public int EventId { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public Item Item { get; set; }
}