using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AWMS.datalayer.Entities;

namespace AWMS.datalayer.Entities.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // پیکربندی کلید اصلی
            builder.HasKey(u => u.UserID);

            // پیکربندی خصوصیات
            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(255);

            // پیکربندی رابطه با جدول Role
            builder.HasOne(u => u.ApplicationRole)
                .WithMany()
                .HasForeignKey(u => u.RoleID)
                .OnDelete(DeleteBehavior.Restrict);

            // تنظیمات اضافی (اختیاری)
            builder.ToTable("ApplicationUser");

            // اضافه کردن داده‌های پیش‌فرض
            builder.HasData(
                new ApplicationUser { UserID = 1, Username = "Admin",PasswordHash="123",RoleID=1},
                new ApplicationUser { UserID = 2, Username = "Amateur", PasswordHash="123",RoleID=4},
                new ApplicationUser { UserID = 3, Username = "Master", PasswordHash="123",RoleID=3},
                new ApplicationUser { UserID = 4, Username = "Viewer", PasswordHash="123",RoleID=5},
                new ApplicationUser { UserID = 5, Username = "Manager", PasswordHash="123",RoleID=2}
            );
        }
    }
}
