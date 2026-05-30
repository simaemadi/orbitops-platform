using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class Incident : BaseEntity
{
    public string IncidentNumber { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public IncidentStatus Status { get; set; }

    public IncidentPriority Priority { get; set; }

    public int CreatedByUserId { get; set; }

    public User CreatedByUser { get; set; } = null!;

    public int? AssignedToUserId { get; set; }

    public User? AssignedToUser { get; set; }

    public DateTime? ClosedAt { get; set; }

    public ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();
}