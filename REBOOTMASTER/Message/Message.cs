namespace REBOOTMASTER_Free.Message
{
    internal class Message
    {
        // Message
        public const string _msg = "Do you want to close the desired application?";
        public const string _caption = "Form Closing";
        public const string _msgCloseApp = "It is currently not possible to close this application.";
        public const string _captionUpdate = "Update";
        public const string _msgUpdate = "Would you like to update the desired changes?";
        public const string _captionError = "Error";
        public const string _captionWarning = "Warning";
        public const string _captionInformation = "Information";
        public const string _msgSMTPHost = "Please enter your 'SMTP Host'.";
        public const string _msgSMTPPort = "Please enter your 'SMTP Port'.";
        public const string _msgSMTPPortInterger = " is not a valid integer.";
        public const string _msgSMTPUser = "Enter the correct email for 'SMTP User'.";
        public const string _msgSMTPPassword = "Please enter your 'SMTP Password'.";
        public const string _msgSMTPRecipientsEmail = "Enter the correct email for 'Recipient's email'.";
        public const string _msgSuccessful = "The desired data has been successfully saved.";
        public const string _msgErrorAppIsAlreadyRunning = "The application is already running.";
        public const string _msgSuccessfulServiceRunning = "The service was running successfully.";
        public const string _msgSuccessfulServiceStopped = "The service was successfully stopped.";
        public const string _msgSuccessfulServiceRestarted = "The service was restarted successfully.";
        public const string _msgSuccessfulServiceDeleted = "The service was successfully deleted.";
        public const string _msgServiceAlreadyExists = "The service already exists in the Config.";
        public const string _msgSMTPConfigurations = "Please enter the SMTP configurations correctly in the Settings tab.";
        public const string _msgServiceIsStart = "The service must be started.";
        public const string _msgServiceIsUpdate = "Do you want to add or update the desired service in the Config?";
        public const string _msgServiceIsDelete = "Do you want to delete the desired service in the Config?";
        public const string _msgServiceAvailable = "You must select and save the service(s) in the Services tab, allowing REBOOTMASTER to monitor them.";
        public const string _msgServiceSuccessfullyAdded = "You have successfully saved this service in the Config, allowing REBOOTMASTER to monitor it.";
        public const string _msgStartMonitorServices = "Are you sure you want to monitor the selected services?";
        public const string _msgStopMonitoringServices = "Are you sure you want to stop monitoring the selected services?";
        public const string _msgAddServiceCheckboxToolTip = "The desired service in the list for REBOOTMASTER to monitor it in the background, automatically restarting.";
        public const string _msgHostToolTip = "The SMTP server address (e.g., `smtp.example.com`)";
        public const string _msgPortToolTip = "The port used for SMTP (typically `587` or `465`)";
        public const string _msgUserToolTip = "The username used to authenticate with the SMTP server";
        public const string _msgPasswordToolTip = "The password for the SMTP user";
        public const string _msgRecipientEmailToolTip = "The email address that will receive the notifications";
        public const string _msgAutoCheckingToolTip = @"The selected services are checked every {0}. When a service is stopped, it will automatically started.";
        public const string _msgAutorestartingToolTip = @"After {0}, the service will restart if there are {1} and several unsuccessful start attempts, and it will send an email.";
        public const string _msgIsStatusToolTip = @"Every {0}, if the Service Status is 'Stopped' and the service cannot be restarted after {1}, an email is sent to you stating that the service will be restarted after a {2}.";
        public const string _msgServiceOutagesToolTip = @"Counts and monitors detected service disruptions.";
        public const string _msgErrorAppSettings = "AppSettings section not found in config file.";
        public const string _msgSystemServicesToolTip = "System services in `C:\\Windows`, `C:\\Program Files`, and `C:\\ProgramData` are hidden by default.";
        public const string _msgSelectService = "Please select a service to add or update.";
        public const string _msgTheServiceIsAdded = "This service has been added to the configuration";
        public const string _msgTheServiceIsNotAdded = "This service has not yet been added to the configuration.";

        // Information
        internal void ShowMessageInformation(string _msg) => MessageBox.Show(_msg, _captionInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}