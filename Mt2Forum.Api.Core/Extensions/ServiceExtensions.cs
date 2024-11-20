using Mt2Forum.Api.Contracts;
using Mt2Forum.Api.Service;
using Mt2Forum.Api.Service.Interfaces;

namespace Mt2Forum.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("Mt2ForumCorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader() );
        });
    }

    public static void AddRepositoryManager(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryManager, IRepositoryManager>();
    }

    public static void AddServiceManager(this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
    }
}