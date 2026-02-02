using System.Reflection;
using System.Configuration;

namespace REBOOTMASTER.Config
{
    public class ConfigReaderInterruption
    {
        // Properties
        internal static string AutoChecking { get { return GetPropertyAsStringFromConfigInterruption("AutoChecking"); } }
        internal static string AutoRestarting { get { return GetPropertyAsStringFromConfigInterruption("AutoRestarting"); } }
        internal static string IsStatus { get { return GetPropertyAsStringFromConfigInterruption("IsStatus"); } }
        internal static string ServiceOutages { get { return GetPropertyAsStringFromConfigInterruption("ServiceOutages"); } }

        // Configuration object
        public static Configuration? configInterruption;

        // ConfigInterruption.dll file name
        private static string _fileNameconfigInterruption = "ConfigInterruption.dll";

        // Get or set ConfigInterruption.dll file name
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

        // Reload configuration
        public static void Reload()
        {
            configInterruption = null;
        }

        // Get property from ConfigInterruption.dll
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

        // Get property value as string from ConfigInterruption.dll
        public static string GetPropertyAsStringFromConfigInterruption(string name)
        {
            var property = GetPropertyConfigInterruption(name);
            return property?.Value ?? string.Empty;
        }

    }
}