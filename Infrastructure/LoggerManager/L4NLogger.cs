using Infrastructure.ILoggerManager;
using log4net;

namespace Infrastructure.LoggerManager
{
    public class L4NLogger : ILogger
    {
        public readonly ILog log;

        public L4NLogger(string loger)
        {
            log4net.Config.DOMConfigurator.Configure();
            log = LogManager.GetLogger(loger);
        }

        public void AddExceptionError(string message)
        {
            log.Error(message);
        }


    }
}
