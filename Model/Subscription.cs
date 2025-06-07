using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Model;

public class Subscription
{
    [Key]
    public int IdSubscription { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [Required]
    public int RenewalPeriod { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public double Price { get; set; }
    
    public virtual ICollection<Sale> Sales { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
}