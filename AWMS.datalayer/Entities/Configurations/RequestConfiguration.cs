using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace AWMS.datalayer.Entities.Configurations
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(r => r.ReqLocItemID);

            builder.Property(r => r.ReqMivQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.ReserveMivQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.DelMivQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.ReqMivRejQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.ReserveMivRejQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.DelMivRejQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.ReqMrvQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.DelMrvQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.ReqHmvQty)
                .HasColumnType("decimal(18,2)");


            builder.Property(r => r.DelHmvQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.DelHmvRejQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.DelMrvRejQty)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.ReqDate)
                .HasColumnType("date");

            builder.Property(r => r.IssuedDate)
                .HasColumnType("date");

            builder.Property(r => r.ApprovedDate)
                .HasColumnType("date");

            builder.Property(r => r.DelDate)
                .HasColumnType("date");



            // پیکربندی رابطه بین Request و LocItem
            builder.HasOne(r => r.LocItem)
                .WithMany(li => li.Requests)
                .HasForeignKey(r => r.LocItemID)
                .OnDelete(DeleteBehavior.Restrict);

            //// پیکربندی رابطه بین Request و Company
            //builder.HasOne(r => r.Company)
            //    .WithMany(c => c.Requests)
            //    .HasForeignKey(r => r.CompanyID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// پیکربندی رابطه بین Request و Company (شرکت دوم)
            //builder.HasOne(r => r.Company2)
            //    .WithMany()
            //    .HasForeignKey(r => r.CompanyID2)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// پیکربندی رابطه بین Request و AreaUnit
            //builder.HasOne(r => r.AreaUnit)
            //    .WithMany()
            //    .HasForeignKey(r => r.AreaUnitID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// پیکربندی رابطه بین Request و Vendor
            //builder.HasOne(r => r.Vendor)
            //    .WithMany()
            //    .HasForeignKey(r => r.VendorID)
            //    .OnDelete(DeleteBehavior.Restrict);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(r => r.LocItemID).HasDatabaseName("IX_Request_LocItemID");
            builder.HasIndex(r => r.CompanyID).HasDatabaseName("IX_Request_CompanyID");
            builder.HasIndex(r => r.TypeID).HasDatabaseName("IX_Request_TypeID");
        }
    }
}
