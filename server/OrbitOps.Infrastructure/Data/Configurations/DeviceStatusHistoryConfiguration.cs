using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrbitOps.Domain.Entities;

public class DeviceStatusHistoryConfiguration : IEntityTypeConfiguration<DeviceStatusHistory>
{
    public void Configure(EntityTypeBuilder<DeviceStatusHistory> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.OldStatus).IsRequired();
        builder.Property(x => x.NewStatus).IsRequired();

        builder.HasOne(x => x.Device)
            .WithMany(x => x.StatusHistories)
            .HasForeignKey(x => x.DeviceId);
    }
}