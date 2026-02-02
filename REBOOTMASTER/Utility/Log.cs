using log4net;
using log4net.Config;

namespace REBOOTMASTER.Utility
{
    public class Log
    {
        // Logger instance
        public static ILog? Logger { get; private set; }

        // Static constructor to configure log4net
        static Log()
        {
            XmlConfigurator.Configure(new FileInfo("Log.dll"));
            Logger = LogManager.GetLogger(typeof(Program));
        }
    }
}