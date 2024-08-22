using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class RequestTypeConfiguration : IEntityTypeConfiguration<RequestType>
    {
        public void Configure(EntityTypeBuilder<RequestType> builder)
        {
            builder.HasKey(rt => rt.TypeID);

            builder.Property(rt => rt.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            // ایجاد داده‌های پیش‌فرض برای Type
            builder.HasData(
                new RequestType { TypeID = 1, TypeName = "MIV" },
                new RequestType { TypeID = 2, TypeName = "MIVReject" },
                new RequestType { TypeID = 3, TypeName = "HMV" },
                new RequestType { TypeID = 4, TypeName = "MRV" }
            );

            // اضافه کردن ایندکس
            builder.HasIndex(rt => rt.TypeName).HasDatabaseName("IX_RequestType_TypeName");
        }
    }
}
