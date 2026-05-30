using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class Device : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public DeviceType DeviceType { get; set; }

    public string IpAddress { get; set; } = string.Empty;

    public string SerialNumber { get; set; } = string.Empty;

    public DeviceStatus Status { get; set; }

    public DateTime? LastSeen { get; set; }

    public int HubId { get; set; }

    public Hub Hub { get; set; } = null!;

    public ICollection<Metric> Metrics { get; set; } = new List<Metric>();

    public ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public ICollection<DeviceStatusHistory> StatusHistories { get; set; } = new List<DeviceStatusHistory>();
}