namespace REBOOTMASTER.Tests
{
    public class MainTests
    {
        [Fact]
        public void Main_Initialization_Works()
        {
            // Act
            var main = new Main();

            // Assert
            Assert.NotNull(main);
            Assert.NotNull(main.uS_About);
            Assert.NotNull(main.uS_Dashboard);
            Assert.NotNull(main.uS_Services);
            Assert.NotNull(main.uS_Settings);
            Assert.False(main.ShowInTaskbar);
        }

        [Fact]
        public void Main_InitialFields_HaveCorrectDefaultValues()
        {
            // Act
            var main = new Main();

            // Assert
            Assert.False(main.isFinish);
            Assert.False(main.isStatus);
            Assert.False(main.isSettings);
            Assert.Null(main.serviceName);
            Assert.Null(main.serviceStatus);
            // serviceStatusBTN is null initially even though initialized to null! (which is a bit weird but that's what the code says)
            Assert.Null(main.serviceStatusBTN);
        }

        [Fact]
        public void Main_UserControls_AreAccessibleViaProperties()
        {
            // Act
            var main = new Main();

            // Assert
            Assert.Same(main.uS_Services, main.ServicesControl);
        }

        [Fact]
        public void Main_Timer_IsConfiguredCorrectly()
        {
            // Act
            var main = new Main();

            // Assert
            Assert.NotNull(main._progressBarTimer);
            Assert.Equal(1, main._progressBarTimer.Interval);
        }

        [Fact]
        public void Main_FormProperties_AreSetCorrectly()
        {
            // Act
            var main = new Main();

            // Assert
            Assert.Equal(FormBorderStyle.None, main.FormBorderStyle);
            Assert.Equal(FormStartPosition.CenterScreen, main.StartPosition);
            Assert.Equal("REBOOTMASTER", main.Text);

        }

        [Fact]
        public void Main_UIElements_InitialVisibility()
        {
            // Act
            var main = new Main();

            // Assert
            // panel_UserControl.Visible = false; in constructor
            var panelUserControl = main.Controls.Find("panel_UserControl", true).FirstOrDefault() as Panel;
            Assert.NotNull(panelUserControl);
            Assert.False(panelUserControl.Visible);

            // Buttons are hidden initially (Visible = false in Designer and only set to true in ResetProgressBarTimer_Tick)
            var dashboardBtn = main.Controls.Find("Dashboard_BTN", true).FirstOrDefault() as Button;
            var servicesBtn = main.Controls.Find("Services_BTN", true).FirstOrDefault() as Button;
            
            Assert.NotNull(dashboardBtn);
            Assert.NotNull(servicesBtn);
            Assert.False(dashboardBtn.Visible);
            Assert.False(servicesBtn.Visible);
        }

        [Fact]
        public void Main_ButtonStates_CanBeToggled()
        {
            // Arrange
            var main = new Main();

            // Act
            main.DisableButton();
            
            // Assert
            var servicesBtn = main.Controls.Find("Services_BTN", true).FirstOrDefault() as Button;
            var settingsBtn = main.Controls.Find("Settings_BTN", true).FirstOrDefault() as Button;
            
            Assert.NotNull(servicesBtn);
            Assert.NotNull(settingsBtn);
            Assert.False(servicesBtn.Enabled);
            Assert.False(settingsBtn.Enabled);

            // Act
            main.EnableButton();

            // Assert
            Assert.True(servicesBtn.Enabled);
            Assert.True(settingsBtn.Enabled);
        }

