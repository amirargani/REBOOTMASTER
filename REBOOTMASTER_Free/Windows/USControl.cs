namespace REBOOTMASTER_Free.Windows
{
    internal class USControl
    {
        // User Controls
        // Add User Control
        public static void AddUserControl(UserControl userControl)
        {

            if (Main.mainObject?.FindForm() is Main main)
            {
                main.Invoke((MethodInvoker)delegate
                {
                    Panel? myPanel = main.Controls.Find("panel_UserControl", true).FirstOrDefault() as Panel;
                    userControl.Dock = DockStyle.None;
                    userControl.Invalidate();
                    userControl.Update();
                    myPanel!.Visible = true;
                    myPanel!.Controls.Clear();
                    myPanel!.Controls.Add(userControl);
                    userControl.BringToFront();
                });
            }
        }
    }
}