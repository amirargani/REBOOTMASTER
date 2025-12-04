using System.Diagnostics;
using Log = REBOOTMASTER_Free.Utility.Log;
using _msg = REBOOTMASTER_Free.Message;

namespace REBOOTMASTER_Free
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
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + ex.StackTrace}");
                throw new InvalidOperationException();
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