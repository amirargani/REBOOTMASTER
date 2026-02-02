using REBOOTMASTER.Config;
using REBOOTMASTER.Utility;
using System.Diagnostics;
using _msg = REBOOTMASTER.Message;
using Log = REBOOTMASTER.Utility.Log;

namespace REBOOTMASTER
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check if the application is already running
            if (IsAlreadyRunning())
            {
                MessageBox.Show(_msg.Message._msgErrorAppIsAlreadyRunning, _msg.Message._captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                Log.Logger!.Info("REBOOTMASTER started. Logger initialized.");
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Main());
            }
            catch (Exception ex)
            {
                // Log the error
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + ex.StackTrace}");
#if !DEBUG
                // Reload SMTP configurations
                ConfigReaderMail.Reload();

                // Check if all required SMTP configuration values are present
                if (NotificationService.AreSMTPValuesValid())
                {
                    // Send an email with the error details only if not in Debug mode
                    NotificationService.SendMailMessage(
                    "REBOOTMASTER Error",                        // name (subject of the email)
                    $"Unexpected error occurred: {ex.Message}{Environment.NewLine}{ex.StackTrace}", // logMessage (details of the error)
                    "REBOOTMASTER Error Notification"            // subject (subject line of the email)
                    );
                }
#endif

                // Optionally, rethrow or handle the exception as needed
                throw new InvalidOperationException("An unexpected error occurred.", ex);
            }
        }

        // Already Running
        static bool IsAlreadyRunning()
        {
            // Get the current process
            Process currentProcess = Process.GetCurrentProcess();

            // Check if there are any other processes with the same name
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            return processes.Length > 1;
        }
    }
}