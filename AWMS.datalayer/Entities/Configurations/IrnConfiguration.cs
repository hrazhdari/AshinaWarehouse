using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class IrnConfiguration : IEntityTypeConfiguration<Irn>
    {
        public void Configure(EntityTypeBuilder<Irn> builder)
        {

            // Define the relationship with PackingList
            builder.HasMany(e => e.PackingLists)
                   .WithOne(pl => pl.Irn)
                   .HasForeignKey(pl => pl.IrnId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
