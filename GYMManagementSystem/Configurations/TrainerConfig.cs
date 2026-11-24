using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Configurations
{
    public class TrainerConfig : GymUserConfig<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
