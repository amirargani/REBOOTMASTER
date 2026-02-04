using REBOOTMASTER.Config;
using REBOOTMASTER.Utility;
using System.ComponentModel;
using System.ServiceProcess;
using Log = REBOOTMASTER.Utility.Log;
using _msg = REBOOTMASTER.Message.Message;

namespace REBOOTMASTER.UserControls
{
    public partial class US_Dashboard : UserControl
    {
        // Property to get or set the service monitoring count
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string sermonitoringcount
        {
            get => sermonitoringcount_lbl.Text;
            set => SetLabelAndCenter(sermonitoringcount_lbl, sermonitoring_panel, value);
        }

        // Property to get or set the unexpected failures count
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string autorestartsercount
        {
            get => autorestartsercount_Lbl.Text;
            set => SetLabelAndCenter(autorestartsercount_Lbl, autorestartser_panel, value);
        }

        // Property to get or set the inactive services count
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string unexpectedfailurescount
        {
            get => unexpectedfailurescount_Lbl.Text;
            set => SetLabelAndCenter(unexpectedfailurescount_Lbl, unexpectedfailures_panel, value);
        }

        // Property to get or set the inactive services count
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string inactiveser
        {
            get => inactiveser_Lbl.Text;
            set => SetLabelAndCenter(inactiveser_Lbl, inactiveser_panel, value);
        }

        // Default service outage count
        List<Service.ServiceInfo>? services;
        List<Service.ServiceInfo>? tempServices = new List<Service.ServiceInfo>();

        // Timeout for async operations
        TimeSpan timeout = new TimeSpan(0, 0, 30); // 30 Seconds
        DateTime dateTimeNow; // DateTime Now

        // Default Service Outage Count
        int DefaultServiceOutag; // x times => x - 1

        // Total Service Outage Count
        int totalServiceOutageCount = 0;

        // Constructor
        public US_Dashboard()
        {
            InitializeComponent();

            // Center the label within its panel
            CenterLabelInPanel(sermonitoring_Lbl, sermonitoring_panel);
            CenterLabelInPanel(sermonitoringsubtitle_Lbl, sermonitoring_panel);
            CenterLabelInPanel(sermonitoringcount_lbl, sermonitoring_panel);

            CenterLabelInPanel(autorestartser_Lbl, autorestartser_panel);
            CenterLabelInPanel(autorestartsersubtitle_Lbl, autorestartser_panel);
            CenterLabelInPanel(autorestartsercount_Lbl, autorestartser_panel);

            CenterLabelInPanel(unexpectedfailures_Lbl, unexpectedfailures_panel);
            CenterLabelInPanel(unexpectedfailuressubtitle_Lbl, unexpectedfailures_panel);
            CenterLabelInPanel(unexpectedfailurescount_Lbl, unexpectedfailures_panel);

            CenterLabelInPanel(inactiveser_Lbl, inactiveser_panel);
            CenterLabelInPanel(inactivesersubtitle_Lbl, inactiveser_panel);
            CenterLabelInPanel(inactivesercount_Lbl, inactiveser_panel);


            CenterLabelInPanel(livelog_Lbl, livelog_panel);
            CenterLabelInPanel(livelogsubtitle_Lbl, livelog_panel);
        }

        // Method to center a label within a panel
        private void CenterLabelInPanel(Label label, Panel panel)
        {
            // Calculate the width of the text in the label.
            int textWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;

            // Set the X position to center the label.
            label.Location = new Point(
                (panel.Width - textWidth) / 2,  // Center the label
                label.Location.Y                // Maintain the Y position
            );
        }

        // Helper method to set label text and center it
        private void SetLabelAndCenter(Label lbl, Panel pnl, string value)
        {
            lbl.Text = value; // Set the label text
            CenterLabelInPanel(lbl, pnl); // Center the label after setting the text
        }

