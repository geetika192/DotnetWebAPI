using NLog;
namespace ContactRepository.Log
{
    public class LoggerManager : ILoggerManager
    {
         private static ILogger logger = LogManager.GetCurrentClassLogger();
        void ILoggerManager.LogDebug(string message)
        {
            logger.Debug(message);
        }

        void ILoggerManager.LogError(string message)
        {
            logger.Error(message);
        }

        void ILoggerManager.LogInfo(string message)
        {
             logger.Info(message);
        }

        void ILoggerManager.LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}