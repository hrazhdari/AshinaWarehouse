using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AWMS.datalayer.Entities;

namespace AWMS.datalayer.Entities.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            // پیکربندی کلید اصلی
            builder.HasKey(r => r.RoleID);

            // پیکربندی خصوصیات
            builder.Property(r => r.RoleName)
                .IsRequired()
                .HasMaxLength(50);

            // تنظیمات اضافی (اختیاری)
            builder.ToTable("ApplicationRole");

            // اضافه کردن داده‌های پیش‌فرض
            builder.HasData(
                new ApplicationRole { RoleID = 1, RoleName = "Admin" },
                new ApplicationRole { RoleID = 2, RoleName = "Manager" },
                new ApplicationRole { RoleID = 3, RoleName = "Master" },
                new ApplicationRole { RoleID = 4, RoleName = "Amateur" },
                new ApplicationRole { RoleID = 5, RoleName = "Viewer" }
            );
        }
    }
}
