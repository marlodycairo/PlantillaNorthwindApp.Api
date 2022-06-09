using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindApp.Infrastructure.Api.Entities;

namespace NorthwindApp.Infrastructure.Api.Configurations
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey(e => e.RegionId)
                    .IsClustered(false);

            builder.ToTable("Region");

            builder.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");

            builder.Property(e => e.RegionDescription)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength(true);
        }
    }
}
