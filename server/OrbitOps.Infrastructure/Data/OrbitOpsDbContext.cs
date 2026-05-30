using Microsoft.EntityFrameworkCore;
using OrbitOps.Domain.Entities;
using System.Reflection.Emit;

namespace OrbitOps.Infrastructure.Data;

public class OrbitOpsDbContext : DbContext
{
    public OrbitOpsDbContext(DbContextOptions<OrbitOpsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Role> Roles => Set<Role>();

    public DbSet<User> Users => Set<User>();

    public DbSet<Hub> Hubs => Set<Hub>();

    public DbSet<Device> Devices => Set<Device>();

    public DbSet<Metric> Metrics => Set<Metric>();

    public DbSet<Alarm> Alarms => Set<Alarm>();

    public DbSet<Incident> Incidents => Set<Incident>();

    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

    public DbSet<Notification> Notifications => Set<Notification>();

    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    public DbSet<DeviceStatusHistory> DeviceStatusHistories => Set<DeviceStatusHistory>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrbitOpsDbContext).Assembly);
    }
}