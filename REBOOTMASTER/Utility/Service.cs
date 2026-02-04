using System.Xml;
using REBOOTMASTER.Config;

namespace REBOOTMASTER.Utility
{
    internal class Service
    {
        public record ServiceInfo
        {
            private string _serviceName; // Name of the service
            private bool _isEnabled; // Indicates whether the service is enabled
            private DateTime _serviceDateTime; // Date and time of the service status check
            private int? _serviceOutage; // Number of service interruptions: An unplanned interruption of a service, during which the service is unavailable for a specified period of time.
            private bool _isStatusSuccess; // Indicates whether the service status retrieval was successful

            // ServiceName property
            public string ServiceName
            {
                get { return _serviceName; }
                set { _serviceName = value; }
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
            public ServiceInfo(string serviceName, bool isEnabled, DateTime serviceDateTime, int serviceOutage, bool isStatusSuccess = false)
            {
                _serviceName = serviceName;
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
                string serviceName = node.Attributes!["key"]!.Value; // Get the 'key' attribute (this will be the serviceName)
                string value = node.Attributes!["value"]!.Value; // Get the 'value' attribute
                DateTime serviceDateTime = DateTime.Now; // Current date and time
                int serviceOutage = 0; // Initialize service outage count
                bool isEnabled = value.Equals("true", StringComparison.OrdinalIgnoreCase); // Determine if the service is enabled
                if (ServiceHelper.IsServiceExists(serviceName)) // Check if the service exists
                {
                    // Create ServiceInfo object with the constructor
                    list.Add(new ServiceInfo(serviceName, isEnabled, serviceDateTime, serviceOutage)); // Add the service information to the list
                }
                else
                {
                    // Send a mail if the service status has stopped.
                    NotificationService.SendMailMessage($"Service Name: {serviceName}",
                         $"The service name [.:{serviceName}:.] does not exist on this system." +
                         $"\r\nThis has been removed from the monitoring list and configuration.\r\nPlease check the issue.", $"REBOOTMASTER - [.:{serviceName}:.]");

                    // Update XML Configuration to Delete Service
                    XMLUpdate.UpdateProperty(serviceName, isEnabled.ToString(), ConfigReaderService.configService!, ConfigReaderService.FileName, true);
                }
            }

            // Return the list of service information
            return list;
        }
    }
}