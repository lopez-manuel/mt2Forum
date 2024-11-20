using Microsoft.EntityFrameworkCore;
using Mt2Forum.Extensions;
using Repository;

namespace Mt2Forum;

internal static class Startup
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureCors();
        services.AddRepositoryManager();
        services.AddServiceManager();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<RepositoryContext>(o =>
        {
            o.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                ?? throw new ArgumentException("Default connection string not found"), 
                    b => b.MigrationsAssembly(typeof(RepositoryContext).Assembly.FullName));
        });
    }

    public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints( (conf) => conf.MapControllers() );
    }
}