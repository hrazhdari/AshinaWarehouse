using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class PackingListConfiguration : IEntityTypeConfiguration<PackingList>
    {
        public void Configure(EntityTypeBuilder<PackingList> builder)
        {
            builder.Property(pl => pl.MrId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Mr)
                .WithMany(m => m.PackingLists)
                .HasForeignKey(pl => pl.MrId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.PoId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Po)
                .WithMany(po => po.PackingLists)
                .HasForeignKey(pl => pl.PoId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.ShId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Shipment)
                .WithMany(s => s.PackingLists)
                .HasForeignKey(pl => pl.ShId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.AreaUnitID)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.AreaUnit)
                .WithMany(au => au.PackingLists)
                .HasForeignKey(pl => pl.AreaUnitID)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.SupplierId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Supplier)
                .WithMany(s => s.PackingLists)
                .HasForeignKey(pl => pl.SupplierId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.DesciplineId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Descipline)
                .WithMany(d => d.PackingLists)
                .HasForeignKey(pl => pl.DesciplineId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.VendorId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Vendor)
                .WithMany(v => v.PackingLists)
                .HasForeignKey(pl => pl.VendorId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.IrnId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.Irn)
                .WithMany(i => i.PackingLists)
                .HasForeignKey(pl => pl.IrnId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(pl => pl.DescriptionForPkId)
                .IsRequired(false); // تغییر به nullable

            builder.HasOne(pl => pl.DescriptionForPk)
                .WithMany(dfpk => dfpk.PackingLists)
                .HasForeignKey(pl => pl.DescriptionForPkId)
                .OnDelete(DeleteBehavior.SetNull);

            // مشخص کردن نوع ستون SQL Server برای ویژگی‌های اعشاری
            builder.Property(pl => pl.GrossW).HasColumnType("decimal(18,2)");
            builder.Property(pl => pl.NetW).HasColumnType("decimal(18,2)");

            // اضافه کردن ایندکس به ستون‌های مورد نظر
            builder.HasIndex(pl => pl.MrId).HasDatabaseName("IX_PackingList_MrId");
            builder.HasIndex(pl => pl.PoId).HasDatabaseName("IX_PackingList_PoId");
            builder.HasIndex(pl => pl.ShId).HasDatabaseName("IX_PackingList_ShId");
            builder.HasIndex(pl => pl.AreaUnitID).HasDatabaseName("IX_PackingList_AreaUnitID");
            builder.HasIndex(pl => pl.SupplierId).HasDatabaseName("IX_PackingList_SupplierId");
            builder.HasIndex(pl => pl.DesciplineId).HasDatabaseName("IX_PackingList_DesciplineId");
            builder.HasIndex(pl => pl.VendorId).HasDatabaseName("IX_PackingList_VendorId");
            builder.HasIndex(pl => pl.IrnId).HasDatabaseName("IX_PackingList_IrnId");
            builder.HasIndex(pl => pl.DescriptionForPkId).HasDatabaseName("IX_PackingList_DescriptionForPkId");
            builder.HasIndex(pl => pl.PLNO).HasDatabaseName("IX_PackingList_PLNO").IsUnique();
            builder.HasIndex(pl => pl.OPINO).HasDatabaseName("IX_PackingList_OPINO").IsUnique();
            builder.HasIndex(pl => pl.ArchiveNO).HasDatabaseName("IX_PackingList_ArchiveNO");
        }
    }
}
