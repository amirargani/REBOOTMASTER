using REBOOTMASTER.Config;
using REBOOTMASTER.Transition;
using REBOOTMASTER.UserControls;
using REBOOTMASTER.Utility;
using REBOOTMASTER.Windows;
using System.ComponentModel;
using System.ServiceProcess;
using System.Xml;
using _msg = REBOOTMASTER.Message.Message;
using Log = REBOOTMASTER.Utility.Log;

namespace REBOOTMASTER
{
    public partial class Main : Form
    {
        // Variable
        public bool isFinish = false;
        public bool isStatus = false;
        public bool isSettings = false;
        public string serviceName = null!;
        public string serviceStatus = null!;
        public string serviceStatusBTN = null!;
        private bool setProgressBar = false;
        private bool isWindowsFormActive = false;
        private bool showDashboard = true;

        // User Controls
        public static Main? mainObject;
        public US_About uS_About = new US_About();
        public US_Settings uS_Settings = new US_Settings();
        public US_Services uS_Services = new US_Services();
        public US_Dashboard uS_Dashboard = new US_Dashboard();

        // Timer
        public System.Windows.Forms.Timer _progressBarTimer;

        // User Controls Accessors
        public US_Services ServicesControl => uS_Services;

        // Constructor: Main
        public Main()
        {
            InitializeComponent();

            // Set Main Object
            mainObject = this;
            ShowInTaskbar = false;
            panel_UserControl.Visible = false;

            // Timer
            _progressBarTimer = new System.Windows.Forms.Timer();
            _progressBarTimer.Interval = 1; // Interval in milliseconds
            _progressBarTimer.Tick += ProgressBarTimer_Tick!;

            // Initial Dashboard Update
            UpdateDashboard();
        }

        // Main Load
        private void Main_Load(object sender, EventArgs e)
        {
            // https://github.com/GuiferrSouza/WindowsFormAnimation
            var animation = new Animation
            {
                Duration = 1500,
                Flags = Animation.AnimationFlags.Fade,
                Name = "Fade"
            };

            var animate = new Animate();
            animate.AnimationStarted += (anim) =>
            {
                Cursor = Cursors.Default;
                Invalidate();
                Update();
                ProgressBarTimer.Start();
            };
            animate.Play(Handle, animation);
        }

        // Deactivate Button
        public void DeaktiviereButton()
        {
            Services_BTN.Enabled = false;
            Settings_BTN.Enabled = false;
        }

        // Activate Button
        public void AktiviereButton()
        {
            Services_BTN.Enabled = true;
            Settings_BTN.Enabled = true;
        }


        // Update Dashboard Method
        private void UpdateDashboard()
        {
            uS_Dashboard.sermonitoringcount = GetTotalServicesCount().ToString();
            uS_Dashboard.autorestartsercount = GetEnabledServicesCount().ToString();
        }

        // Event handler for when the dashboard loads
        private int GetTotalServicesCount()
        {
            string configFilePath = Path.Combine( // Use Path.Combine for cross-platform compatibility
                AppDomain.CurrentDomain.BaseDirectory,
                ConfigReaderService.FileName);

            var xmlDoc = new XmlDocument(); // Create an instance of XmlDocument
            xmlDoc.Load(configFilePath); // Load the XML file

            var nodes = xmlDoc.SelectNodes("configuration/appSettings/add"); // Select all service nodes
            return nodes?.Count ?? 0; // Return the count of nodes, or 0 if null
        }

        // Method to get the count of enabled services
        private int GetEnabledServicesCount()
        {
            string configFilePath = Path.Combine( // Use Path.Combine for cross-platform compatibility
                AppDomain.CurrentDomain.BaseDirectory,
                ConfigReaderService.FileName);

            var xmlDoc = new XmlDocument(); // Create an instance of XmlDocument
            xmlDoc.Load(configFilePath); // Load the XML file

            var nodes = xmlDoc.SelectNodes("configuration/appSettings/add[@value='true']"); // Select enabled service nodes
            return nodes?.Count ?? 0; // Return the count of nodes, or 0 if null
        }

        // Timer ProgressBar: Start
        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            if (!setProgressBar) panel_ProgressBar.Width += 5;
            if (panel_ProgressBar.Width >= 800)
            {
                ProgressBarTimer.Stop();
                _progressBarTimer.Stop();
                if (!isWindowsFormActive)
                {
                    ShowInTaskbar = true;
                    Invalidate();
                    Update();
                    isWindowsFormActive = true;
                }
                ResetProgressBarTimer.Start();
            }
        }

