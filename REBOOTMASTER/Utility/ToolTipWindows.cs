namespace REBOOTMASTER.Utility
{
    internal class ToolTipWindows
    {
        // Set ToolTip
        internal static void SetToolTip(Control control, string _msg)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;
            // Set up the ToolTip text for the Control.
            toolTip.SetToolTip(control, _msg);
        }
    }
}