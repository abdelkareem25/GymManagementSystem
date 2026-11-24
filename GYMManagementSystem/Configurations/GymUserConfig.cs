using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Configurations
{
    public class GymUserConfig<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(s=>s.Name).HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(s=>s.PhoneNumber).HasColumnType("nvarchar").HasMaxLength(100);
            builder.ComplexProperty(s => s.Address); //Owned Entity Type
            builder.HasIndex(s => s.PhoneNumber).IsUnique(); //Unique Index
            builder.HasIndex(s => s.Email).IsUnique(); //Unique Index
            builder.ToTable(s=>
            {
                s.HasCheckConstraint("CK_GymUser_Email", "Email LIKE '%@%.%'");
                s.HasCheckConstraint("CK_GymUser_PhoneNumber", "LEN(PhoneNumber)=11 AND (PhoneNumber LIKE '010%' OR PhoneNumber LIKE '011%' OR PhoneNumber LIKE '012%' OR PhoneNumber LIKE '015%')");
            });

        }
    }
}
