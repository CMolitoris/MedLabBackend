using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<BMP> BMPs { get; set; }
        public DbSet<BMPList> BMPLists { get; set; }
        public DbSet<CBC> CBCs { get; set; }
        public DbSet<CBCList> CBCLists { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<ConditionList> ConditionLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BMPList>()
                .HasKey(c => new { c.UserId, c.BMPId });
            modelBuilder.Entity<CBCList>()
                .HasKey(c => new { c.UserId, c.CBCId });
            modelBuilder.Entity<ConditionList>()
               .HasKey(c => new { c.UserId, c.ConditionId });

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
