namespace Contract;

public interface ILoggerManager
{
    void info(string message);
    void error(string message);
    void warning(string message);
    void debug(string message);
}