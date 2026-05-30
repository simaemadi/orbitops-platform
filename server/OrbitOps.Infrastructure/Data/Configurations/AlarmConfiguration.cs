using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrbitOps.Domain.Entities;

public class AlarmConfiguration : IEntityTypeConfiguration<Alarm>
{
    public void Configure(EntityTypeBuilder<Alarm> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Severity)
            .IsRequired();

        builder.Property(x => x.Status)
            .IsRequired();

        builder.HasOne(x => x.Device)
            .WithMany(x => x.Alarms)
            .HasForeignKey(x => x.DeviceId);

        builder.HasOne(x => x.Incident)
            .WithMany(x => x.Alarms)
            .HasForeignKey(x => x.IncidentId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}