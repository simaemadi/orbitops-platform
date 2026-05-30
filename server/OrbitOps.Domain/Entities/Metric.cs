using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class Metric : BaseEntity
{
    public int DeviceId { get; set; }

    public Device Device { get; set; } = null!;

    public MetricType MetricType { get; set; }

    public decimal MetricValue { get; set; }

    public DateTime CollectedAt { get; set; }
}