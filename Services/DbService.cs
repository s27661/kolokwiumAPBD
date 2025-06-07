using Kolokwium.DAL;
using Kolokwium.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Services;

public class DbService(KolokwiumDbContext context) : IDbService
{
    public async Task<ICollection<ClinetGetDto>> GetAllClinetsAsync()
    {
        return await context.Clients.Select(c => new ClinetGetDto
        {
            IdClient = c.IdClient,
            FirstName = c.FirstName,
            LastName = c.LastName,
            PhoneNumber = c.PhoneNumber,
            Subscriptions = c.Sales.Select(sa => new ClientGetDtoSubscriptions()
            {
                IdSubscription = sa.Subscription.IdSubscription,
                Name = sa.Subscription.Name,
                Price = sa.Subscription.Price,
            }).ToList()
        }).ToListAsync();

    }
}