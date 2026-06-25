using Contract;
using LoggerService;

namespace Currency_Alert.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureLoggerManager(this IServiceCollection service) =>
        service.AddSingleton<ILoggerManager, LoggerManager>();
}