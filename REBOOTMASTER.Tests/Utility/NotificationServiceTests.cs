using REBOOTMASTER.Config;
using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class NotificationServiceTests
    {
        [Fact]
        public void NotificationService_AreSMTPValuesValid_Works()
        {
            // This test depends on ConfigReaderMail state. 
            // We can only test the logic if we mock or set the config file.
            // For now, we test it returns false if values are empty.
            
            string originalFile = ConfigReaderMail.FileName;
            ConfigReaderMail.FileName = "NonExistent.xml";
            
            try 
            {
                // Act
                bool result = NotificationService.AreSMTPValuesValid();
                
                // Assert
                Assert.False(result);
            }
            finally
            {
                ConfigReaderMail.FileName = originalFile;
            }
        }
    }
}