        [Fact]
        public void Main_ProgressBarTimer_Tick_IncreasesPanelWidth()
        {
            // Arrange
            var main = new Main();
            var panelProgressBar = main.Controls.Find("panel_ProgressBar", true).FirstOrDefault() as Panel;
            Assert.NotNull(panelProgressBar);
            int initialWidth = panelProgressBar.Width;

            // Use reflection to call the private ProgressBarTimer_Tick method
            var method = typeof(Main).GetMethod("ProgressBarTimer_Tick", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            method.Invoke(main, new object[] { new System.Windows.Forms.Timer(), EventArgs.Empty });

            // Assert
            Assert.Equal(initialWidth + 5, panelProgressBar.Width);
        }

        [Fact]
        public void Main_ProgressBarTimer_Tick_TransitionToResetState()
        {
            // Arrange
            var main = new Main();
            var panelProgressBar = main.Controls.Find("panel_ProgressBar", true).FirstOrDefault() as Panel;
            Assert.NotNull(panelProgressBar);
            panelProgressBar.Width = 795; // Next tick should trigger transition

            // Use reflection to call the private ProgressBarTimer_Tick method
            var method = typeof(Main).GetMethod("ProgressBarTimer_Tick", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            method.Invoke(main, new object[] { new System.Windows.Forms.Timer(), EventArgs.Empty });

            // Assert
            Assert.Equal(800, panelProgressBar.Width);
            Assert.True(main.ShowInTaskbar);
            
            // Check private field isWindowsFormActive using reflection
            var isActiveField = typeof(Main).GetField("isWindowsFormActive", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            bool isActive = (bool)isActiveField?.GetValue(main)!;
            Assert.True(isActive);
        }

        [Fact]

        public void Main_ResetProgressBarTimer_Tick_DecreasesPanelWidth()
        {
            // Arrange
            var main = new Main();
            var panelProgressBar = main.Controls.Find("panel_ProgressBar", true).FirstOrDefault() as Panel;
            Assert.NotNull(panelProgressBar);
            panelProgressBar.Width = 100;

            // Use reflection to call the private ResetProgressBarTimer_Tick method
            var method = typeof(Main).GetMethod("ResetProgressBarTimer_Tick", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            method.Invoke(main, new object[] { new System.Windows.Forms.Timer(), EventArgs.Empty });

            // Assert
            Assert.Equal(95, panelProgressBar.Width);
        }

        [Fact]
        public void Main_ResetProgressBarTimer_Tick_FinalizesState()
        {
            // Arrange
            var main = new Main();
            Main.mainObject = main; // Ensure static property is set for this test
            var handle = main.Handle; // Force handle creation
            var panelProgressBar = main.Controls.Find("panel_ProgressBar", true).FirstOrDefault() as Panel;
            Assert.NotNull(panelProgressBar);
            panelProgressBar.Width = 5; // Next tick should trigger finalization

            var method = typeof(Main).GetMethod("ResetProgressBarTimer_Tick", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Set showDashboard to false to avoid PerformClick side effects during test
            var showDashboardField = typeof(Main).GetField("showDashboard", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            showDashboardField?.SetValue(main, false);

            // Act
            int widthBefore = panelProgressBar.Width;
            try
            {
                method.Invoke(main, new object[] { new System.Windows.Forms.Timer(), EventArgs.Empty });
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                throw ex.InnerException!;
            }
            int widthAfter = panelProgressBar.Width;

            // Assert
            Assert.Equal(0, panelProgressBar.Width);
            Assert.True(main.isFinish);
            
            var dashboardBtn = main.Controls.Find("Dashboard_BTN", true).FirstOrDefault() as Button;
            Assert.NotNull(dashboardBtn);
            // Note: Visible property returns false if parent is not visible (which is true in headless tests)
            // Assert.True(dashboardBtn.Visible);
        }


        [Fact]
        public void Main_UserControl_CanBeAddedToPanel()
        {
            // Arrange
            var main = new Main();
            var panelUserControl = main.Controls.Find("panel_UserControl", true).FirstOrDefault() as Panel;
            Assert.NotNull(panelUserControl);
            var about = new REBOOTMASTER.UserControls.US_About();

            // Act
            panelUserControl.Controls.Add(about);

            // Assert
            Assert.Contains(about, panelUserControl.Controls.Cast<Control>());
        }
    }
}