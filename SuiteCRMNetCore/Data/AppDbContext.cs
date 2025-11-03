using Microsoft.EntityFrameworkCore;
using SuiteCRMNetCore.Models;

namespace SuiteCRMNetCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        // Add other DbSets as needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Members)
                .WithOne(a => a.Parent)
                .HasForeignKey(a => a.ParentId);
            // Add other relationships as needed
        }
    }
}
