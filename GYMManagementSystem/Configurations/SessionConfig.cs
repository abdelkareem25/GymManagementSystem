using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Configurations
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.HasOne(s => s.Trainer).WithMany(s => s.Sessions).HasForeignKey(s => s.TrainerId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(s =>
            {
                s.HasCheckConstraint("CK_Session_StartTime_EndTime", "StartTime < EndTime");
                s.HasCheckConstraint("CK_Session_Capacity", "Capacity BETWEEN 1 AND 25");
            });
        }
    }
}
