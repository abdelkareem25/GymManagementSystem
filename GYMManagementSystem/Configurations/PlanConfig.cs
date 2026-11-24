using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Configurations
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(s => s.Name).HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(s =>
            {
                s.HasCheckConstraint("CK_Plan_DurationDays", "DurationDays BETWEEN 1 AND 365");
            });
        }
    }
}
