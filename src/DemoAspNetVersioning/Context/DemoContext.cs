using DemoAspNetVersioning.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoAspNetVersioning.Context
{
    public class DemoContext : DbContext
    {        
        public DemoContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DemoContext).Assembly);
        }
    }
}