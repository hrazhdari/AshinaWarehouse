using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class ScopeConfiguration : IEntityTypeConfiguration<Scope>
    {
        public void Configure(EntityTypeBuilder<Scope> builder)
        {
            builder.HasKey(s => s.ScopeID);

            builder.Property(s => s.ScopeName)
                .HasMaxLength(100)
                .IsRequired();

            // پیکربندی رابطه بین Scope و Item
            builder.HasMany(s => s.Items)
                .WithOne(i => i.Scope)
                .HasForeignKey(i => i.ScopeID)
                .IsRequired(false)  // رابطه اختیاری
                .OnDelete(DeleteBehavior.SetNull);

            // اضافه کردن ایندکس‌ها
            builder.HasIndex(s => s.ScopeName).HasDatabaseName("IX_Scope_ScopeName");
        }
    }
}
