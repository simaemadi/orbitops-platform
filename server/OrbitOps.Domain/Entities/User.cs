namespace OrbitOps.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public bool IsActive { get; set; }

    public int RoleId { get; set; }

    public Role Role { get; set; } = null!;

    public ICollection<Incident> CreatedIncidents { get; set; } = new List<Incident>();

    public ICollection<Incident> AssignedIncidents { get; set; } = new List<Incident>();

    public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}