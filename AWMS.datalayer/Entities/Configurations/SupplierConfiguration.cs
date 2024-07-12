using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {

            // Define the relationship with PackingList
            builder.HasMany(e => e.PackingLists)
                   .WithOne(pl => pl.Supplier)
                   .HasForeignKey(pl => pl.SupplierId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
