using REBOOTMASTER.UserControls;

namespace REBOOTMASTER.Tests.UserControls
{
    public class US_DashboardTests
    {
        [Fact]
        public void US_Dashboard_Properties_WorkCorrectly()
        {
            // Arrange
            var dashboard = new US_Dashboard();

            // Act
            dashboard.sermonitoringcount = "10";
            dashboard.autorestartsercount = "5";
            dashboard.unexpectedfailurescount = "2";
            dashboard.inactiveser = "1";

            // Assert
            Assert.Equal("10", dashboard.sermonitoringcount);
            Assert.Equal("5", dashboard.autorestartsercount);
            Assert.Equal("2", dashboard.unexpectedfailurescount);
            Assert.Equal("1", dashboard.inactiveser);
        }

        [Fact]
        public void US_Dashboard_InitialState_IsCorrect()
        {
            // Act
            var dashboard = new US_Dashboard();

            // Assert
            var startBtn = dashboard.Controls.Find("Start_BTN", true).FirstOrDefault() as Button;
            var stopBtn = dashboard.Controls.Find("Stop_BTN", true).FirstOrDefault() as Button;

            Assert.NotNull(startBtn);
            Assert.NotNull(stopBtn);
            Assert.True(startBtn.Enabled);
            Assert.False(stopBtn.Enabled);
        }

        [Fact]
        public void US_Dashboard_UIElements_ArePresent()
        {
            // Act
            var dashboard = new US_Dashboard();

            // Assert
            var logLabel = dashboard.Controls.Find("log_Lbl", true).FirstOrDefault() as Label;
            var monitoringPanel = dashboard.Controls.Find("sermonitoring_panel", true).FirstOrDefault() as Panel;
            var liveLogPanel = dashboard.Controls.Find("livelog_panel", true).FirstOrDefault() as Panel;

            Assert.NotNull(logLabel);
            Assert.NotNull(monitoringPanel);
            Assert.NotNull(liveLogPanel);
        }

