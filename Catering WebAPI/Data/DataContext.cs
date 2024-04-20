using Catering_WebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Catering_WebAPI.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CateringType> CateringTypes { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
        public DbSet<CalorieVariant> CalorieVariants { get; set; }
    }
}
