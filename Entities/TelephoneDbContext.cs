using Lab3WebAPI.Configurations;
using Lab3WebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab3WebAPI.Entities
{
    public class TelephoneDbContext : IdentityDbContext<IdentityUser>
    {

        public TelephoneDbContext(DbContextOptions<TelephoneDbContext> options)
            : base(options) { }

        public DbSet<Service> Services { get; set; }

        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TelephoneDbContext).Assembly);
        }
    }
}
