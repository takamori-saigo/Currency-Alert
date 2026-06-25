using Contract;
using LoggerService;

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
}