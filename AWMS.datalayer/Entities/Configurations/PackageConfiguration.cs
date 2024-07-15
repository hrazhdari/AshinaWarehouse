using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(p => p.PKID);

            builder.Property(p => p.NetW)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.GrossW)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Dimension)
                .HasMaxLength(100);

            builder.Property(p => p.Volume)
                .HasMaxLength(100);

            builder.Property(p => p.ArrivalDate)
                .HasColumnType("date");

            builder.Property(p => p.Desciption)
                .HasMaxLength(500);

            builder.Property(p => p.Remark)
                .HasMaxLength(500);

            builder.Property(p => p.EnteredDate)
                .HasColumnType("date");

            builder.Property(p => p.EditedDate)
                .HasColumnType("date");

            builder.Property(p => p.MSRNO)
                .HasMaxLength(100);

            builder.Property(p => p.MSRPDF)
                .HasMaxLength(100);

            builder.Property(p => p.MSRDate)
                .HasColumnType("date");

            builder.Property(p => p.MSRRevDate)
                .HasColumnType("date");

            // پیکربندی رابطه بین Package و PackingList
            builder.HasOne(p => p.PackingList)
                .WithMany(pl => pl.Packages)
                .HasForeignKey(p => p.PLId)
                .OnDelete(DeleteBehavior.Cascade);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(p => p.PLId).HasDatabaseName("IX_Package_PLId");
            builder.HasIndex(p => p.MSRNO).HasDatabaseName("IX_Package_MSRNO");
            builder.HasIndex(p => p.PK).HasDatabaseName("IX_Package_PK");
        }
    }
}
