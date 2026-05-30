using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrbitOps.Domain.Entities;

public class MetricConfiguration : IEntityTypeConfiguration<Metric>
{
    public void Configure(EntityTypeBuilder<Metric> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.MetricType)
            .IsRequired();

        builder.Property(x => x.MetricValue)
            .HasPrecision(18, 2);

        builder.HasOne(x => x.Device)
            .WithMany(x => x.Metrics)
            .HasForeignKey(x => x.DeviceId);
    }
}