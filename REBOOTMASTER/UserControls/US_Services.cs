using System.Xml;
using REBOOTMASTER.Config;
using REBOOTMASTER.Utility;
using System.ComponentModel;
using _msg = REBOOTMASTER.Message;
using Microsoft.Management.Infrastructure;

namespace REBOOTMASTER.UserControls
{
    public partial class US_Services : UserControl
    {
        // Service Name Property
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string serviceStatus
        {
            get => serstatus_Lbl.Text;
            set => serstatus_Lbl.Text = value;
        }

        // Service Description Property
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool descriptionService
        {
            get => serdescription_richTextBox.Visible;
            set => serdescription_richTextBox.Visible = value;
        }


        // Selected Service Variable
        string selected = null!;

        // Constructor
        public US_Services()
        {
            InitializeComponent();
            // Load Services
            Loaded_Services();
            ToolTipWindows.SetToolTip(Services_CHBox, _msg.Message._msgSystemServicesToolTip);
            ToolTipWindows.SetToolTip(autoRestarting_CHBox, _msg.Message._msgAddServiceCheckboxToolTip);
            ToolTipWindows.SetToolTip(Myser_Rad, _msg.Message._msgMyServicesToolTip);
        }

        // Selected Index Changed
        private void Service_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh Service Details
            RefreshSelectedServiceDetails();
        }

        // Get Setting Node Method
        private XmlNode? GetSettingNode(string key)
        {
            string configFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                ConfigReaderService.FileName);

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(configFilePath);

