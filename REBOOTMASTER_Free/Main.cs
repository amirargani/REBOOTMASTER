using REBOOTMASTER_Free.Transition;
using REBOOTMASTER_Free.UserControls;
using REBOOTMASTER_Free.Windows;
using Log = REBOOTMASTER_Free.Utility.Log;
using _msg = REBOOTMASTER_Free.Message.Message;

namespace REBOOTMASTER_Free
{
    public partial class Main : Form
    {
        // Variable
        public bool isFinish = false;
        public bool isSettings = false;
        private bool setProgressBar = false;
        private bool isWindowsFormActive = false;
        // User Controls
        public static Main? mainObject;
        public US_About uS_About = new US_About();
        public US_Settings uS_Settings = new US_Settings();
        public US_Services uS_Services = new US_Services();
        public US_Dashboard uS_Dashboard = new US_Dashboard();

        // Timer
        public System.Windows.Forms.Timer _timerProgressBar;

        // Constructor: Main
        public Main()
        {
            InitializeComponent();
            mainObject = this;
            ShowInTaskbar = false;
            panel_UesrControl.Visible = false;

            // Timer
            _timerProgressBar = new System.Windows.Forms.Timer();
            _timerProgressBar.Interval = 1; // Interval in milliseconds
            _timerProgressBar.Tick += timer_ProgressBar_Tick!;
        }

        // Main Load
        private void Main_Load(object sender, EventArgs e)
        {
            // https://github.com/GuiferrSouza/WindowsFormAnimation
            var animation = new Animation
            {
                Duration = 1500,
                Flags = Animation.AnimationFlags.Fade,
                Name = "Fade"
            };

            var animate = new Animate();
            animate.AnimationStarted += (anim) =>
            {
                Cursor = Cursors.Default;
                Invalidate();
                Update();
                timer_ProgressBar.Start();
            };
            animate.Play(Handle, animation);
        }

        // Timer ProgressBar: Start
        private void timer_ProgressBar_Tick(object sender, EventArgs e)
        {
            if (!setProgressBar) panel_ProgressBar.Width += 2;
            if (panel_ProgressBar.Width >= 800)
            {
                timer_ProgressBar.Stop();
                _timerProgressBar.Stop();
                if (!isWindowsFormActive)
                {
                    ShowInTaskbar = true;
                    Invalidate();
                    Update();
                    isWindowsFormActive = true;
                }
                timer_ProgressBar_Reset.Start();
            }
        }

        // Timer ProgressBar: Reset
        private void timer_ProgressBar_Reset_Tick(object sender, EventArgs e)
        {
            if (!setProgressBar) panel_ProgressBar.Width -= 2;
            if (panel_ProgressBar.Width <= 0)
            {
                timer_ProgressBar_Reset.Stop();
                dashboard_BTN.Visible = true;
                services_BTN.Visible = true;
                settings_BTN.Visible = true;
                about_BTN.Visible = true;
                close_BTN.Visible = true;
                minimized_BTN.Visible = true;
                isFinish = true;
                if (isSettings) { Enabled = true; isSettings  = false; }
            }
        }

        // Close Button
        private void close_BTN_Click(object sender, EventArgs e)
        {
            this.Focus();
            this.Select();
            Close();
        }

        // Minimized Button
        private async void minimized_BTN_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                //SetSelectItem(selectItem);
                Effect effect = new Effect(this);
                await effect.HideAsync();
                Hide();
                notifyIcon_Main.Visible = true;
                notifyIcon_Main.Text = "REBOOTMASTER";
                notifyIcon_Main.BalloonTipTitle = "REBOOTMASTER vFree";
                notifyIcon_Main.BalloonTipText = "GitHub: https://github.com/amirargani";
                notifyIcon_Main.ShowBalloonTip(1000);
                this.Focus();
                this.Select();
                Log.Logger!.Info("REBOOTMASTER minimized. The program was minimized.");
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.Focus();
                this.Select();
                notifyIcon_Main.Visible = false;
            }
        }

        // NotifyIcon
        private async void notifyIcon_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Show();
            //SetSelectItem(selectItem);
            Effect effect = new Effect(this);
            await effect.FadeAsync(true);
            Opacity = 1;
            WindowState = FormWindowState.Normal;
            notifyIcon_Main.Visible = false;
            Log.Logger!.Info("REBOOTMASTER normalized. The program was normalized.");
        }

        // Strip Menu Item >> Exit Application
        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Main Form Closing
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (!isFinish)
            {
                MessageBox.Show(_msg._msgCloseApp, _msg._caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log.Logger!.Warn($"REBOOTMASTER closed. {_msg._msgCloseApp}");
            }
            else if (isFinish)
            {
                if (MessageBox.Show(_msg._msg, _msg._caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    e.Cancel = false; // Not Working: Application.Exit(); | Close();
                    Log.Logger!.Info("REBOOTMASTER closed. The program was closed.");
                }
            }
        }

        // About Button
        private void about_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_About);
        }


        // Settings Button
        private void settings_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_Settings);
        }


        // Services Button
        private void services_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_Services);
        }


        // Dashboard Button
        private void dashboard_BTN_Click(object sender, EventArgs e)
        {
            USControl.AddUserControl(uS_Dashboard);
        }
    }
}
