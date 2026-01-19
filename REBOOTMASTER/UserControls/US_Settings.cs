using REBOOTMASTER.Config;
using REBOOTMASTER.Utility;
using System.Text.RegularExpressions;
using _msg = REBOOTMASTER.Message;
using Log = REBOOTMASTER.Utility.Log;

namespace REBOOTMASTER.UserControls
{
    public partial class US_Settings : UserControl
    {
        // Constructor
        public US_Settings()
        {
            InitializeComponent();

            // Interruption
            autoChecking_CBox.Text = !string.IsNullOrEmpty(ConfigReaderInterruption.AutoChecking) ? (Convert.ToInt32(ConfigReaderInterruption.AutoChecking) / 1000).ToString() + " seconds" : "30 seconds";
            autoRestarting_CBox.Text = !string.IsNullOrEmpty(ConfigReaderInterruption.AutoRestarting) ? (Convert.ToInt32(ConfigReaderInterruption.AutoRestarting) / 1000).ToString() + " seconds" : "120 seconds";
            isStatus_CBox.Text = !string.IsNullOrEmpty(ConfigReaderInterruption.IsStatus) ? (Convert.ToInt32(ConfigReaderInterruption.IsStatus) / 60000).ToString() + " minutes" : "10 minutes";
            serviceOutages_CBox.Text = !string.IsNullOrEmpty(ConfigReaderInterruption.IsStatus) ? "10 service outages" : "10 service outages";

            // ToolTips
            ToolTipWindows.SetToolTip(autoChecking_CBox, string.Format(_msg.Message._msgAutoCheckingToolTip, autoChecking_CBox.Text));
            ToolTipWindows.SetToolTip(autoRestarting_CBox, string.Format(_msg.Message._msgAutorestartingToolTip, autoRestarting_CBox.Text, serviceOutages_CBox.Text));
            ToolTipWindows.SetToolTip(isStatus_CBox, string.Format(_msg.Message._msgIsStatusToolTip, isStatus_CBox.Text, serviceOutages_CBox.Text, autoRestarting_CBox.Text));
            ToolTipWindows.SetToolTip(serviceOutages_CBox, string.Format(_msg.Message._msgServiceOutagesToolTip));

            // SMTP Configuration
            ToolTipWindows.SetToolTip(host_TBox, _msg.Message._msgHostToolTip);
            ToolTipWindows.SetToolTip(port_TBox, _msg.Message._msgPortToolTip);
            ToolTipWindows.SetToolTip(user_TBox, _msg.Message._msgUserToolTip);
            ToolTipWindows.SetToolTip(pass_TBox, _msg.Message._msgPasswordToolTip);
            ToolTipWindows.SetToolTip(email_TBox, _msg.Message._msgRecipientEmailToolTip);

            // Loads the SMTP configuration values ​​from the ConfigReaderMail class,
            // decrypts them using Security.GetString and writes them to the text boxes in the user interface.
            host_TBox.Text = Security.GetString(ConfigReaderMail.SmtpHost); // SMTP server address (host)
            port_TBox.Text = Security.GetString(ConfigReaderMail.SmtpPort); // SMTP port number
            user_TBox.Text = Security.GetString(ConfigReaderMail.SmtpUser); // Username for SMTP authentication
            pass_TBox.Text = Security.GetString(ConfigReaderMail.SmtpPassword); // Password for SMTP authentication
            email_TBox.Text = Security.GetString(ConfigReaderMail.Recipient); // Recipient address for error messages
        }

        // SelectedIndexChanged: autoChecking_CBox
        private void autoChecking_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Format the tooltip text with the selected value and set the tooltip
            if (autoChecking_CBox.SelectedItem != null) { ToolTipWindows.SetToolTip(autoChecking_CBox, string.Format(_msg.Message._msgAutoCheckingToolTip, autoChecking_CBox.SelectedItem!.ToString())); }
        }

