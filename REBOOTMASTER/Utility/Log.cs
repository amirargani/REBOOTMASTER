using log4net;
using log4net.Config;

namespace REBOOTMASTER.Utility
{
    public class Log
    {
        // Logger instance
        public static ILog? Logger { get; private set; }

        // Static constructor to configure log4net
        static Log()
        {
            XmlConfigurator.Configure(new FileInfo("Log.dll"));
            Logger = LogManager.GetLogger(typeof(Program));
        }

        // Method to clean stack trace from file paths
        public static string CleanStackTrace(Exception ex)
        {
            // Process each line of the exception's string representation
            return string.Join(
                Environment.NewLine,
                ex.ToString()
                    .Split('\n') // Split into lines
                    .Select(line => RemoveFilePath(line)) // Remove file paths
                    .Select(line => line.Trim()) // Trim whitespace
            );
        }

        // Helper method to remove file paths from a line
        private static string RemoveFilePath(string line)
        {
            int index = line.IndexOf(" in "); // Look for " in " which indicates file path
            if (index >= 0) // If found
            {
                // Check for ":line" to preserve line number information
                int lineIndex = line.IndexOf(":line");
                if (lineIndex > index) // If ":line" is present after " in "
                {
                    string lineNumber = line.Substring(lineIndex); // Extract line number part
                    return line.Substring(0, index) + " " + lineNumber; // Return line without file path but with line number
                }

                // Return line without file path
                return line.Substring(0, index);
            }

            // If " in " not found, return the line as is
            return line;
        }
    }
}