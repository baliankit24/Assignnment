using Assignment.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}