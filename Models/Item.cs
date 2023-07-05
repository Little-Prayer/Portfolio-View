using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Portfolio_View.Models;

public class Item
{
    public int? ItemId { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    public long? Ticks { get; set; }
    public ISet<Category>? Categories { get; set; }
    public IList<Swap>? Swaps { get; set; }

    public DateTime? LastSwapDate => Swaps?.MaxBy(e => e.Date)?.Date;

    public DateTime? SwapExpectedDate => Ticks is not null ?
                                            LastSwapDate?.Add(SwapFrequency!.Value) :
                                            null;
    public TimeSpan? SwapFrequency=> Ticks is not null ? 
                                        new TimeSpan(Ticks.Value) :
                                        null;
}