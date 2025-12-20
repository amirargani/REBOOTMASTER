using System.Net.Mail;
using System.Reflection;
using System.Configuration;
using REBOOTMASTER_Free.Utility;
using MailService = REBOOTMASTER_Free.Utility.MailService;

namespace REBOOTMASTER_Free.Config
{
    internal class ConfigReaderMail
    {
        // SMTP
        internal static string Recipient { get { return GetPropertyAsStringFromConfigMail("Recipient"); } }
        internal static SmtpClient Smtp { get { return MailService.GetSmtpClient(Security.GetString(SmtpUser), Security.GetString(SmtpPassword), Security.GetString(SmtpHost), Convert.ToInt32(Security.GetString(SmtpPort)), true); } }
        internal static string SmtpHost { get { return GetPropertyAsStringFromConfigMail("SmtpHost"); } }
        internal static string SmtpPort { get { return GetPropertyAsStringFromConfigMail("SmtpPort"); } }
        internal static string SmtpPassword { get { return GetPropertyAsStringFromConfigMail("SmtpPassword"); } }
        internal static string SmtpUser { get { return GetPropertyAsStringFromConfigMail("SmtpUser"); } }

        // Templates
        internal static string TemplatePath1 { get { return GetPropertyAsStringFromConfigMail("TemplatePath1"); } }
        internal static string TemplatePath2 { get { return GetPropertyAsStringFromConfigMail("TemplatePath2"); } }
        internal static string TemplatePath3 { get { return GetPropertyAsStringFromConfigMail("TemplatePath3"); } }


        public static Configuration? configMail;

        private static string _fileNameConfigMail = "ConfigMail.dll";

        public static string FileName
        {
            get
            {
                return _fileNameConfigMail;
            }
            set
            {
                configMail = null;
                _fileNameConfigMail = value;
            }
        }

        public static KeyValueConfigurationElement GetPropertyConfigMail(string name)
        {
            if (configMail == null)
            {
                if (!File.Exists(FileName))
                {
                    FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Environment.CurrentDirectory;
                }

                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = FileName
                };
                configMail = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            }

            return configMail.AppSettings.Settings[name];
        }

        public static string GetPropertyAsStringFromConfigMail(string name)
        {
            return GetPropertyConfigMail(name).Value;
        }
    }
}