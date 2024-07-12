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
        }
    }
}
