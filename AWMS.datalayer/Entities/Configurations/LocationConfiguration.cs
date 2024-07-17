using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AWMS.datalayer.Entities;

namespace AWMS.datalayer.Entities.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l => l.LocationID);

            builder.Property(l => l.LocationName)
                .HasMaxLength(200)
                .IsRequired();
                                

            // اضافه کردن ایندکس برای LocationName
            builder.HasIndex(l => l.LocationName).HasDatabaseName("IX_Location_LocationName");


            builder.HasData(
                new Location { LocationID = 1, LocationName = "L02A101A", EnteredBy = 88, EnteredDate = DateTime.Now },
                new Location { LocationID = 2, LocationName = "L02A102A", EnteredBy = 88, EnteredDate = DateTime.Now },
                new Location { LocationID = 3, LocationName = "W02A02B", EnteredBy = 88, EnteredDate = DateTime.Now }
                // ادامه داده‌های پیش‌فرض برای مکان‌ها به همین شکل
            );
        }
    }
}
