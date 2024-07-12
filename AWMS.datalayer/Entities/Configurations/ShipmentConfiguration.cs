using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.Property(s => s.PoId)
                   .IsRequired(false); // تغییر به nullable

            // Define the relationship with Po
            builder.HasOne(e => e.Po)
                   .WithMany(p => p.Shipments)
                   .HasForeignKey(e => e.PoId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Define the relationship with PackingList
            builder.HasMany(e => e.PackingLists)
                   .WithOne(pl => pl.Shipment)
                   .HasForeignKey(pl => pl.ShId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
