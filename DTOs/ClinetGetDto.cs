namespace Kolokwium.DTOs;

public class ClinetGetDto
{
   public int IdClient { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string PhoneNumber { get; set; }
   public ICollection<ClientGetDtoSubscriptions> Subscriptions { get; set; } 
}

public class ClientGetDtoSubscriptions
{
   public int IdSubscription { get; set; }
   public string Name { get; set; }
   public double Price { get; set; }
}