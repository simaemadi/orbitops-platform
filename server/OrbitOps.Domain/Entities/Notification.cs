using OrbitOps.Domain.Enums;

namespace OrbitOps.Domain.Entities;

public class Notification : BaseEntity
{
    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public NotificationType Title { get; set; }

    public string Message { get; set; } = string.Empty;

    public bool IsRead { get; set; }
}