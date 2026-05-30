namespace OrbitOps.Domain.Entities;

public class DeviceStatusHistory : BaseEntity
{
    public int DeviceId { get; set; }

    public Device Device { get; set; } = null!;

    public string OldStatus { get; set; } = string.Empty;

    public string NewStatus { get; set; } = string.Empty;

    public DateTime ChangedAt { get; set; }
}