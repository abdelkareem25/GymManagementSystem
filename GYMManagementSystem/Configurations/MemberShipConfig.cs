using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Configurations
{
    public class MemberShipConfig : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            //builder.HasOne(s => s.Member).WithMany(s => s.MemberShips).HasForeignKey(s => s.MemberId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(s => s.Plan).WithMany(s => s.MemberShips).HasForeignKey(s => s.PlanId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
