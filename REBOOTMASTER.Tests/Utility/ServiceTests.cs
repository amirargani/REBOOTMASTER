using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class ServiceTests
    {
        [Fact]
        public void ServiceInfo_Properties_WorkCorrectly()
        {
            // Arrange
            string name = "TestService";
            bool enabled = true;
            DateTime now = DateTime.Now;
            int outage = 5;
            bool success = true;

            // Act
            var info = new Service.ServiceInfo(name, enabled, now, outage, success);

            // Assert
            Assert.Equal(name, info.DisplayName);
            Assert.Equal(enabled, info.IsEnabled);
            Assert.Equal(now, info.ServiceDateTime);
            Assert.Equal(outage, info.ServiceOutage);
            Assert.Equal(success, info.IsStatusSuccess);
        }

        [Fact]
        public void ServiceInfo_Setters_WorkCorrectly()
        {
            // Arrange
            var info = new Service.ServiceInfo("OldName", false, DateTime.MinValue, 0, false);

            // Act
            info.DisplayName = "NewName";
            info.IsEnabled = true;
            info.ServiceDateTime = DateTime.MaxValue;
            info.ServiceOutage = 10;
            info.IsStatusSuccess = true;

            // Assert
            Assert.Equal("NewName", info.DisplayName);
            Assert.True(info.IsEnabled);
            Assert.Equal(DateTime.MaxValue, info.ServiceDateTime);
            Assert.Equal(10, info.ServiceOutage);
            Assert.True(info.IsStatusSuccess);
        }
    }
}