using REBOOTMASTER.Windows;

namespace REBOOTMASTER.Tests.Windows
{
    public class USControlTests
    {
        [Fact]
        public void AddUserControl_AddsControlToPanel()
        {
            // Arrange
            if (Main.mainObject?.FindForm() is Main main)
            {
                Main.mainObject = main;
                var _ = main.Handle; // force handle creation for Invoke

                var panel = main.Controls.Find("panel_UserControl", true).FirstOrDefault() as Panel;
                Assert.NotNull(panel);
                panel.Controls.Clear();
                panel.Visible = false;

                var control = new UserControl();

                // Act
                USControl.AddUserControl(control);

                // Assert
                Assert.True(panel.Visible);
                Assert.Contains(control, panel.Controls.Cast<Control>());
                Assert.Equal(DockStyle.None, control.Dock);

                // Cleanup
                panel.Controls.Clear();
                Main.mainObject = null;
            }
        }

        [Fact]
        public void AddUserControl_NoMainObject_DoesNotThrow()
        {
            // Arrange
            Main.mainObject = null;
            var control = new UserControl();

            // Act & Assert - should not throw
            USControl.AddUserControl(control);
        }
    }
}