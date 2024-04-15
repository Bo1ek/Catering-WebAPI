using Catering_WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catering_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }

    }
}
