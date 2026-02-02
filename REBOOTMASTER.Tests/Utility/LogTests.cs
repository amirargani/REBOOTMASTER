using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class LogTests
    {
        [Fact]
        public void Log_Logger_IsInitialized()
        {
            // Act
            var logger = Log.Logger;

            // Assert
            Assert.NotNull(logger);
        }
    }
}