        // Timer ProgressBar: Reset
        private void ResetProgressBarTimer_Tick(object sender, EventArgs e)
        {
            if (!setProgressBar) panel_ProgressBar.Width -= 5;
            if (panel_ProgressBar.Width <= 0)
            {
                ResetProgressBarTimer.Stop();
                Dashboard_BTN.Visible = true;
                Services_BTN.Visible = true;
                Settings_BTN.Visible = true;
                About_BTN.Visible = true;
                Close_BTN.Visible = true;
                Minimized_BTN.Visible = true;
                isFinish = true;
                if (isStatus)
                {
                    try
                    {
                        if (serviceStatusBTN == "Start")
                        {
                            // Start Service
                            ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Start();
                            Log.Logger!.Info($"{serviceName} running. {_msg._msgSuccessfulServiceRunning}");
                            ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                        }
                        else if (serviceStatusBTN == "Stop")
                        {
                            // Stop Service
                            ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Stop();
                            Log.Logger!.Info($"{serviceName} stopped. {_msg._msgSuccessfulServiceStopped}");
                            ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
                        }
                        else if (serviceStatusBTN == "Restart")
                        {
                            // Restart Service
                            ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Refresh();
                            if (ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Status.Equals(ServiceControllerStatus.Running))
                            {
                                // Service is running, so stop it first
                                ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Stop();
                                Log.Logger!.Info($"{serviceName} stopped. {_msg._msgSuccessfulServiceStopped}");
                                ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));

                                // Then start the service
                                ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Start();
                                Log.Logger!.Info($"{serviceName} running. {_msg._msgSuccessfulServiceRunning}");
                                ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                            }
                        }

                        // Update service status in the Services user control
                        var main = FindForm() as Main;

                        // Get Services User Control
                        var services = main?.ServicesControl;

                        // Update Service Status
                        if (serviceName != null)
                        {
                            // Update the service status property
                            services!.serviceStatus = ServiceHelper.GetServiceByNameOrDisplayName(serviceName)!.Status.ToString();
                        }

                        // Set flag to update description service
                        services!.descriptionService = true;

                        // Refresh Main UI
                        Enabled = true;

                        // Refresh Selected Service Details
                        UpdateDashboard();
                    }
                    catch (Exception ex)
                    {
                        // Send Exception Details via Email
                        NotificationService.GetException(ex);
                        Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + ex.StackTrace}"); // Log error
                    }
                }
                if (isSettings) { Enabled = true; isSettings = false; } // Refresh Main UI
                if (showDashboard) // Show Dashboard User Control
                {
                    Dashboard_BTN.PerformClick(); // Load Dashboard User Control
                    showDashboard = false;
                }
            }
        }

        // Close Button
        private void Close_BTN_Click(object sender, EventArgs e)
        {
            // focus and select main form
            this.Focus();
            this.Select();

            // Close Application
            Close();
            Log.Logger!.Info("REBOOTMASTER has been closed. The application is no longer in operation."); // Log info
        }

        // Minimized Button
        private async void Minimized_BTN_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) // Minimize window
            {
                // Fade-Out
                Effect effect = new Effect(this);
                await effect.HideAsync();

                // Minimize to tray
                Hide();

                // Show NotifyIcon
                MainNotifyIcon.Visible = true;
                MainNotifyIcon.Text = "REBOOTMASTER";
                MainNotifyIcon.BalloonTipTitle = "REBOOTMASTER vFree";
                MainNotifyIcon.BalloonTipText = "GitHub: https://github.com/amirargani";
                MainNotifyIcon.ShowBalloonTip(1000);

                // focus and select main form
                this.Focus();
                this.Select();

                Log.Logger!.Info("REBOOTMASTER minimized. The program was minimized."); // Log info
            }
        }

        // NotifyIcon
        private async void MainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Restore window
            Show();

            // Fade-In
            Effect effect = new Effect(this);
            await effect.FadeAsync(true);

            // Restore window state
            Opacity = 1;
            WindowState = FormWindowState.Normal;
            MainNotifyIcon.Visible = false;

            // Log info
            Log.Logger!.Info("REBOOTMASTER normalized. The program was normalized.");

        }

        // Strip Menu Item >> Exit Application
        private void ExitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // Close Application
        }

        // Main Form Closing
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the close event initially

            // Show different messages based on isFinish flag
            if (!isFinish)
            {
                MessageBox.Show(_msg._msgCloseApp, _msg._caption, MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show warning message
                Log.Logger!.Warn($"REBOOTMASTER closed. {_msg._msgCloseApp}"); // Log Warn
            }
            else if (isFinish)
            {
                if (MessageBox.Show(_msg._msg, _msg._caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    e.Cancel = false; // Not Working: Application.Exit(); | Close();
                    Log.Logger!.Info("REBOOTMASTER closed. The program was closed."); // Log Info
                }
            }
        }

        // About Button
        private void About_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_About); // Load About User Control
        }


        // Settings Button
        private void Settings_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_Settings); // Load Settings User Control
        }


        // Services Button
        private void Services_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_Services); // Load Services User Control
        }


        // Dashboard Button
        private void Dashboard_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_Dashboard); // Load Dashboard User Control
        }
    }
}