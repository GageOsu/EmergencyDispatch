
using EmergencyDispatchService.Application.Common.Interface;
using EmergencyDispatchService.Infrastructure.Common;
using EmergencyDispatchService.Infrastructure.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmergencyDispatchService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationManager configuration)
    {
        var stringConnection = configuration.GetConnectionString("ConnectionStrings");
        services.AddDbContext<EmergencyDispatchServiceDbContext>(options =>
        options.UseNpgsql(stringConnection));

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<IUnitOfWork>());

        return services;
    }
}
