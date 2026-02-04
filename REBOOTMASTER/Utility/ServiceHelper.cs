using System.ServiceProcess;

namespace REBOOTMASTER.Utility
{
    public class ServiceHelper
    {
        // Gets a ServiceController by either its service name or service name.
        public static ServiceController? GetServiceByName(string service)
        {
            try
            {
                // Get all services
                ServiceController[] services = ServiceController.GetServices();
                // Search for service based on ServiceName
                return services.FirstOrDefault(s =>
                    s.DisplayName.Equals(service, StringComparison.OrdinalIgnoreCase) ||
                    s.ServiceName.Equals(service, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}"); // Log Error
                return null;
            }
        }

        // Checks if a service exists by either its service name or display name.
        public static bool IsServiceExists(string service)
        {
            try
            {
                // Get all services
                ServiceController[] services = ServiceController.GetServices();

                // Check if any service matches the given name or display name
                return services.Any(s =>
                    s.ServiceName.Equals(service, StringComparison.OrdinalIgnoreCase) ||
                    s.DisplayName.Equals(service, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                Log.Logger!.Error($"Unexpected error: {ex.Message}{Environment.NewLine}{Log.CleanStackTrace(ex)}"); // Log Error
                return false;
            }
        }

    }
}