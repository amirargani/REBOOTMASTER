using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class ToolTipWindowsTests
    {
        [Fact]
        public void ToolTipWindows_SetToolTip_DoesNotThrow()
        {
            // Arrange
            var control = new Control();
            
            // Act & Assert
            ToolTipWindows.SetToolTip(control, "Test Tooltip");
        }
    }
}