        [Fact]
        public void US_Dashboard_AddLogLine_RotatesLogs()
        {
            // Arrange
            var dashboard = new US_Dashboard();
            var method = typeof(US_Dashboard).GetMethod("AddLogLine", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            string initialText = "Line1\r\nLine2\r\nLine3\r\nLine4\r\nLine5\r\nLine6\r\nLine7\r\nLine8\r\n";
            string newLine = "Line9";

            // Act - Add line when max is 8
            var result = method.Invoke(dashboard, new object[] { initialText, newLine, 8, 1 }) as string;

            // Assert - Should remove Line1 and add Line9
            Assert.NotNull(result);
            Assert.DoesNotContain("Line1", result);
            Assert.Contains("Line2", result);
            Assert.Contains("Line9", result);
            
            // Check line count (including the trailing \r\n)
            var lines = result.Split(new[] { "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.Equal(8, lines.Length);
        }

        [Fact]
        public void US_Dashboard_Timers_HaveCorrectDefaults()
        {
            // Arrange
            var dashboard = new US_Dashboard();

            // Act
            var autoCheckTimer = typeof(US_Dashboard).GetField("AutoCheckServiceTimer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(dashboard) as System.Windows.Forms.Timer;
            var serviceStoppedTimer = typeof(US_Dashboard).GetField("TimerWhenServiceStopped", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(dashboard) as System.Windows.Forms.Timer;

            // Assert
            Assert.NotNull(autoCheckTimer);
            Assert.NotNull(serviceStoppedTimer);
            Assert.Equal(30000, autoCheckTimer.Interval);
            Assert.Equal(600000, serviceStoppedTimer.Interval);
        }

        [Fact]
        public void US_Dashboard_TabControlHandlers_DoNotThrow()
        {
            // Arrange
            var dashboard = new US_Dashboard();
            // We set mainObject to null to avoid side effects or use a mock main if we could, 
            // but here we just want to ensure the methods don't crash when mainObject is null.
            Main.mainObject = null;

            var disableMethod = typeof(US_Dashboard).GetMethod("DisableTabUserControl", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var enableMethod = typeof(US_Dashboard).GetMethod("EnabledTabUserControl", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Act & Assert
            disableMethod?.Invoke(dashboard, null);
            enableMethod?.Invoke(dashboard, null);
            // No exception means success for this "safely handle null main" case
        }

        [Fact]
        public void US_Dashboard_CenterLabelInPanel_CalculatesCorrectX()
        {
            // Arrange
            var dashboard = new US_Dashboard();
            var panel = new Panel { Width = 200 };
            var label = new Label { Text = "Test", Font = new System.Drawing.Font("Arial", 10) };
            panel.Controls.Add(label);

            var method = typeof(US_Dashboard).GetMethod("CenterLabelInPanel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            method.Invoke(dashboard, new object[] { label, panel });

            // Assert
            int textWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;
            int expectedX = (panel.Width - textWidth) / 2;
            Assert.Equal(expectedX, label.Location.X);
        }

        [Fact]
        public void US_Dashboard_GetDateTime_ReturnsCorrectFormat()
        {
            // Arrange
            var dashboard = new US_Dashboard();
            var method = typeof(US_Dashboard).GetMethod("GetDateTime", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            var result = (System.DateTime)method.Invoke(dashboard, null)!;

            // Assert
            var now = System.DateTime.Now;
            Assert.Equal(now.Year, result.Year);
            Assert.Equal(now.Month, result.Month);
            Assert.Equal(now.Day, result.Day);
            Assert.Equal(0, result.Millisecond);
        }

        [Fact]
        public void US_Dashboard_SetLabelAndCenter_UpdatesLabelAndCenters()
        {
            // Arrange
            var dashboard = new US_Dashboard();
            var panel = new Panel { Width = 300 };
            var label = new Label { Font = new Font("Arial", 12) };
            panel.Controls.Add(label);

            var method = typeof(US_Dashboard).GetMethod("SetLabelAndCenter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            // Act
            method.Invoke(dashboard, new object[] { label, panel, "Test Value" });

            // Assert
            Assert.Equal("Test Value", label.Text);
            // Verify centering logic was applied
            int textWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;
            int expectedX = (panel.Width - textWidth) / 2;
            Assert.Equal(expectedX, label.Location.X);
        }

        [Fact]
        public async Task US_Dashboard_WaitTask_CompletesAfterDelay()
        {
            // Arrange
            var dashboard = new US_Dashboard();
            var method = typeof(US_Dashboard).GetMethod("WaitTask", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(method);

            var delay = TimeSpan.FromMilliseconds(100);
            var startTime = DateTime.Now;

            // Act
            var task = method.Invoke(dashboard, new object[] { delay }) as Task;
            Assert.NotNull(task);
            await task;

            // Assert
            var elapsed = DateTime.Now - startTime;
            Assert.True(elapsed >= delay, $"Expected at least {delay.TotalMilliseconds}ms, but got {elapsed.TotalMilliseconds}ms");
        }

        [Fact]
        public void US_Dashboard_AutoCheckServiceTimer_IsConfigured()
        {
            // Arrange
            var dashboard = new US_Dashboard();

            // Act
            var autoCheckTimer = typeof(US_Dashboard).GetField("AutoCheckServiceTimer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(dashboard) as System.Windows.Forms.Timer;

            // Assert
            Assert.NotNull(autoCheckTimer);
            Assert.Equal(30000, autoCheckTimer.Interval); // 30 seconds
            Assert.False(autoCheckTimer.Enabled); // Should be disabled initially
        }

        [Fact]
        public void US_Dashboard_TimerWhenServiceStopped_IsConfigured()
        {
            // Arrange
            var dashboard = new US_Dashboard();

            // Act
            var serviceStoppedTimer = typeof(US_Dashboard).GetField("TimerWhenServiceStopped", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(dashboard) as System.Windows.Forms.Timer;

            // Assert
            Assert.NotNull(serviceStoppedTimer);
            Assert.Equal(600000, serviceStoppedTimer.Interval); // 10 minutes
            Assert.False(serviceStoppedTimer.Enabled); // Should be disabled initially
        }
    }
}