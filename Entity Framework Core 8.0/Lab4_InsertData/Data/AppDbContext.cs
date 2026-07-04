using Microsoft.EntityFrameworkCore;
using Lab4_InsertData.Models;

namespace Lab4_InsertData.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryDB_Lab4;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}