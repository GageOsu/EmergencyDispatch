using EmergencyDispatchService.Application.Common.Interface;
using EmergencyDispatchService.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EmergencyDispatchService.Infrastructure.Common;

public class EmergencyDispatchServiceDbContext : DbContext, IUnitOfWork
{

    public DbSet<User> Users { get; set; } = null!;

    public EmergencyDispatchServiceDbContext(DbContextOptions options)
        : base(options)
    {

    }

    public async Task CommitChangesAsync()
    {
        await base.SaveChangesAsync();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}