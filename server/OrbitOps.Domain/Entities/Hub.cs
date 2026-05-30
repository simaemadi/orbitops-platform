using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class Hub : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string IpAddress { get; set; } = string.Empty;

    public HubStatus Status { get; set; }

    public string? Description { get; set; }

    public ICollection<Device> Devices { get; set; } = new List<Device>();
}