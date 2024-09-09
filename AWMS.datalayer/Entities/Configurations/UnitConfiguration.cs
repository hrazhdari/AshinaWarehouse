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
            
            // Adding initial data
            builder.HasData(
                new Unit { UnitID = 1, UnitName = "PC" },      // قطعه
                new Unit { UnitID = 2, UnitName = "KG" },      // کیلوگرم
                new Unit { UnitID = 3, UnitName = "METER" },   // متر
                new Unit { UnitID = 4, UnitName = "LITER" },   // لیتر
                new Unit { UnitID = 5, UnitName = "BOX" },     // جعبه
                new Unit { UnitID = 6, UnitName = "PACK" },    // بسته
                new Unit { UnitID = 7, UnitName = "SET" },     // ست
                new Unit { UnitID = 8, UnitName = "PAIR" },    // جفت
                new Unit { UnitID = 9, UnitName = "DOZEN" },   // دوجین
                new Unit { UnitID = 10, UnitName = "GALLON" }, // گالن
                new Unit { UnitID = 11, UnitName = "TON" },    // تن
                new Unit { UnitID = 12, UnitName = "GRAM" },   // گرم
                new Unit { UnitID = 13, UnitName = "LB" },     // پوند
                new Unit { UnitID = 14, UnitName = "OZ" },     // اونس
                new Unit { UnitID = 15, UnitName = "INCH" },   // اینچ
                new Unit { UnitID = 16, UnitName = "FOOT" },   // فوت
                new Unit { UnitID = 17, UnitName = "YARD" },   // یارد
                new Unit { UnitID = 18, UnitName = "CM" },     // سانتی‌متر
                new Unit { UnitID = 19, UnitName = "MM" },     // میلی‌متر
                new Unit { UnitID = 20, UnitName = "SQM" },    // متر مربع
                new Unit { UnitID = 21, UnitName = "CUBICM" }, // متر مکعب
                new Unit { UnitID = 22, UnitName = "LTR" },    // لیتر (املا متفاوت)
                new Unit { UnitID = 23, UnitName = "BLK" },    // حجم
                new Unit { UnitID = 24, UnitName = "PALLET" }, // پالت
                new Unit { UnitID = 25, UnitName = "ROLL" },   // رول
                new Unit { UnitID = 26, UnitName = "SHEET" },  // ورق
                new Unit { UnitID = 27, UnitName = "TUBE" },   // لوله
                new Unit { UnitID = 28, UnitName = "CARTON" }, // کارتن
                new Unit { UnitID = 29, UnitName = "BAG" },    // کیسه
                new Unit { UnitID = 30, UnitName = "CAN" }     // قوطی
            );


        }
    }
}
