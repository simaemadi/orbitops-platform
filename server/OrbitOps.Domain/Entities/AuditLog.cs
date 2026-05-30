using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class AuditLog : BaseEntity
{
    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public AuditAction Action { get; set; }

    public string EntityName { get; set; } = string.Empty;

    public string EntityId { get; set; } = string.Empty;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }
}