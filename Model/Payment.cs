using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    [ForeignKey(nameof(IdClient))]
    public virtual Client Client { get; set; }
    [ForeignKey(nameof(IdSubscription))]
    public virtual Subscription Subscription { get; set; }
}