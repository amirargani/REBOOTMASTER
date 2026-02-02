using System.Xml;
using System.Configuration;
using _msg = REBOOTMASTER.Message;
using Log = REBOOTMASTER.Utility.Log;

namespace REBOOTMASTER.Config
{
    public class XMLUpdate
    {
        // Method to update or delete a property in the specified config file
        public static void UpdateProperty(string name, string value, object config, string fileName, bool delService = false)
        {
            // Load the XML configuration file
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName); // Get the full path to the config file
            XmlDocument xmlDoc = new XmlDocument(); // Load the XML document
            xmlDoc.Load(configFilePath); // Load the config file
            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings")!; // Find the appSettings node
            if (appSettingsNode == null) // If the appSettings node is not found, log an error and throw an exception
            {
                Log.Logger!.Error($"Unexpected error: {_msg.Message._msgErrorAppSettings}");
                throw new InvalidOperationException();
            }
            XmlElement settingElement = (XmlElement)appSettingsNode.SelectSingleNode($"add[@key='{name}']")!; // Find the setting element by key
            if (settingElement != null) // If the setting element exists, update or delete it
            {
                if (!delService) { settingElement.SetAttribute("value", value); } // Update the value
                else // Delete the setting
                {
                    appSettingsNode.RemoveChild(settingElement);
                }
            }
            else // If the setting element does not exist, create a new one
            {
                XmlElement newSettingElement = xmlDoc.CreateElement("add"); // Create a new setting element
                newSettingElement.SetAttribute("key", name); // Set the key attribute
                newSettingElement.SetAttribute("value", value); // Set the value attribute
                appSettingsNode.AppendChild(newSettingElement); // Add the new setting element to the appSettings node
            }
            xmlDoc.Save(configFilePath); // Save the updated XML document

            // Refresh the configuration section to reflect changes
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = fileName
            };
            config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None); // Open the updated configuration file
            ConfigurationManager.RefreshSection("appSettings"); // Refresh the appSettings section
        }
    }
}