using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class DesciplineConfiguration : IEntityTypeConfiguration<Descipline>
    {
        public void Configure(EntityTypeBuilder<Descipline> builder)
        {

            // Define the relationship with PackingList
            builder.HasMany(e => e.PackingLists)
                   .WithOne(pl => pl.Descipline)
                   .HasForeignKey(pl => pl.DesciplineId)
                   .OnDelete(DeleteBehavior.SetNull);

            // اضافه کردن داده‌های اولیه
            builder.HasData(
                new Descipline { DesciplineId = 1, DesciplineName = "Piping" },          // لوله‌کشی
                new Descipline { DesciplineId = 2, DesciplineName = "Support" },         // پشتیبانی
                new Descipline { DesciplineId = 3, DesciplineName = "Mechanical" },      // مکانیکی
                new Descipline { DesciplineId = 4, DesciplineName = "Electrical" },      // الکتریکی
                new Descipline { DesciplineId = 5, DesciplineName = "Instrument" },      // ابزار دقیق
                new Descipline { DesciplineId = 6, DesciplineName = "Civil" },           // عمران
                new Descipline { DesciplineId = 7, DesciplineName = "Steel Structure" }, // سازه فولادی
                new Descipline { DesciplineId = 8, DesciplineName = "Steel Profile" },   // پروفیل فولادی
                new Descipline { DesciplineId = 9, DesciplineName = "Paint" },           // رنگ‌آمیزی
                new Descipline { DesciplineId = 10, DesciplineName = "Insulation" },     // عایق‌بندی
                new Descipline { DesciplineId = 11, DesciplineName = "Other" },          // سایر
                new Descipline { DesciplineId = 12, DesciplineName = "Hydraulics" },     // هیدرولیک
                new Descipline { DesciplineId = 13, DesciplineName = "HVAC" },           // سیستم‌های تهویه مطبوع
                new Descipline { DesciplineId = 14, DesciplineName = "Automation" },     // اتوماسیون
                new Descipline { DesciplineId = 15, DesciplineName = "Safety" },         // ایمنی
                new Descipline { DesciplineId = 16, DesciplineName = "Quality Control" } // کنترل کیفیت
            );
        }
    }
}
