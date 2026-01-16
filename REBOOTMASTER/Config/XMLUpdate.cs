using System.Xml;
using System.Configuration;
using _msg = REBOOTMASTER_Free.Message;
using Log = REBOOTMASTER_Free.Utility.Log;

namespace REBOOTMASTER_Free.Config
{
    internal class XMLUpdate
    {
        public static void UpdateProperty(string name, string value, object config, string fileName, bool delService = false)
        {
            // Configuration to save
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(configFilePath);
            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings")!;
            if (appSettingsNode == null)
            {
                Log.Logger!.Error($"Unexpected error: {_msg.Message._msgErrorAppSettings}");
                throw new InvalidOperationException();
            }
            XmlElement settingElement = (XmlElement)appSettingsNode.SelectSingleNode($"add[@key='{name}']")!;
            if (settingElement != null)
            {
                if (!delService) { settingElement.SetAttribute("value", value); }
                else
                {
                    appSettingsNode.RemoveChild(settingElement);
                }
            }
            else
            {
                XmlElement newSettingElement = xmlDoc.CreateElement("add");
                newSettingElement.SetAttribute("key", name);
                newSettingElement.SetAttribute("value", value);
                appSettingsNode.AppendChild(newSettingElement);
            }
            xmlDoc.Save(configFilePath);

            // Configuration to update
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = fileName
            };
            config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}