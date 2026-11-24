using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Configurations
{
    public class MemberConfig: GymUserConfig<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(s=>s.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
