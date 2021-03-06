using FoodForYou.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodForYou.Api.Repository
{
    public class UserConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder
                .ToTable("Users")
                .HasIndex(u => u.UserName)
                .IsUnique();

            builder
                .Property(u => u.Id)
                .HasColumnName("Id")
                .HasColumnType("VARCHAR(55)")
                .IsRequired();
            
        }
    }
}