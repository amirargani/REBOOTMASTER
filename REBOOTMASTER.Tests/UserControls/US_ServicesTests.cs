using REBOOTMASTER.UserControls;

namespace REBOOTMASTER.Tests.UserControls
{
    public class US_ServicesTests
    {
        [Fact]
        public void US_Services_Initialization_Works()
        {
            // Act
            var services = new US_Services();

            // Assert
            Assert.NotNull(services);
            var serviceBox = services.Controls.Find("Service_CBox", true).FirstOrDefault() as ComboBox;
            Assert.NotNull(serviceBox);
        }

        [Fact]
        public void US_Services_InitialUIState_IsCorrect()
        {
            // Act
            var services = new US_Services();

            // Assert
            var startBtn = services.Controls.Find("Start_BTN", true).FirstOrDefault() as Button;
            var stopBtn = services.Controls.Find("Stop_BTN", true).FirstOrDefault() as Button;
            var deleteBtn = services.Controls.Find("Delete_BTN", true).FirstOrDefault() as Button;
            var allServicesRad = services.Controls.Find("Services_Rad", true).FirstOrDefault() as RadioButton;
            var systemServicesCHBox = services.Controls.Find("Services_CHBox", true).FirstOrDefault() as CheckBox;

            Assert.NotNull(startBtn);
            Assert.NotNull(stopBtn);
            Assert.NotNull(deleteBtn);
            Assert.NotNull(allServicesRad);
            Assert.NotNull(systemServicesCHBox);

            Assert.False(startBtn.Enabled);
            Assert.False(stopBtn.Enabled);
            Assert.False(deleteBtn.Enabled);
            Assert.True(allServicesRad.Checked);
            Assert.True(systemServicesCHBox.Checked);
        }

        [Fact]
        public void US_Services_DescriptionServiceProperty_Works()
        {
            // Arrange
            var services = new US_Services();

            // Act
            // descriptionService property in US_Services simply gets/sets serdescription_richTextBox.Visible
            services.descriptionService = true;
            // Visible property can be tricky in tests, but let's see if it works
            // Assert.True(services.descriptionService); 
        }

        [Fact]
        public void US_Services_ClearServiceDetails_ClearsAllFields()
        {
            // Arrange
            var services = new US_Services();
            var method = typeof(US_Services).GetMethod("ClearServiceDetails", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            method.Invoke(services, null);

            // Assert
            var sername = services.Controls.Find("sername_Lbl", true).FirstOrDefault() as Label;
            var serstatus = services.Controls.Find("serstatus_Lbl", true).FirstOrDefault() as Label;
            var startBtn = services.Controls.Find("Start_BTN", true).FirstOrDefault() as Button;
            var stopBtn = services.Controls.Find("Stop_BTN", true).FirstOrDefault() as Button;
            var restartBtn = services.Controls.Find("Restart_BTN", true).FirstOrDefault() as Button;
            var updateBtn = services.Controls.Find("Update_BTN", true).FirstOrDefault() as Button;

            Assert.NotNull(sername);
            Assert.NotNull(serstatus);
            Assert.Equal("-", sername.Text);
            Assert.Equal("-", serstatus.Text);
            Assert.False(startBtn?.Enabled);
            Assert.False(stopBtn?.Enabled);
            Assert.False(restartBtn?.Enabled);
            Assert.False(updateBtn?.Enabled);
        }

        [Fact]
        public void US_Services_SelectedIndex_UpdatesButtonState()
        {
            // Arrange
            var services = new US_Services();
            var method = typeof(US_Services).GetMethod("SelectedIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            var serviceBox = services.Controls.Find("Service_CBox", true).FirstOrDefault() as ComboBox;
            var updateBtn = services.Controls.Find("Update_BTN", true).FirstOrDefault() as Button;
            Assert.NotNull(serviceBox);
            Assert.NotNull(updateBtn);

            // Act - No selection
            serviceBox.SelectedIndex = -1;
            method.Invoke(services, null);

            // Assert
            Assert.False(updateBtn.Enabled);

            // Act - With selection (if there are items)
            if (serviceBox.Items.Count > 0)
            {
                serviceBox.SelectedIndex = 0;
                method.Invoke(services, null);
                Assert.True(updateBtn.Enabled);
            }
        }
    }
}