using log4net;
using log4net.Config;

namespace REBOOTMASTER_Free.Utility
{
    internal class Log
    {
        public static ILog? Logger { get; private set; }
        static Log()
        {
            XmlConfigurator.Configure(new FileInfo("Log.dll"));
            Logger = LogManager.GetLogger(typeof(Program));
        }
    }
}