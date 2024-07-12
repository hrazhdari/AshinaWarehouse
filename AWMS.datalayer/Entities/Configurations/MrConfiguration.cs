using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class MrConfiguration : IEntityTypeConfiguration<Mr>
    {
        public void Configure(EntityTypeBuilder<Mr> builder)
        {

            builder.HasMany(e => e.Pos)
                   .WithOne(e => e.Mr)
                   .HasForeignKey(e => e.MrId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.PackingLists)
                   .WithOne(p => p.Mr)
                   .HasForeignKey(p => p.MrId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
