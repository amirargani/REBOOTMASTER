using REBOOTMASTER.Utility;
using System.ServiceProcess;

namespace REBOOTMASTER.Tests.Utility
{
    public class ServiceHelperTests
    {
        [Fact]
        public void ServiceHelper_GetServiceByName_ReturnsNullForUnknown()
        {
            // Act
            var service = ServiceHelper.GetServiceByName("NonExistentServiceName12345");

            // Assert
            Assert.Null(service);
        }

        [Fact]
        public void IsServiceExists_ReturnsFalseForUnknownService()
        {
            // Act
            bool exists = ServiceHelper.IsServiceExists("NonExistentServiceName12345");

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void IsServiceExists_ReturnsTrueForExistingService_ByServiceName()
        {
            // Arrange - get an existing service from the system
            ServiceController[] services = ServiceController.GetServices();
            Assert.NotEmpty(services); // Ensure environment has services

            var svc = services.First();

            // Act & Assert - check by ServiceName
            Assert.True(ServiceHelper.IsServiceExists(svc.ServiceName));

            // Act & Assert - check by DisplayName
            Assert.True(ServiceHelper.IsServiceExists(svc.DisplayName));
        }
    }
}