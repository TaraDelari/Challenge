using Microsoft.EntityFrameworkCore;
using Challenge.Core.Models;

namespace Challenge.Infrastructure.DataAccess
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureForUser(modelBuilder);
            ConfigureForRole(modelBuilder);
            ConfigureForUserRole(modelBuilder);
            ConfigureForLink(modelBuilder);
            ConfigureForTag(modelBuilder);
            ConfigureForKeyword(modelBuilder);
            SeedData(modelBuilder);
        }

        private void ConfigureForUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().HasAlternateKey(x => x.Email);
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<User>().Property(x => x.DisplayName).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<User>().Property(x => x.PasswordHash).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<User>().Ignore(x => x.Roles);
        }

        private void ConfigureForRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<Role>().HasKey(x => x.Name);
            modelBuilder.Entity<Role>().Property(x => x.Name).HasMaxLength(200);
            modelBuilder.Entity<Role>().Property(x => x.DisplayName).HasMaxLength(500);
        }

        private void ConfigureForUserRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().ToTable("user_roles");
            modelBuilder.Entity<UserRole>().HasKey(x => new { x.UserId, x.RoleName });
            modelBuilder.Entity<UserRole>().HasOne(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).IsRequired();
            modelBuilder.Entity<UserRole>().HasOne(x => x.Role).WithMany().HasForeignKey(x => x.RoleName).IsRequired();
        }

        private void ConfigureForLink(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>().ToTable("links");
            modelBuilder.Entity<Link>().HasKey(x => new { x.Url, x.UserId });
            modelBuilder.Entity<Link>().HasOne(x => x.User).WithMany(x => x.Links).HasForeignKey(x => x.UserId).IsRequired();
            modelBuilder.Entity<Link>().Property(x => x.OriginalUrl).IsRequired();
            modelBuilder.Entity<Link>().Property(x => x.Url).IsRequired();
        }
        private void ConfigureForTag(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tag>().ToTable("tags");
            modelBuilder.Entity<Tag>().HasKey(x => new { x.Content, x.Url, x.LinkUserId });
            modelBuilder.Entity<Tag>().HasOne(x => x.Link).WithMany(x => x.Tags).HasForeignKey(x => new { x.Url, x.LinkUserId }).IsRequired();
        }

        private void ConfigureForKeyword(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Keyword>().ToTable("keywords");
            modelBuilder.Entity<Keyword>().HasKey(x => new { x.Content, x.Url });
            modelBuilder.Entity<Keyword>().HasOne(x => x.Link).WithMany(x => x.Keywords).HasForeignKey(x => x.Url).IsRequired();
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role("Admin"));
            modelBuilder.Entity<Role>().HasData(new Role("User"));
        }
    }
}