using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.DAL;

public class KolokwiumDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    
    protected KolokwiumDbContext()
    {
    }

    public KolokwiumDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var client = new Client
        {
            IdClient = 1,
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "08888888888",
        };
        var subscription = new Subscription
        {
            IdSubscription = 1,
            Name = "Subscription1",
            RenewalPeriod = 8,
            EndDate = new DateTime(2026, 1, 1),
            Price = 80.0
        };
        var sale = new Sale
        {
            IdSale = 1,
            IdClient = 1,
            IdSubscription = 1
        };
        modelBuilder.Entity<Client>().HasData(client);
        modelBuilder.Entity<Subscription>().HasData(subscription);
        modelBuilder.Entity<Sale>().HasData(sale);
    }
}