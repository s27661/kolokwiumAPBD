using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Model;

public class Payment
{
    [Key]
    public int IdPayment { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public int IdClient { get; set; }
    [Required]
    public int IdSubscription { get; set; }
}