using Microsoft.EntityFrameworkCore;

namespace MediatRDemo;

public class ContactContext : DbContext
{
    public ContactContext(DbContextOptions<ContactContext> options) : base(options)
    {

    }

    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasData(
            new Contact{Id = 1, FirstName = "Steve", LastName = "M"},
            new Contact{Id = 2, FirstName = "Bill", LastName = "G"},
            new Contact{Id = 3, FirstName = "Satya", LastName = "N"}
        );
    }

}