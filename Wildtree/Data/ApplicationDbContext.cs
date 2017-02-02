using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wildtree.Models;

namespace Wildtree.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<Workshop> Workshop { get; set; }
        public DbSet<WorkshopBundle> WorkshopBundle { get; set; }
        public DbSet<Bundle> Bundle { get; set; }
        public DbSet<Meal> Meal { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Workshop>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            
            builder.Entity<WorkshopBundle>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            
            builder.Entity<Bundle>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Entity<Meal>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
