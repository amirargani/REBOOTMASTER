using REBOOTMASTER.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace REBOOTMASTER.Utility
{
    internal class Service
    {
        public record ServiceInfo
        {
            private string _displayName;
            private bool _isEnabled;
            private DateTime _serviceDateTime;
            private int? _serviceOutage; // Number of service interruptions: An unplanned interruption of a service, during which the service is unavailable for a specified period of time.
            private bool _isStatusSuccess; // Indicates whether the service status retrieval was successful

            // DisplayName property
            public string DisplayName
            {
                get { return _displayName; }
                set { _displayName = value; }
            }

            // IsEnabled property
            public bool IsEnabled
            {
                get { return _isEnabled; }
                set { _isEnabled = value; }
            }

            // ServiceDateTime property
            public DateTime ServiceDateTime
            {
                get { return _serviceDateTime; }
                set { _serviceDateTime = value; }
            }

            // ServiceOutage property
            public int ServiceOutage
            {
                get { return _serviceOutage ?? 0; }
                set { _serviceOutage = value; }
            }

            // IsStatusSuccess property
            public bool IsStatusSuccess
            {
                get { return _isStatusSuccess; }
                set { _isStatusSuccess = value; }
            }

            // Constructor
            public ServiceInfo(string displayName, bool isEnabled, DateTime serviceDateTime, int serviceOutage, bool isStatusSuccess = false)
            {
                _displayName = displayName;
                _isEnabled = isEnabled;
                _serviceDateTime = serviceDateTime;
                _serviceOutage = serviceOutage;
                _isStatusSuccess = isStatusSuccess;
            }
        }

        // Method for retrieving service information from the configuration file
        public static List<ServiceInfo> GetServiceInfo()
        {
            var list = new List<ServiceInfo>(); // List to hold service information

            string configFilePath = Path.Combine( // Construct the path to the config file
                AppDomain.CurrentDomain.BaseDirectory,
                ConfigReaderService.FileName);

            var xmlDoc = new XmlDocument(); // Load the XML document
            xmlDoc.Load(configFilePath); // Load the configuration file

            // Select all 'add' nodes under 'appSettings'
            var nodes = xmlDoc.SelectNodes("//appSettings/add")!;

            foreach (XmlNode node in nodes) // Iterate through each node
            {
                string displayName = node.Attributes!["key"]!.Value; // Get the 'key' attribute (this will be the displayName)
                string value = node.Attributes!["value"]!.Value; // Get the 'value' attribute
                DateTime serviceDateTime = DateTime.Now; // Current date and time
                int serviceOutage = 0; // Initialize service outage count

                bool isEnabled = value.Equals("true", StringComparison.OrdinalIgnoreCase); // Determine if the service is enabled

                // Create ServiceInfo object with the constructor
                list.Add(new ServiceInfo(displayName, isEnabled, serviceDateTime, serviceOutage)); // Add the service information to the list
            }

            return list;
        }
    }
}