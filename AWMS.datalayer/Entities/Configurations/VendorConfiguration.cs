using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {

            // Define the relationship with PackingList
            builder.HasMany(e => e.PackingLists)
                   .WithOne(pl => pl.Vendor)
                   .HasForeignKey(pl => pl.VendorId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
