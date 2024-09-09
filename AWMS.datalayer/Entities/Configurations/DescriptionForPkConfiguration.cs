using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class DescriptionForPkConfiguration : IEntityTypeConfiguration<DescriptionForPk>
    {
        public void Configure(EntityTypeBuilder<DescriptionForPk> builder)
        {

            // Define the relationship with PackingList
            builder.HasMany(e => e.PackingLists)
                   .WithOne(pl => pl.DescriptionForPk)
                   .HasForeignKey(pl => pl.DescriptionForPkId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
