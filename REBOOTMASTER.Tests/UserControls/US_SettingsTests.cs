using REBOOTMASTER.UserControls;

namespace REBOOTMASTER.Tests.UserControls
{
    public class US_SettingsTests
    {
        [Fact]
        public void US_Settings_Initialization_Works()
        {
            // This test might interact with Config files, so it's a bit of an integration test
            // Act
            var settings = new US_Settings();

            // Assert
            Assert.NotNull(settings);
            var hostBox = settings.Controls.Find("host_TBox", true).FirstOrDefault() as TextBox;
            Assert.NotNull(hostBox);
        }

        [Fact]
        public void US_Settings_ComboBoxes_HaveInitialValues()
        {
            // Act
            var settings = new US_Settings();

            // Assert
            var autoChecking = settings.Controls.Find("autoChecking_CBox", true).FirstOrDefault() as ComboBox;
            Assert.NotNull(autoChecking);
            Assert.False(string.IsNullOrEmpty(autoChecking.Text));
        }

        [Fact]
        public void US_Settings_InitialUIState_IsCorrect()
        {
            // Act
            var settings = new US_Settings();

            // Assert
            var updateBtn = settings.Controls.Find("Update_BTN", true).FirstOrDefault() as Button;
            var sendEmailTestBtn = settings.Controls.Find("SendEmailTest_BTN", true).FirstOrDefault() as Button;

            Assert.NotNull(updateBtn);
            Assert.NotNull(sendEmailTestBtn);
            Assert.True(updateBtn.Enabled);
            Assert.True(sendEmailTestBtn.Enabled);
        }

        [Fact]
        public void US_Settings_IsEmailValid_ValidatesCorrectly()
        {
            // Arrange
            var settings = new US_Settings();
            var method = typeof(US_Settings).GetMethod("IsEmailValid", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act & Assert - Valid emails
            Assert.True((bool)method.Invoke(settings, new object[] { "test@example.com" })!);
            Assert.True((bool)method.Invoke(settings, new object[] { "user.name@domain.co.uk" })!);
            Assert.True((bool)method.Invoke(settings, new object[] { "test_123@test-domain.com" })!);

            // Act & Assert - Invalid emails
            Assert.False((bool)method.Invoke(settings, new object[] { "invalid.email" })!);
            Assert.False((bool)method.Invoke(settings, new object[] { "@example.com" })!);
            Assert.False((bool)method.Invoke(settings, new object[] { "test@" })!);
            Assert.False((bool)method.Invoke(settings, new object[] { "" })!);
        }

        [Fact]
        public void US_Settings_UpdateAutoRestartingToolTip_DoesNotThrow()
        {
            // Arrange
            var settings = new US_Settings();
            var method = typeof(US_Settings).GetMethod("UpdateAutoRestartingToolTip", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act & Assert - Should not throw
            var exception = Record.Exception(() => method.Invoke(settings, null));
            Assert.Null(exception);
        }

        [Fact]
        public void US_Settings_UpdateIsStatus_CBoxToolTip_DoesNotThrow()
        {
            // Arrange
            var settings = new US_Settings();
            var method = typeof(US_Settings).GetMethod("UpdateIsStatus_CBoxToolTip", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act & Assert - Should not throw
            var exception = Record.Exception(() => method.Invoke(settings, null));
            Assert.Null(exception);
        }
    }
}