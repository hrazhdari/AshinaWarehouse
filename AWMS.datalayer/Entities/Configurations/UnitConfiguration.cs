using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(u => u.UnitID);

            builder.Property(u => u.UnitName)
                .HasMaxLength(100)
                .IsRequired();

            // پیکربندی رابطه بین Unit و Item
            builder.HasMany(u => u.Items)
                .WithOne(i => i.Unit)
                .HasForeignKey(i => i.UnitID)
                .IsRequired(false)  // رابطه اختیاری
                .OnDelete(DeleteBehavior.SetNull);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(u => u.UnitName).HasDatabaseName("IX_Unit_UnitName");
        }
    }
}
