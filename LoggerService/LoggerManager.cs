using Contract;
using Microsoft.Extensions.Logging;
using NLog;

namespace LoggerService;

public class LoggerManager: ILoggerManager
{
    private readonly Logger _logger;

    public LoggerManager()
    {
        _logger = LogManager.GetCurrentClassLogger();
    }
    
    public void info(string message)
    {
        _logger.Info(message);
    }

    public void error(string message)
    {
        _logger.Error(message);
    }

    public void warning(string message)
    {
        _logger.Warn(message);
    }

    public void debug(string message)
    {
        _logger.Debug(message);
    }
}