        // Start Button Click Events
        private void Start_BTN_Click(object sender, EventArgs e)
        {
            // Confirm starting service monitoring
            if (MessageBox.Show(_msg._msgStartMonitorServices, _msg._captionInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                log_Lbl.Text = ""; // Clear live log label

                // Reload SMTP configurations
                ConfigReaderMail.Reload();

                // Reload interruption configurations
                ConfigReaderInterruption.Reload();

                // Validate SMTP configuration values
                if (NotificationService.AreSMTPValuesValid())
                {
                    // Get the list of services to monitor
                    services = Service.GetServiceInfo();
                    if (services!.Any())
                    {
                        // Set the default service outage count
                        DefaultServiceOutag = !string.IsNullOrEmpty(ConfigReaderInterruption.ServiceOutages) ? Convert.ToInt32(ConfigReaderInterruption.ServiceOutages) - 1 : 9;

                        // Interval: Timer that automatically checks the service status at regular intervals.
                        AutoCheckServiceTimer.Interval = !string.IsNullOrEmpty(ConfigReaderInterruption.AutoChecking) ? Convert.ToInt32(ConfigReaderInterruption.AutoChecking) : 30000;

                        // Interval: Used to monitor or take action when the service enters a stopped state.
                        TimerWhenServiceStopped.Interval = !string.IsNullOrEmpty(ConfigReaderInterruption.IsStatus) ? Convert.ToInt32(ConfigReaderInterruption.IsStatus) : 600000;

                        // Interval: Timer that automatically restarts services at regular intervals.
                        AutoCheckServiceTimer.Start();

                        // Start the timer to monitor services that are in a stopped state.
                        TimerWhenServiceStopped.Start();

                        // Update button states
                        Start_BTN.Enabled = false;
                        Stop_BTN.Enabled = true;

                        // Focus on the current form
                        this.livelog_panel.Focus();
                        this.livelog_panel.Select();

                        // Log Info
                        Log.Logger!.Info("REBOOTMASTER opened. The 'Start' button has been clicked.");

                        // Disable User Control: Services, Settings
                        DisableTabUserControl();
                    }
                    else
                    {
                        MessageBox.Show(_msg._msgServiceAvailable, _msg._captionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show Warning
                        Log.Logger!.Error($"Unexpected error: {_msg._msgServiceAvailable}"); // Log Error
                    }
                }
                else
                {
                    MessageBox.Show(_msg._msgSMTPConfigurations, _msg._captionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show Warning
                    Log.Logger!.Error($"Unexpected error: {_msg._msgSMTPConfigurations}"); // Log Error
                }
            }
        }

        // Stop Button Click Events
        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            // Confirm stopping service monitoring
            if (MessageBox.Show(_msg._msgStopMonitoringServices, _msg._captionWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Stop the timers
                AutoCheckServiceTimer.Stop();
                TimerWhenServiceStopped.Stop();

                // Update button states
                Start_BTN.Enabled = true;
                Stop_BTN.Enabled = false;

                // Focus on the current form
                this.livelog_panel.Focus();
                this.livelog_panel.Select();

                // Clear service lists
                services!.RemoveAll(x => x.GetType() == typeof(Service));
                tempServices!.RemoveAll(x => x.GetType() == typeof(Service));

                Log.Logger!.Info("REBOOTMASTER opened. The 'Stop' button has been clicked."); // Log Info

                // Enable User Control: Services, Settings
                EnabledTabUserControl();
#if !DEBUG
                // Reload SMTP configurations
                ConfigReaderMail.Reload();

                // Check if all required SMTP configuration values are present
                if (NotificationService.AreSMTPValuesValid())
                {
                    NotificationService.SendMailMessage("REBOOTMASTER has been stopped.", "The REBOOTMASTER application has been terminated.", "REBOOTMASTER Status Update"); // Send email notification
                }
#endif
            }
        }

        // Disable User Control: Services, Settings
        private void DisableTabUserControl()
        {
            // Access the main form and disable the specified user controls
            if (Main.mainObject?.FindForm() is Main main)
            {
                // Invoke on the main form's thread to ensure thread safety
                main.Invoke((MethodInvoker)delegate
                {
                    // Disable the Services and Settings user controls
                    main.DisableButton();
                    Log.Logger!.Info("REBOOTMASTER opened. The 'Services and Settings' tab has been disabled."); // Log Info
                });
            }
        }

        // Enabled User Control: Services, Settings
        private void EnabledTabUserControl()
        {
            // Access the main form and enable the specified user controls
            if (Main.mainObject?.FindForm() is Main main)
            {
                // Invoke on the main form's thread to ensure thread safety
                main.Invoke((MethodInvoker)delegate
                {
                    // Enable the Services and Settings user controls
                    main.EnableButton();
                    Log.Logger!.Info("REBOOTMASTER opened. The 'Services and Settings' tab has been enabled."); // Log Info
                });
            }
        }

        // Timer Tick Event: Auto Check Service Status
        private async void AutoCheckServiceTimer_Tick(object sender, EventArgs e)
        {
            try
            { // Check the status of each service in the list
                if (services!.Count() > 0) // If there are services to monitor
                {
                    for (int i = 0; i < services!.Count(); i++) // Loop through each service
                    {
                        if (!string.IsNullOrEmpty(ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName!.ToString())) // If the service display name is not empty
                        {
                            dateTimeNow = GetDateTime(); // Get the current DateTime
                            services![i].IsStatusSuccess = IsServiceRunning(services[i].ServiceName!); // Update IsStatusSuccess if the service is running
                            if (dateTimeNow.Date > services![i].ServiceDateTime.Date) // If the current date is greater than the service's last recorded date
                            {
                                totalServiceOutageCount = 0; // Reset total service outage count
                                services![i].ServiceOutage = 0; // Reset the service outage count
                                services![i].ServiceDateTime = DateTime.Now; // Update the service's last recorded date to now
                                RemoveServiceFromTemp(services![i]); // Remove the service from the temporary list
                            }
                            if (!services![i].IsStatusSuccess) // If the service is not running
                            {
                                if (!tempServices!.Contains(services![i])) { AddServiceToTemp(services![i]); } // Add the service to the temporary list

                                // Log the service stopped status
                                string newLine = dateTimeNow.AddMilliseconds(DateTime.Now.Millisecond).ToString("yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture) +
                                    $" The service '{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.DisplayName}' is stopped.";

                                // Update live log label
                                log_Lbl.Text = AddLogLine(log_Lbl.Text, newLine);

                                Log.Logger!.Info($"REBOOTMASTER opened. The service '{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.DisplayName}' " +
                                             $"- [.:{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}:.] is stopped."); // Log Info

                                ServiceStart(services![i]); // Attempt to start the service asynchronously
                            }
                            else if (services![i].IsStatusSuccess) // If the service is running
                            {
                                RemoveServiceFromTemp(services![i]); // Remove the service from the temporary list

                                // Log the service stopped status
                                string newLine = dateTimeNow.AddMilliseconds(DateTime.Now.Millisecond).ToString("yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture) +
                                    $" The service '{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.DisplayName}' is running.";

                                // Update live log label
                                log_Lbl.Text = AddLogLine(log_Lbl.Text, newLine);

                                Log.Logger!.Info($"REBOOTMASTER opened. The service '{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.DisplayName}' "+
                                            $"- [.:{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}:.] is running."); // Log Info
                            }
                        }
                        await WaitTask(TimeSpan.FromSeconds(3)); // 3 Seconds
                    }
                }
            }
            catch (Exception ex) // InvalidOperationException
            {
                // Send Exception Details via Email
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
            }
        }

        private async void TimerWhenServiceStopped_Tick(object sender, EventArgs e)
        {
            try
            {
                if (services!.Count() > 0) // If there are services to monitor
                {
                    dateTimeNow = GetDateTime(); // Get the current DateTime
                    for (int i = 0; i < services!.Reverse<Service.ServiceInfo>().Count(); i++) // Loop through each service
                    {
                        if (services![i].ServiceOutage >= DefaultServiceOutag) // If the service outage count exceeds the default threshold
                        {
                            if (ServiceHelper.GetServiceByName(services![i].ServiceName!)!.Status == ServiceControllerStatus.Stopped) // If the service is still stopped
                            {
                                int interval = !string.IsNullOrEmpty(ConfigReaderInterruption.AutoRestarting) ? Convert.ToInt32(ConfigReaderInterruption.AutoRestarting) / 1000 : 120; // Default: 120 Seconds
                                if (services![i].IsEnabled)
                                {
                                    // Send a mail if the service status has stopped.
                                    NotificationService.SendMailMessage($"Service Name: {ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}",
                                        $"The '{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.DisplayName}': " +
                                        $"[.:{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}:.] is currently not running.\r\nUnfortunately, the service is no longer available." +
                                        $"\r\nThe service will start automatically after {interval} seconds." +
                                        $"\r\nPlease check the issue.", $"REBOOTMASTER - [.:{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}:.]");
                                }
                                else
                                {
                                    // Send an email if the service has stopped and is not configured to restart automatically.
                                    NotificationService.SendMailMessage($"Service Name: {ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}",
                                        $"The '{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.DisplayName}': " +
                                        $"[.:{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}:.] is currently not running.\r\nUnfortunately, the service is no longer available." +
                                        $"\r\nPlease check this service, or select it in the 'Services' tab and enable 'Restart automatically'. Alternatively, you can delete the service to stop receiving further emails.", $"REBOOTMASTER - [.:{ServiceHelper.GetServiceByName(services![i].ServiceName!)!.ServiceName}:.]");
                                }

                                SetServiceOutage(services![i], i, new TimeSpan(0, 0, interval)); // Reset Service Outage after x Minutes
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Send Exception Details via Email
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
            }
        }

        // Get current DateTime
        private DateTime GetDateTime()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second); // Return current DateTime
        }

        // Check if service is running
        private static bool IsServiceRunning(string serviceName)
        {
            return ServiceHelper.GetServiceByName(serviceName)!.Status == ServiceControllerStatus.Running ? true : false; // Return true if the service is running, otherwise false
        }

        // Add log line with max lines limit
        private string AddLogLine(string currentText, string newLine, int maxLines = 8, int removeCount = 1)
        {
            // Split the current text into lines
            var lines = currentText
                .Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // Remove oldest lines if the maximum line count is exceeded
            if (lines.Count >= maxLines)
            {
                int remove = Math.Min(removeCount, lines.Count);
                lines.RemoveRange(0, remove);
            }

            // Add the new line to the end
            lines.Add(newLine);

            // Join the lines back into a single string
            return string.Join("\r\n", lines) + "\r\n";
        }

        // Remove service from temporary list
        private void RemoveServiceFromTemp(Service.ServiceInfo service)
        {
            try
            {
                // Remove the service from the temporary list if it is present
                if (tempServices!.Contains(service)) { tempServices!.Remove(service); }
            }
            catch (Exception ex)
            {
                // Send Exception Details via Email
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
            }
        }

        // Add service to temporary list
        private void AddServiceToTemp(Service.ServiceInfo service)
        {
            try
            {
                // Add the service to the temporary list if it is not already present
                if (!tempServices!.Contains(service)) { tempServices!.Add(service); }
            }
            catch (Exception ex)
            {
                // Send Exception Details via Email
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
            }
        }

        // Allows asynchronous waiting without blocking the main thread
        private async Task WaitTask(TimeSpan timeSpan)
        {
            await Task.Delay(timeSpan); // Wait for the specified time span
            inactivesercount_Lbl.Text = tempServices!.Count().ToString(); // Update inactive services count label
            SetLabelAndCenter(inactivesercount_Lbl, inactiveser_panel, tempServices!.Count().ToString()); // Update and center the label
        }

        // Handle Service Start
        private async void ServiceStart(Service.ServiceInfo service)
        {
            await WaitTask(TimeSpan.FromSeconds(5)); // 5 Seconds
            try
            {
                if (!string.IsNullOrEmpty(ServiceHelper.GetServiceByName(service.ServiceName!)!.ServiceName!.ToString())) // If the service display name is not empty
                {
                    // Check if the service outage count is within the allowed limit and the current date is less than or equal to the service's last recorded date
                    if (service.ServiceOutage <= DefaultServiceOutag && GetDateTime().Date <= service.ServiceDateTime!.Date) { HandleService(ServiceHelper.GetServiceByName(service.ServiceName!)!, service); }
                }
            }
            catch (Exception ex)
            {
                // Send Exception Details via Email
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
            }
        }

        // Handle Service
        private async void HandleService(ServiceController serviceController, Service.ServiceInfo service)
        {
            try
            {
                // Start the service if it is stopped
                if (ServiceHelper.GetServiceByName(serviceController.ServiceName)!.Status == ServiceControllerStatus.Stopped) // If the service is stopped
                {
                    service.ServiceOutage += 1; // Increment the service outage count

                    totalServiceOutageCount += 1; // Increment total service outage count
                    unexpectedfailurescount_Lbl.Text = totalServiceOutageCount.ToString(); // Update unexpected failures count label
                    SetLabelAndCenter(unexpectedfailurescount_Lbl, unexpectedfailures_panel, unexpectedfailurescount_Lbl.Text); // Center the label

                    // Check whether the service is enabled to start automatically.
                    if (service.IsEnabled)
                    {
                        ServiceHelper.GetServiceByName(serviceController.ServiceName)!.Start(); // Start the service
                        ServiceHelper.GetServiceByName(serviceController.ServiceName)!.WaitForStatus(ServiceControllerStatus.Running, timeout); // 30 Seconds
                        Log.Logger!.Info($"REBOOTMASTER opened. The service '{serviceController.DisplayName}' - [.:{serviceController.ServiceName}:.] is in the starting state."); // Log Info

                        // Log the service stopped status
                        string newLine = dateTimeNow.AddMilliseconds(DateTime.Now.Millisecond).ToString("yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture) +
                            $" The service '{serviceController.DisplayName}' is in the starting state.";

                        // Update live log label
                        log_Lbl.Text = AddLogLine(log_Lbl.Text, newLine);

                        await WaitTask(TimeSpan.FromSeconds(20)); // 20 Seconds
                    }
                }
            }
            catch (Exception ex)
            {
                // Send Exception Details via Email
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
            }
        }

        // Set Service Outage >> Restart: ServiceOutage = 0 - Minutes [3, 5, 7] => 180 Seconds, 300 Seconds, 420 Seconds
        private async void SetServiceOutage(Service.ServiceInfo service, int index, TimeSpan timer)
        {
            await WaitTask(timer); // Wait for the specified timer duration
            // Reset the service outage count if the service is still in the list
            if (services != null && services.Reverse<Service.ServiceInfo>().Contains(service))
            {
                services[index].ServiceOutage = 0; // Reset the service outage count
                services[index].IsStatusSuccess = IsServiceRunning(services![index].ServiceName!); // Update IsStatusSuccess if the service is running
                if (service.IsStatusSuccess) { RemoveServiceFromTemp(services[index]); } // Remove the service from the temporary list
            }
        }
    }
}