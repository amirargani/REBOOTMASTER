using System.Xml;
using REBOOTMASTER.Config;

namespace REBOOTMASTER.Tests.Config
{
    public class ConfigTests
    {
        [Fact]
        public void ConfigReaderService_FileName_CanBeChanged()
        {
            // Arrange
            string original = ConfigReaderService.FileName;
            string testFile = "TestConfig.dll";

            try
            {
                // Act
                ConfigReaderService.FileName = testFile;

                // Assert
                Assert.Equal(testFile, ConfigReaderService.FileName);
                Assert.Null(ConfigReaderService.configService);
            }
            finally
            {
                // Cleanup
                ConfigReaderService.FileName = original;
            }
        }

        [Fact]
        public void XMLUpdate_UpdateProperty_CreatesAndUpdatesSettings()
        {
            // Arrange
            string tempFileName = "TestTempConfig.xml";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tempFileName);
            
            // Create a minimal config file
            string initialXml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                <configuration>
                    <appSettings>
                        <add key=""ExistingKey"" value=""OldValue"" />
                    </appSettings>
                </configuration>";
            File.WriteAllText(fullPath, initialXml);

            try
            {
                // Act: Update existing
                XMLUpdate.UpdateProperty("ExistingKey", "NewValue", null!, tempFileName, false);

                // Act: Add new
                XMLUpdate.UpdateProperty("NewKey", "AddedValue", null!, tempFileName, false);

                // Act: Delete
                XMLUpdate.UpdateProperty("ExistingKey", "", null!, tempFileName, true);

                // Assert
                XmlDocument doc = new XmlDocument();
                doc.Load(fullPath);

                var existingNode = doc.SelectSingleNode("//add[@key='ExistingKey']");
                var newNode = doc.SelectSingleNode("//add[@key='NewKey']");

                Assert.Null(existingNode);
                Assert.NotNull(newNode);
                Assert.Equal("AddedValue", newNode.Attributes!["value"]!.Value);
            }
            finally
            {
                // Cleanup
                if (File.Exists(fullPath)) File.Delete(fullPath);
            }
        }
        [Fact]
        public void ConfigReaderInterruption_FileName_CanBeChanged()
        {
            // Arrange
            string original = ConfigReaderInterruption.FileName;
            string testFile = "TestInterruption.dll";

            try
            {
                // Act
                ConfigReaderInterruption.FileName = testFile;

                // Assert
                Assert.Equal(testFile, ConfigReaderInterruption.FileName);
                Assert.Null(ConfigReaderInterruption.configInterruption);
            }
            finally
            {
                // Cleanup
                ConfigReaderInterruption.FileName = original;
            }
        }

        [Fact]
        public void ConfigReaderMail_FileName_CanBeChanged()
        {
            // Arrange
            string original = ConfigReaderMail.FileName;
            string testFile = "TestMail.dll";

            try
            {
                // Act
                ConfigReaderMail.FileName = testFile;

                // Assert
                Assert.Equal(testFile, ConfigReaderMail.FileName);
                Assert.Null(ConfigReaderMail.configMail);
            }
            finally
            {
                // Cleanup
                ConfigReaderMail.FileName = original;
            }
        }

        [Fact]
        public void ConfigReaders_ReadValuesFromTempFiles()
        {
            // Arrange
            string interruptionFile = "TempInterruption.xml";
            string mailFile = "TempMail.xml";
            string fullInterruptionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, interruptionFile);
            string fullMailPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, mailFile);

            string interruptionXml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                <configuration>
                    <appSettings>
                        <add key=""AutoChecking"" value=""60"" />
                    </appSettings>
                </configuration>";
            
            string mailXml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                <configuration>
                    <appSettings>
                        <add key=""Recipient"" value=""test@example.com"" />
                    </appSettings>
                </configuration>";

            File.WriteAllText(fullInterruptionPath, interruptionXml);
            File.WriteAllText(fullMailPath, mailXml);

            string origInterruption = ConfigReaderInterruption.FileName;
            string origMail = ConfigReaderMail.FileName;

            try
            {
                ConfigReaderInterruption.FileName = interruptionFile;
                ConfigReaderMail.FileName = mailFile;

                // Act
                string autoChecking = ConfigReaderInterruption.AutoChecking;
                string recipient = ConfigReaderMail.Recipient;

                // Assert
                Assert.Equal("60", autoChecking);
                Assert.Equal("test@example.com", recipient);
            }
            finally
            {
                // Cleanup
                ConfigReaderInterruption.FileName = origInterruption;
                ConfigReaderMail.FileName = origMail;
                if (File.Exists(fullInterruptionPath)) File.Delete(fullInterruptionPath);
                if (File.Exists(fullMailPath)) File.Delete(fullMailPath);
            }
        }
    }
}