        // SelectedIndexChanged: autoRestarting_CBox
        private void autoRestarting_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIsStatus_CBoxToolTip();
            UpdateAutoRestartingToolTip();
        }

        // SelectedIndexChanged: isStatus_CBox
        private void isStatus_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIsStatus_CBoxToolTip();
            UpdateAutoRestartingToolTip();
        }

        // SelectedIndexChanged: serviceOutages_CBox
        private void serviceOutages_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateIsStatus_CBoxToolTip();
            UpdateAutoRestartingToolTip();
        }

        // Update: autoRestarting_CBox
        private void UpdateAutoRestartingToolTip()
        {
            // Format the tooltip text with the selected value and set the tooltip
            if (autoRestarting_CBox.SelectedItem != null && serviceOutages_CBox.SelectedItem != null) { ToolTipWindows.SetToolTip(autoRestarting_CBox, string.Format(_msg.Message._msgAutorestartingToolTip, autoRestarting_CBox.Text, serviceOutages_CBox.Text)); }
        }

        // Update: isStatus_CBox
        private void UpdateIsStatus_CBoxToolTip()
        {
            // Format the tooltip text with the selected value and set the tooltip
            if (isStatus_CBox.SelectedItem != null && autoRestarting_CBox.SelectedItem != null) { ToolTipWindows.SetToolTip(isStatus_CBox, string.Format(_msg.Message._msgIsStatusToolTip, isStatus_CBox.Text, serviceOutages_CBox.Text, autoRestarting_CBox.Text)); }
        }

        // Update Button
        private void update_BTN_Click(object sender, EventArgs e)
        {
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
                        if (IsUpdate())
                        {
                            // Update Main Form State
                            main.Enabled = false;
                            main.isFinish = false;
                            main.isSettings = true;
                            main.SuspendLayout();
                            _timerProgressBar.Start();
                            main.ResumeLayout();
                        }
                    }
                });
            }
        }

        // Is Update
        private bool IsUpdate()
        {
            // Check if smtp host field are empty
            if (string.IsNullOrEmpty(host_TBox.Text))
            {
                Log.Logger!.Error($"Unexpected error: {host_TBox.Text} {_msg.Message._msgSMTPHost}");
                ShowMessageError(_msg.Message._msgSMTPHost);
                return false;
            }
            // Check if smtp port field are empty
            if (string.IsNullOrEmpty(port_TBox.Text))
            {
                Log.Logger!.Error($"Unexpected error: {port_TBox.Text} {_msg.Message._msgSMTPPort}");
                ShowMessageError(_msg.Message._msgSMTPPort);
                return false;
            }
            // Check if the smtp port is a valid number
            if (!int.TryParse(port_TBox.Text, out int result) && !string.IsNullOrEmpty(port_TBox.Text))
            {
                Log.Logger!.Error($"Unexpected error: {port_TBox.Text} {_msg.Message._msgSMTPPortInterger}");
                ShowMessageError($"{port_TBox.Text} {_msg.Message._msgSMTPPortInterger}");
                return false;
            }
            // Check if email addresses are valid
            if (!IsEmailValid(user_TBox.Text))
            {
                Log.Logger!.Error($"Unexpected error: {user_TBox.Text} {_msg.Message._msgSMTPUser}");
                ShowMessageError(_msg.Message._msgSMTPUser);
                return false;
            }
            // Check if pass field are empty
            if (string.IsNullOrEmpty(pass_TBox.Text))
            {
                Log.Logger!.Error($"Unexpected error: {pass_TBox.Text} {_msg.Message._msgSMTPPassword}");
                ShowMessageError(_msg.Message._msgSMTPPassword);
                return false;
            }
            // Check if email addresses are valid
            if (!IsEmailValid(email_TBox.Text))
            {
                Log.Logger!.Error($"Unexpected error: {email_TBox.Text} {_msg.Message._msgSMTPRecipientsEmail}");
                ShowMessageError(_msg.Message._msgSMTPRecipientsEmail);
                return false;
            }
            // Show confirmation dialog
            if (MessageBox.Show(_msg.Message._msgUpdate, _msg.Message._captionUpdate, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string isStatusMinsToSeconds = (Convert.ToInt32(isStatus_CBox.Text.Replace(" minutes", "").Trim()) * 60000).ToString();
                // Update configuration
                XMLUpdate.UpdateProperty("SmtpHost", Security.CreateEncryptedDataBase64(host_TBox.Text), ConfigReaderMail.configMail!, ConfigReaderMail.FileName);
                XMLUpdate.UpdateProperty("SmtpPort", Security.CreateEncryptedDataBase64(port_TBox.Text), ConfigReaderMail.configMail!, ConfigReaderMail.FileName);
                XMLUpdate.UpdateProperty("SmtpUser", Security.CreateEncryptedDataBase64(user_TBox.Text), ConfigReaderMail.configMail!, ConfigReaderMail.FileName);
                XMLUpdate.UpdateProperty("SmtpPassword", Security.CreateEncryptedDataBase64(pass_TBox.Text), ConfigReaderMail.configMail!, ConfigReaderMail.FileName);
                XMLUpdate.UpdateProperty("Recipient", Security.CreateEncryptedDataBase64(email_TBox.Text), ConfigReaderMail.configMail!, ConfigReaderMail.FileName);
                XMLUpdate.UpdateProperty("AutoChecking", autoChecking_CBox.Text.Replace(" seconds", "").Trim() + "000", ConfigReaderInterruption.configInterruption!, ConfigReaderInterruption.FileName);
                XMLUpdate.UpdateProperty("AutoRestarting", autoRestarting_CBox.Text.Replace(" seconds", "").Trim() + "000", ConfigReaderInterruption.configInterruption!, ConfigReaderInterruption.FileName);
                XMLUpdate.UpdateProperty("IsStatus", isStatusMinsToSeconds, ConfigReaderInterruption.configInterruption!, ConfigReaderInterruption.FileName);
                XMLUpdate.UpdateProperty("ServiceOutages", serviceOutages_CBox.Text.Replace(" service outages", "").Trim() , ConfigReaderInterruption.configInterruption!, ConfigReaderInterruption.FileName);
                return true;
            }
            // Default return value if no other return statement is hit
            return false;
        }

        // Print Error
        private void ShowMessageError(string _msgText) => MessageBox.Show(_msgText, _msg.Message._captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);

        // Email Validation
        private bool IsEmailValid(string email)
        {
            if (new Regex(@"^(?:[\w\d\.-_])+@(?=.{4,64}$)(?:[\w\d]+[-]?[\w\d]+\.|[\w\d]\.)+(?:\w{2,})$").IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}