using System.ComponentModel;
using REBOOTMASTER_Free.Utility;
using _msg = REBOOTMASTER_Free.Message;
using Microsoft.Management.Infrastructure;


namespace REBOOTMASTER_Free.UserControls
{
    public partial class US_Services : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string serviceStatus
        {
            get => serstatus_Lbl.Text;
            set => serstatus_Lbl.Text = value;
        }
        // Constructor
        public US_Services()
        {
            InitializeComponent();
            // Load Services
            Loaded_Services();
            ToolTipWindows.SetToolTip(services_CHBox, _msg.Message._msgSystemServices);
        }

        // Selected Index Changed
        private void service_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh Service Details
            RefreshSelectedServiceDetails();
        }

        // Load Services Method
        private void Loaded_Services()
        {
            // Clear existing items
            service_CBox.Items.Clear();
            // CIM Session
            var session = CimSession.Create(null);
            // Query Instances
            var services = session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Service");

            // Iterate through services
            foreach (var service in services)
            {
                // Access properties
                string name = service.CimInstanceProperties["Name"].Value?.ToString()!;
                string displayName = service.CimInstanceProperties["DisplayName"].Value?.ToString()!;
                string path = service.CimInstanceProperties["PathName"].Value?.ToString()!;


                // Example: Print service details
                if (string.IsNullOrEmpty(path)) continue;

                // Remove surrounding quotes from path
                path = path.Trim('"');

                // Check if the service is already in the ComboBox
                if (!services_CHBox.Checked)
                {
                    // Add service to ComboBox if not already present
                    if (!path.StartsWith(@"C:\WINDOWS", StringComparison.OrdinalIgnoreCase) && !path.StartsWith(@"C:\Program Files", StringComparison.OrdinalIgnoreCase) && !path.StartsWith(@"C:\ProgramData", StringComparison.OrdinalIgnoreCase))
                    {
                        service_CBox.Items.Add(displayName);
                    }
                }
                else
                {
                    // Add all services to ComboBox
                    service_CBox.Items.Add(displayName);
                }
            }
        }

        // Refresh Selected Service Details Method
        private void RefreshSelectedServiceDetails()
        {
            // Update Service Details
            sername_Lbl.Text = ServiceHelper.GetServiceByNameOrDisplayName(service_CBox.SelectedItem!.ToString()!)!.ServiceName.ToString();
            serstatus_Lbl.Text = ServiceHelper.GetServiceByNameOrDisplayName(service_CBox.SelectedItem!.ToString()!)!.Status.ToString();
            // Update Service Description
            string description = CimSession.Create(null).QueryInstances("root\\cimv2", "WQL", $"SELECT * FROM Win32_Service WHERE DisplayName = '{service_CBox.SelectedItem!.ToString()!}'").FirstOrDefault()!.CimInstanceProperties["Description"].Value?.ToString() ?? "";
            // Set RTF formatted text
            string EscapeRtf(string text) { return text.Replace(@"\", @"\\").Replace("{", @"\{").Replace("}", @"\}"); }
            // Set the RTF content
            serdescription_richTextBox.Rtf = $@"{{\rtf1\pard\qj {EscapeRtf(description)}\par}}";

            // Update Button States Based on Service Status
            if (serstatus_Lbl.Text == "Running")
            {
                start_BTN.Enabled = false;
                stop_BTN.Enabled = true;
                restart_BTN.Enabled = true;
            }
            else if (serstatus_Lbl.Text == "Stopped")
            {
                start_BTN.Enabled = true;
                stop_BTN.Enabled = false;
                restart_BTN.Enabled = false;
            }
        }

        // Services CheckBox Changed
        private void services_CHBox_CheckedChanged(object sender, EventArgs e)
        {
            // Disable Buttons
            start_BTN.Enabled = false;
            stop_BTN.Enabled = false;
            restart_BTN.Enabled = false;
            delete_BTN.Enabled = false;

            // Clear Service Details
            sername_Lbl.Text = "-";
            serstatus_Lbl.Text = "-";
            serdescription_richTextBox.Rtf = $@"{{\rtf1\pard\qj -\par}}";

            // Load Services
            Loaded_Services();
        }

        // Service Action Method
        private void ServiceAction(string serviceStatusBTN)
        {
            // Select CheckBox
            services_CHBox.Select();

            // Get Main Form
            Main? main = FindForm() as Main;

            if (main != null)
            {
                // Invoke on Main Form
                main.Invoke((MethodInvoker)delegate
                {
                    // Get Progress Bar Timer
                    System.Windows.Forms.Timer _timerProgressBar = main._timerProgressBar;
                    if (_timerProgressBar != null)
                    {
                        main.Enabled = false;
                        main.isFinish = false;
                        main.isStatus = true;
                        main.SuspendLayout();
                        _timerProgressBar.Start();
                        main.ResumeLayout();
                        // Set Service Name
                        main.serviceName = ServiceHelper.GetServiceByNameOrDisplayName(sername_Lbl.Text)!.ServiceName.ToString();
                        main.serviceStatusBTN = serviceStatusBTN;
                    }
                });
            }
        }

        // Update Button Click Events
        private void update_BTN_Click(object sender, EventArgs e)
        {

        }

        // Start Button Click Events
        private void start_BTN_Click(object sender, EventArgs e)
        {
            // Call Service Action Method
            ServiceAction("Start");

            // Update Button States
            start_BTN.Enabled = false;
            stop_BTN.Enabled = true;
            restart_BTN.Enabled = true;
        }

        // Stop Button Click Events
        private void stop_BTN_Click(object sender, EventArgs e)
        {
            // Call Service Action Method
            ServiceAction("Stop");

            // Update Button States
            start_BTN.Enabled = true;
            stop_BTN.Enabled = false;
            restart_BTN.Enabled = false;
        }

        // Restart Button Click Events
        private void restart_BTN_Click(object sender, EventArgs e)
        {
            // Call Service Action Method
            ServiceAction("Restart");

            // Update Button States
            start_BTN.Enabled = false;
            stop_BTN.Enabled = true;
            restart_BTN.Enabled = true;
        }

        // Delete Button Click Events
        private void delete_BTN_Click(object sender, EventArgs e)
        {

        }
    }
}
