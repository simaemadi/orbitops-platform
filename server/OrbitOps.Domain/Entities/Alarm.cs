using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class Alarm : BaseEntity
{
    public int DeviceId { get; set; }

    public Device Device { get; set; } = null!;

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public AlarmSeverity Severity { get; set; }

    public AlarmStatus Status { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public int? IncidentId { get; set; }

    public Incident? Incident { get; set; }
}