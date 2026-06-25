using Contract;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;

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
}