using NedoAvito.APIGateWay.Models;
using Microsoft.EntityFrameworkCore;

namespace NedoAvito.APIGateWay.Database
{
    public class RepositoryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardCategory> CardCategories { get; set; }
        public DbSet<CardSuperCategory> CardSuperCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NedoAvitoDATA;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Настройка связи один-к-одному
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.UserImage)
            //    .WithOne(p => p.User)
            //    .HasForeignKey<UserImage>(p => p.UserId);

            //modelBuilder.Entity<BaseDbObject>()
            //    .HasOne(c => c.Creator)
            //    .WithOne()
            //    .HasForeignKey<BaseDbObject>(o => o.CreatorId);
            
            //modelBuilder.Entity<BaseDbObject>()
            //    .HasOne(c => c.ChangeMaker)
            //    .WithOne()
            //    .HasForeignKey<BaseDbObject>(o => o.ChangeMakerId);

            modelBuilder.Entity<User>()
                .HasOne(c => c.Role)
                .WithMany(o => o.Users)
                .HasForeignKey(o => o.RoleId);

            modelBuilder.Entity<CardCategory>()
                .HasOne(c => c.CardSuperCategory)
                .WithMany(o => o.SubCategories)
                .HasForeignKey(o => o.CardSuperCategoryId);
            
        }
    }
}
