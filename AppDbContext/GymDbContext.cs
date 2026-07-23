using GymSystem.Configurations;
using Microsoft.EntityFrameworkCore;
namespace GymSystem.AppDbContext
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanConfiguration());

        }
    }
}
