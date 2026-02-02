using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class ServiceHelperTests
    {
        [Fact]
        public void ServiceHelper_GetServiceByNameOrDisplayName_ReturnsNullForUnknown()
        {
            // Act
            var service = ServiceHelper.GetServiceByNameOrDisplayName("NonExistentServiceName12345");

            // Assert
            Assert.Null(service);
        }
    }
}