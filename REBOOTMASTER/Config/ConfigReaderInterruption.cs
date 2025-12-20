using System.Reflection;
using System.Configuration;

namespace REBOOTMASTER_Free.Config
{
    internal class ConfigReaderInterruption
    {
        internal static string AutoChecking { get { return GetPropertyAsStringFromConfigInterruption("AutoChecking"); } }
        internal static string AutoRestarting { get { return GetPropertyAsStringFromConfigInterruption("AutoRestarting"); } }
        internal static string IsStatus { get { return GetPropertyAsStringFromConfigInterruption("IsStatus"); } }
        internal static string ServiceOutages { get { return GetPropertyAsStringFromConfigInterruption("ServiceOutages"); } }


        public static Configuration? configInterruption;

        private static string _fileNameconfigInterruption = "ConfigInterruption.dll";

        public static string FileName
        {
            get
            {
                return _fileNameconfigInterruption;
            }
            set
            {
                configInterruption = null;
                _fileNameconfigInterruption = value;
            }
        }

        public static KeyValueConfigurationElement GetPropertyConfigInterruption(string name)
        {
            if (configInterruption == null)
            {
                if (!File.Exists(FileName))
                {
                    FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Environment.CurrentDirectory;
                }

                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = FileName
                };
                configInterruption = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            }

            return configInterruption.AppSettings.Settings[name];
        }

        public static string GetPropertyAsStringFromConfigInterruption(string name)
        {
            return GetPropertyConfigInterruption(name).Value;
        }

    }
}