            return xmlDoc.SelectSingleNode($"configuration/appSettings/add[@key='{key}']");
        }

        // Check if Service Exists Method
        private bool IsServiceExists(string key)
        {
            return GetSettingNode(key) != null;
        }

        // Check if Service is Enabled Method
        private bool IsServiceEnabled(string key)
        {
            var node = GetSettingNode(key);
            if (node == null)
                return false;

            string value = node.Attributes?["value"]?.Value ?? "false";
            return value.Equals("true", StringComparison.OrdinalIgnoreCase);
        }

        // Load Services Method
        private void Loaded_Services()
        {
            // Clear existing items
            Service_CBox.Items.Clear();

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

                // Check if service is in config
                bool isInConfig = IsServiceExists(name);

                // If My Services is selected, only add services in config
                if (Myser_Rad.Checked && isInConfig)
                {
                    Service_CBox.Items.Add(displayName);
                    continue;
                }
                // Check if the service is already in the ComboBox
                else if (Services_Rad.Checked && !Services_CHBox.Checked)
                {
                    //otherServices = configServices;
                    // Add service to ComboBox if not already present
                    if (!path.StartsWith(@"C:\WINDOWS", StringComparison.OrdinalIgnoreCase) && !path.StartsWith(@"C:\Program Files", StringComparison.OrdinalIgnoreCase) && !path.StartsWith(@"C:\ProgramData", StringComparison.OrdinalIgnoreCase))
                    {
                        // Add to other services list
                        Service_CBox.Items.Add(displayName);
                    }
                } // If All Services is selected, add all services
                else if (Services_Rad.Checked && Services_CHBox.Checked)
                {
                    // Add to all services list
                    Service_CBox.Items.Add(displayName);
                }
            }

            // Restore Selected Service
            if (selected != null) { Service_CBox.Text = selected; }
        }

        // Refresh Selected Service Details Method
        private void RefreshSelectedServiceDetails()
        {
            // Update Service Details
            sername_Lbl.Text = ServiceHelper.GetServiceByName(Service_CBox.SelectedItem!.ToString()!)!.ServiceName.ToString();
            serstatus_Lbl.Text = ServiceHelper.GetServiceByName(Service_CBox.SelectedItem!.ToString()!)!.Status.ToString();

            // Update Service Description
            string description = CimSession.Create(null).QueryInstances("root\\cimv2", "WQL", $"SELECT * FROM Win32_Service WHERE DisplayName = '{Service_CBox.SelectedItem!.ToString()!}'").FirstOrDefault()!.CimInstanceProperties["Description"].Value?.ToString() ?? "";

            // Set RTF formatted text
            string EscapeRtf(string text) { return text.Replace(@"\", @"\\").Replace("{", @"\{").Replace("}", @"\}"); }

            // Set the RTF content
            serdescription_richTextBox.Rtf = $@"{{\rtf1\pard\qj {EscapeRtf(description)}\par}}";

            // Update Button States Based on Service Status
            if (serstatus_Lbl.Text == "Running")
            {
                Start_BTN.Enabled = false;
                Stop_BTN.Enabled = true;
                Restart_BTN.Enabled = true;
            }
            else if (serstatus_Lbl.Text == "Stopped")
            {
                Start_BTN.Enabled = true;
                Stop_BTN.Enabled = false;
                Restart_BTN.Enabled = false;
            }

            // Update Auto Restarting CheckBox and Delete Button State
            if (IsServiceExists(sername_Lbl.Text))
            {
                autoRestarting_CHBox.Checked = IsServiceEnabled(sername_Lbl.Text);
                Delete_BTN.Enabled = true;
                added_Lbl.BackColor = Color.SeaGreen;
                added_Lbl.Text = _msg.Message._msgTheServiceIsAdded +
                 (IsServiceEnabled(sername_Lbl.Text)
                     ? " and is set to restart automatically."
                     : ".");
            }
            else
            {
                autoRestarting_CHBox.Checked = false;
                Delete_BTN.Enabled = false;
                added_Lbl.BackColor = Color.Maroon;
                added_Lbl.Text = _msg.Message._msgTheServiceIsNotAdded;
            }

            // Enable or Disable Update Button
            if (Service_CBox.SelectedIndex == -1) { Update_BTN.Enabled = false; }
            else { Update_BTN.Enabled = true; }
        }

        // Confirm Action Method
        private void ConfirmAction()
        {
            // Update XML Configuration to Add/Update Service
            XMLUpdate.UpdateProperty(sername_Lbl.Text, autoRestarting_CHBox.Checked.ToString().ToLower(), ConfigReaderService.configService!, ConfigReaderService.FileName);

            // Refresh Service Details
            RefreshSelectedServiceDetails();

            // Call Service Action Method
            ServiceAction();

            // Show Success Message
            MessageBox.Show(_msg.Message._msgServiceSuccessfullyAdded, _msg.Message._captionInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Enable Delete Button
            Delete_BTN.Enabled = true;
        }

        // Radio Button Checked Changed Events
        private void Services_Rad_CheckedChanged(object sender, EventArgs e)
        {
            // Enable Services CheckBox
            Services_CHBox.Enabled = true;

            // Store Selected Service
            if (Service_CBox.Text != null) { selected = Service_CBox.Text; }

            // Reload Services 
            Loaded_Services();

            // Selected Index Method
            SelectedIndex();
        }

        // Radio Button Checked Changed Events
        private void Myser_Rad_CheckedChanged(object sender, EventArgs e)
        {
            // Disable Services CheckBox
            Services_CHBox.Enabled = false;

            // Store Selected Service
            if (Service_CBox.Text != null) { selected = Service_CBox.Text; }

            // Reload Services
            Loaded_Services();

            // Selected Index Method
            SelectedIndex();
        }

        // Services CheckBox Changed
        private void Services_CHBox_CheckedChanged(object sender, EventArgs e)
        {
            // Store Selected Service
            if (Service_CBox.Text != null) { selected = Service_CBox.Text; }

            // Load Services
            Loaded_Services();

            if (!Services_CHBox.Checked && Service_CBox.SelectedIndex == -1) { ClearServiceDetails(); }
        }

        // Selected Index Method
        private void SelectedIndex()
        {
            // Enable or Disable Update Button
            if (Service_CBox.SelectedIndex == -1) { Update_BTN.Enabled = false; ClearServiceDetails(); }
            else { Update_BTN.Enabled = true; }
        }

        // Clear Service Details Method
        private void ClearServiceDetails()
        {
            // Clear Service Details
            sername_Lbl.Text = "-";
            serstatus_Lbl.Text = "-";
            serdescription_richTextBox.Rtf = $@"{{\rtf1\pard\qj -\par}}";
            added_Lbl.Text = "";

            // Disable Buttons
            Start_BTN.Enabled = false;
            Stop_BTN.Enabled = false;
            Restart_BTN.Enabled = false;
            Update_BTN.Enabled = false;
        }

        // Service Action Method
        private void ServiceAction(string serviceStatusBTN = null!)
        {
            // Select CheckBox
            Services_CHBox.Select();

            // Hide Description RichTextBox
            serdescription_richTextBox.Visible = false;

            // Get Main Form
            Main? main = FindForm() as Main;

            if (main != null)
            {
                // Invoke on Main Form
                main.Invoke((MethodInvoker)delegate
                {
                    // Get Progress Bar Timer
                    System.Windows.Forms.Timer _timerProgressBar = main._progressBarTimer;
                    if (_timerProgressBar != null)
                    {
                        // Update Main Form State
                        main.Enabled = false;
                        main.isFinish = false;
                        main.isStatus = true;
                        main.SuspendLayout();
                        _timerProgressBar.Start();
                        main.ResumeLayout();

                        // Set Service Name
                        main.serviceName = (Service_CBox.Items.Count > 1 && sername_Lbl.Text != "-") ? ServiceHelper.GetServiceByName(sername_Lbl.Text)!.ServiceName.ToString() : null!;
                        main.serviceStatusBTN = serviceStatusBTN;
                    }
                });
            }
        }

        // Update Button Click Events
        private void Update_BTN_Click(object sender, EventArgs e)
        {
            // Validate Service Selection
            if (Service_CBox.SelectedItem == null)
            {
                // Show Warning Message
                MessageBox.Show(_msg.Message._msgSelectService, _msg.Message._captionWarning,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if Service Already Exists
            if (IsServiceExists(sername_Lbl.Text))
            {
                // Show Confirmation Dialog
                var result = MessageBox.Show(_msg.Message._msgServiceAlreadyExists + " " + _msg.Message._msgUpdate + " and " + _msg.Message._msgServiceIsUpdate,
                                             _msg.Message._captionWarning,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                // If User Selects No, Return
                if (result != DialogResult.Yes)
                    return;
            }
            else
            {
                // Show Confirmation Dialog for New Service
                var result = MessageBox.Show(_msg.Message._msgServiceIsUpdate,
                                             _msg.Message._captionWarning,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);
                // If User Selects No, Return
                if (result != DialogResult.Yes)
                    return;
            }

            // Confirm Action Method
            ConfirmAction();
        }

        // Start Button Click Events
        private void Start_BTN_Click(object sender, EventArgs e)
        {
            // Call Service Action Method
            ServiceAction("Start");

            // Update Button States
            Start_BTN.Enabled = false;
            Stop_BTN.Enabled = true;
            Restart_BTN.Enabled = true;
        }

        // Stop Button Click Events
        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            // Call Service Action Method
            ServiceAction("Stop");

            // Update Button States
            Start_BTN.Enabled = true;
            Stop_BTN.Enabled = false;
            Restart_BTN.Enabled = false;
        }

        // Restart Button Click Events
        private void Restart_BTN_Click(object sender, EventArgs e)
        {
            // Call Service Action Method
            ServiceAction("Restart");

            // Update Button States
            Start_BTN.Enabled = false;
            Stop_BTN.Enabled = true;
            Restart_BTN.Enabled = true;
        }

        // Delete Button Click Events
        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            // Confirm Delete Action
            if (MessageBox.Show(_msg.Message._msgServiceIsDelete, _msg.Message._captionWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Store Selected Service
                selected = Service_CBox.Text;

                // Update XML Configuration to Delete Service
                XMLUpdate.UpdateProperty(sername_Lbl.Text, autoRestarting_CHBox.Checked.ToString().ToLower(), ConfigReaderService.configService!, ConfigReaderService.FileName, true);

                // Reset Auto Restarting CheckBox and Disable Delete Button
                autoRestarting_CHBox.Checked = false;
                Delete_BTN.Enabled = false;

                // Restore Selected Service
                if (!Myser_Rad.Checked) { Service_CBox.SelectedItem = selected; }
                // Set Selected Index to Previous Item
                else if (Myser_Rad.Checked)
                {
                    // Reload Services
                    Loaded_Services();

                    // Set Selected Index to Previous Item
                    Service_CBox.SelectedIndex = Service_CBox.Items.Count - 1;

                    // Check if ComboBox is Empty
                    if (Service_CBox.Items.Count == 0)
                    {
                        // Clear Service Details
                        ClearServiceDetails();
                    }
                }

                // If the combo box still contains entries after deletion, update the details, if it is empty, select the Services radio button.
                if (Service_CBox.Items.Count > 0) { RefreshSelectedServiceDetails(); } else { Services_Rad.Checked = true; }

                // Call Service Action Method
                ServiceAction();

                // Show Success Message
                MessageBox.Show(_msg.Message._msgSuccessfulServiceDeleted, _msg.Message._captionInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}