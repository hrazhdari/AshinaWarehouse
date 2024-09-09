using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class AreaUnitConfiguration : IEntityTypeConfiguration<AreaUnit>
    {
        public void Configure(EntityTypeBuilder<AreaUnit> builder)
        {
            // Define relationships
            builder.HasMany(e => e.PackingLists)
                   .WithOne(p => p.AreaUnit)
                   .HasForeignKey(p => p.AreaUnitID)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
