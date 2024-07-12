using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWMS.datalayer.Entities.Configurations
{
    public class PoConfiguration : IEntityTypeConfiguration<Po>
    {
        public void Configure(EntityTypeBuilder<Po> builder)
        {
            builder.HasOne(e => e.Mr)
                   .WithMany(e => e.Pos)
                   .HasForeignKey(e => e.MrId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.Property(po => po.MrId)
              .IsRequired(false); // تغییر به nullable

            builder.HasMany(e => e.Shipments)
                    .WithOne(p => p.Po)
                    .HasForeignKey(p => p.PoId)
                    .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.PackingLists)
                   .WithOne(p => p.Po)
                   .HasForeignKey(p => p.PoId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
