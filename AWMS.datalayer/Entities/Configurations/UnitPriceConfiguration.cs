using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class UnitPriceConfiguration : IEntityTypeConfiguration<UnitPrice>
    {
        public void Configure(EntityTypeBuilder<UnitPrice> builder)
        {
            builder.HasKey(up => up.UnitPriceID);

            builder.Property(up => up.UnitPriceName)
                .HasMaxLength(100)
                .IsRequired();

            // پیکربندی رابطه بین UnitPrice و Item
            builder.HasMany(up => up.Items)
                .WithOne(i => i.UnitPrice)
                .HasForeignKey(i => i.UnitPriceID)
                .IsRequired(false)  // رابطه اختیاری
                .OnDelete(DeleteBehavior.SetNull);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(up => up.UnitPriceName).HasDatabaseName("IX_UnitPrice_UnitPriceName");
        }
    }
}
