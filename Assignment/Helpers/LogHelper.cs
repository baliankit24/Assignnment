using Serilog;
using Serilog.Core;

namespace Assginment.Helpers
{
    public class LogHelper
    {
        private LogHelper() { }
        private static Logger _logInstance;
        private static volatile object _flag = new object();

        public static Logger GetLogInstance()
        {
            if (_logInstance == null)
            {
                lock (_flag)
                {
                    _logInstance = new LoggerConfiguration().WriteTo.Console().CreateLogger();
                }
            }
            return _logInstance;
        }
    }
}