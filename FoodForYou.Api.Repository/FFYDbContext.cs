using FoodForYou.Api.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodForYou.Api.Repository
{
    public class FFYDbContext : IdentityDbContext<UserModel, UserProfile, string>
    {
        public DbSet<UserModel> Users { get; set; }

        public FFYDbContext(DbContextOptions<FFYDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}