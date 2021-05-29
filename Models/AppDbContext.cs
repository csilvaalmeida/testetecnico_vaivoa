using Microsoft.EntityFrameworkCore;

namespace creditcardapi.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cartao> Cartao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
        }

    }
}