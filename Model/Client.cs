using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Model;

public class Client
{
    [Key]
    public int IdClient { get; set; }
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    [MaxLength(100)]
    public string PhoneNumber { get; set; }
    
    public virtual ICollection<Sale> Sales { get; set; }
}