using System.Reflection.Metadata;
using Contract;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;
using Service.Contract;

namespace Currency_Alert.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureLoggerManager(this IServiceCollection service) =>
        service.AddSingleton<ILoggerManager, LoggerManager>();

    public static void ConfigureCors(this IServiceCollection service) =>
        service.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            }
        );

    public static void ConfigureSqlConnection(this IServiceCollection service,
        ConfigurationManager builderConfiguration) =>
        service.AddDbContext<CurrencyAlertContext>(options =>
            options.UseNpgsql(builderConfiguration.GetConnectionString("DefaultConnection")));

    public static void ConfigureRepositoryManager(this IServiceCollection service) =>
        service.AddScoped<IManagerRepository, ManagerRepository>();

    public static void ConfigureServiceManager(this IServiceCollection service) =>
        service.AddScoped<IServiceManager, ServiceManager>();

    public static void ConfigureControllers(this IServiceCollection service) =>
        service.AddControllers().AddApplicationPart(typeof(AssemblyReference).Assembly);
    
    public static void ConfigureAutoMapper(this IServiceCollection service) =>
        service.AddAutoMapper(typeof(Program));
}
