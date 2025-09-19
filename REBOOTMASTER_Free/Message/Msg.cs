namespace REBOOTMASTER_Free.Message
{
    internal class Msg
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
        public const string _msgSMTPConfigurations = "Please enter the SMTP configurations correctly in the Settings tab.";
        public const string _msgServiceIsStart = "The service must be started.";
        public const string _msgServiceIsUpdate = "Do you want to update the desired service?";
        public const string _msgServiceIsDelete = "Do you want to delete the desired service?";
        public const string _msgServiceAvailable = "You have selected and saved the service(s) in the Services tab, allowing the REBOOTMASTER to monitor them.";
        public const string _msgStartMonitorServices = "Are you sure you want to monitor the selected services?";
        public const string _msgStopMonitoringServices = "Are you sure you want to stop monitoring the selected services?";
        public const string _msgAddServiceCheckboxToolTip = "Add the desired service to the list to monitor the REBOOTMASTER in the background.";
        public const string _msgErrorAppSettings = "AppSettings section not found in config file.";

        // Information
        internal void ShowMessageInformation(string _msg) => MessageBox.Show(_msg, _captionInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
}
