using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AWMS.datalayer.Entities;

namespace AWMS.datalayer.Entities.Configurations
{
    public class LocItemConfiguration : IEntityTypeConfiguration<LocItem>
    {
        public void Configure(EntityTypeBuilder<LocItem> builder)
        {
            builder.HasKey(li => li.LocItemID);

            builder.Property(li => li.Qty)
                .HasColumnType("decimal(18,2)");

            builder.Property(li => li.OverQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(li => li.ShortageQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(li => li.DamageQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(li => li.RejectQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(li => li.NISQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(li => li.EnteredDate)
                .HasColumnType("date");

            builder.Property(li => li.EditedDate)
                .HasColumnType("date");

            // پیکربندی رابطه بین LocItem و Item
            builder.HasOne(li => li.Item)
                .WithMany(i => i.LocItems)
                .HasForeignKey(li => li.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // پیکربندی رابطه بین LocItem و Location
            builder.HasOne(li => li.Location)
                .WithMany(l => l.LocItems)
                .HasForeignKey(li => li.LocationID)
                .OnDelete(DeleteBehavior.Cascade);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(li => li.LocationID).HasDatabaseName("IX_LocItem_LocationID");
            builder.HasIndex(li => li.ItemId).HasDatabaseName("IX_LocItem_ItemId");
        }
    }
}
