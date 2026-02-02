using System.ServiceProcess;

namespace REBOOTMASTER.Utility
{
    public class ServiceHelper
    {
        public static ServiceController? GetServiceByNameOrDisplayName(string service)
        {
            try
            {
                // Get all services
                ServiceController[] services = ServiceController.GetServices();
                // Search for service based on DisplayName or ServiceName
                return services.FirstOrDefault(s =>
                    s.DisplayName.Equals(service, StringComparison.OrdinalIgnoreCase) ||
                    s.ServiceName.Equals(service, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + ex.StackTrace}");
                return null;
            }
        }
    }
}
