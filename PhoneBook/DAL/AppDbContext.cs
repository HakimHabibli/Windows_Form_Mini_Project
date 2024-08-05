using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=ASUS\SQLEXPRESS;database=PhoneBook;Trusted_Connection=True;TrustServerCertificate=True");	

    }
}
