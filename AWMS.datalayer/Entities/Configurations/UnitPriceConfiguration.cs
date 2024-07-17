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


            // اضافه کردن داده‌های اولیه برای موجودیت UnitPrice
            builder.HasData(
                new UnitPrice { UnitPriceID = 1, UnitPriceName = "Euro" },
                new UnitPrice { UnitPriceID = 2, UnitPriceName = "Rial" },
                new UnitPrice { UnitPriceID = 3, UnitPriceName = "Dollar US" },
                new UnitPrice { UnitPriceID = 4, UnitPriceName = "Pound UK" },
                new UnitPrice { UnitPriceID = 5, UnitPriceName = "Yen Japan" },
                new UnitPrice { UnitPriceID = 6, UnitPriceName = "Rupee India" },
                new UnitPrice { UnitPriceID = 7, UnitPriceName = "Yuan China" },
                new UnitPrice { UnitPriceID = 8, UnitPriceName = "Won South Korea" },
                new UnitPrice { UnitPriceID = 9, UnitPriceName = "Franc Switzerland" },
                new UnitPrice { UnitPriceID = 10, UnitPriceName = "Krone Denmark" },
                new UnitPrice { UnitPriceID = 11, UnitPriceName = "Lira Turkey" },
                new UnitPrice { UnitPriceID = 12, UnitPriceName = "Real Brazil" },
                new UnitPrice { UnitPriceID = 13, UnitPriceName = "Rand South Africa" },
                new UnitPrice { UnitPriceID = 14, UnitPriceName = "Baht Thailand" },
                new UnitPrice { UnitPriceID = 15, UnitPriceName = "Peso Mexico" },
                new UnitPrice { UnitPriceID = 16, UnitPriceName = "Ringgit Malaysia" },
                new UnitPrice { UnitPriceID = 17, UnitPriceName = "Zloty Poland" },
                new UnitPrice { UnitPriceID = 18, UnitPriceName = "Dirham UAE" },
                new UnitPrice { UnitPriceID = 19, UnitPriceName = "Dinar Kuwait" },
                new UnitPrice { UnitPriceID = 20, UnitPriceName = "Kuna Croatia" },
                new UnitPrice { UnitPriceID = 21, UnitPriceName = "Forint Hungary" },
                new UnitPrice { UnitPriceID = 22, UnitPriceName = "Leu Romania" },
                new UnitPrice { UnitPriceID = 23, UnitPriceName = "Shekel Israel" },
                new UnitPrice { UnitPriceID = 24, UnitPriceName = "Taka Bangladesh" },
                new UnitPrice { UnitPriceID = 25, UnitPriceName = "Krone Norway" },
                new UnitPrice { UnitPriceID = 26, UnitPriceName = "Krona Sweden" },
                new UnitPrice { UnitPriceID = 27, UnitPriceName = "Franc France" },
                new UnitPrice { UnitPriceID = 28, UnitPriceName = "Pound Egypt" },
                new UnitPrice { UnitPriceID = 29, UnitPriceName = "Euro Germany" },
                new UnitPrice { UnitPriceID = 30, UnitPriceName = "Dollar Australia" },
                new UnitPrice { UnitPriceID = 31, UnitPriceName = "Dollar Canada" },
                new UnitPrice { UnitPriceID = 32, UnitPriceName = "Dollar Singapore" },
                new UnitPrice { UnitPriceID = 33, UnitPriceName = "Pound Switzerland" },
                new UnitPrice { UnitPriceID = 34, UnitPriceName = "Franc Belgium" },
                new UnitPrice { UnitPriceID = 35, UnitPriceName = "Crown Czech Republic" },
                new UnitPrice { UnitPriceID = 36, UnitPriceName = "Krona Iceland" },
                new UnitPrice { UnitPriceID = 37, UnitPriceName = "Euro Ireland" },
                new UnitPrice { UnitPriceID = 38, UnitPriceName = "Lira Italy" },
                new UnitPrice { UnitPriceID = 39, UnitPriceName = "Dollar New Zealand" },
                new UnitPrice { UnitPriceID = 40, UnitPriceName = "Riyal Saudi Arabia" },
                new UnitPrice { UnitPriceID = 41, UnitPriceName = "Ruble Russia" },
                new UnitPrice { UnitPriceID = 42, UnitPriceName = "Pound Sterling" },
                new UnitPrice { UnitPriceID = 43, UnitPriceName = "Dollar Hong Kong" },
                new UnitPrice { UnitPriceID = 44, UnitPriceName = "Pound Lebanon" },
                new UnitPrice { UnitPriceID = 45, UnitPriceName = "Franc Belgium" },
                new UnitPrice { UnitPriceID = 46, UnitPriceName = "Dollar Taiwan" },
                new UnitPrice { UnitPriceID = 47, UnitPriceName = "Dinar Bahrain" },
                new UnitPrice { UnitPriceID = 48, UnitPriceName = "Dollar Brunei" },
                new UnitPrice { UnitPriceID = 49, UnitPriceName = "Pound Cyprus" },
                new UnitPrice { UnitPriceID = 50, UnitPriceName = "Dinar Jordan" },
                new UnitPrice { UnitPriceID = 51, UnitPriceName = "Baht Thailand" },
                new UnitPrice { UnitPriceID = 52, UnitPriceName = "Dollar Egypt" },
                new UnitPrice { UnitPriceID = 53, UnitPriceName = "Dollar China" },
                new UnitPrice { UnitPriceID = 54, UnitPriceName = "Euro Ukraine" },
                new UnitPrice { UnitPriceID = 55, UnitPriceName = "Dollar Mexico" },
                new UnitPrice { UnitPriceID = 56, UnitPriceName = "Euro Portugal" },
                new UnitPrice { UnitPriceID = 57, UnitPriceName = "Dollar Argentina" },
                new UnitPrice { UnitPriceID = 58, UnitPriceName = "Ruble Armenia" },
                new UnitPrice { UnitPriceID = 59, UnitPriceName = "Ruble Azerbaijan" },
                new UnitPrice { UnitPriceID = 60, UnitPriceName = "Euro Belgium" }
            );
        }
    }
}
