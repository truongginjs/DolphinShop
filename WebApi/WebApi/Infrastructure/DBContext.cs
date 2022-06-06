using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Infrastructure
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
                    : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<Voter> Voter { get; set; }
        public virtual DbSet<Sharer> Sharer { get; set; }

        // public virtual DbSet<RefreshTokenTable> RefreshToken { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Voter>(voter =>
            {
                voter.HasKey(x => x.PostId);
                voter.HasKey(x => x.UserId);

            });
            modelBuilder.Entity<Sharer>(sharer =>
            {
                sharer.HasKey(x => x.PostId);
                sharer.HasKey(x => x.UserId);

            });
            PreDatabase.SeedData(modelBuilder);
        }
    }
}