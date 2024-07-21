using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AWMS.datalayer.Entities;

namespace AWMS.datalayer.Entities.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            // تنظیم کلید اصلی
            builder.HasKey(i => i.ItemId);

            // تنظیم نوع داده برای فیلدهای مختلف
            builder.Property(i => i.Qty).HasColumnType("decimal(18,2)");
            builder.Property(i => i.OverQty).HasColumnType("decimal(18,2)");
            builder.Property(i => i.ShortageQty).HasColumnType("decimal(18,2)");
            builder.Property(i => i.DamageQty).HasColumnType("decimal(18,2)");
            builder.Property(i => i.IncorectQty).HasColumnType("decimal(18,2)");
            builder.Property(i => i.Price).HasColumnType("decimal(18,2)");
            builder.Property(i => i.NetW).HasColumnType("decimal(18,2)");
            builder.Property(i => i.GrossW).HasColumnType("decimal(18,2)");
            builder.Property(i => i.NIS).HasColumnType("decimal(18,2)");

            // تنظیم حداکثر طول برای فیلدهای مختلف
            builder.Property(i => i.Tag).HasMaxLength(500);
            builder.Property(i => i.Description).HasMaxLength(500);
            builder.Property(i => i.HeatNo).HasMaxLength(500);
            builder.Property(i => i.BatchNo).HasMaxLength(500);
            builder.Property(i => i.Remark).HasMaxLength(500);
            builder.Property(i => i.MTRNo).HasMaxLength(200);
            builder.Property(i => i.ColorCode).HasMaxLength(50);
            builder.Property(i => i.LabelNo).HasMaxLength(50);
            builder.Property(i => i.StorageCode).HasMaxLength(50);

            // تنظیم نوع داده برای تاریخ‌ها
            builder.Property(i => i.EnteredDate).HasColumnType("date");
            builder.Property(i => i.EditedDate).HasColumnType("date");

            // پیکربندی رابطه بین Item و Package
            builder.HasOne(i => i.Package)
                .WithMany(p => p.Items)
                .HasForeignKey(i => i.PKID)
                .OnDelete(DeleteBehavior.Cascade);

            // پیکربندی رابطه بین Item و Scope
            builder.HasOne(p => p.Scope)
                .WithMany(s => s.Items) // فرض کنیم Scope دارای مجموعه‌ای از Items باشد
                .HasForeignKey(p => p.ScopeID)
                .OnDelete(DeleteBehavior.SetNull);

            // پیکربندی رابطه بین Item و Unit
            builder.HasOne(p => p.Unit)
                .WithMany(u => u.Items) // فرض کنیم Unit دارای مجموعه‌ای از Items باشد
                .HasForeignKey(p => p.UnitID)
                .OnDelete(DeleteBehavior.SetNull);

            // پیکربندی رابطه بین Item و UnitPrice
            builder.HasOne(p => p.UnitPrice)
                .WithMany(up => up.Items) // فرض کنیم UnitPrice دارای مجموعه‌ای از Items باشد
                .HasForeignKey(p => p.UnitPriceID)
                .OnDelete(DeleteBehavior.SetNull);

            // پیکربندی رابطه بین Item و LocItem
            builder.HasMany(i => i.LocItems)
                .WithOne(li => li.Item)
                .HasForeignKey(li => li.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(i => i.PKID).HasDatabaseName("IX_Item_PKID");
            builder.HasIndex(i => i.ScopeID).HasDatabaseName("IX_Item_ScopeID");
            builder.HasIndex(i => i.UnitID).HasDatabaseName("IX_Item_UnitID");
            builder.HasIndex(i => i.UnitPriceID).HasDatabaseName("IX_Item_UnitPriceID");

            //// ایجاد ایندکس بر روی فیلد Tag و Description
            //builder.HasIndex(i => i.Tag).HasDatabaseName("IX_Item_Tag");
            //builder.HasIndex(i => i.Description).HasDatabaseName("IX_Item_Description");
        }
    }
}
