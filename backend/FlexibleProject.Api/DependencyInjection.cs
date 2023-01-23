using System.Reflection;
using FlexibleProject.Api.Abstractions;
using FlexibleProject.Api.Services;
using Mapster;
using MapsterMapper;

namespace FlexibleProject.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        // Mappings
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());
        services.AddSingleton(config);
        services.AddSingleton<IMapper, ServiceMapper>();

        // Services
        services.AddSingleton<IUsersService, UsersService>();
        
        return services;
    }
}