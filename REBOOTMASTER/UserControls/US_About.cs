using System.Diagnostics;
using REBOOTMASTER.Utility;

namespace REBOOTMASTER.UserControls
{
    public partial class US_About : UserControl
    {
        // Constructor
        public US_About()
        {
            InitializeComponent();
            richTextBox_TXT.Cursor = Cursors.Default;
            copyright_Lbl.Text = copyright_Lbl.Text.Replace("2025 - XXXX", GetYear() == null ? "2025" : "2025 - " + GetYear());
            richTextBox_TXT.Rtf = $@"{{\rtf1\ansi\deff0{{\fonttbl{{\f0 Calibri;}}}}{{\colortbl ;\red255\green255\blue255;}}{{\pard\qj\cf1\f0\fs20{richTextBox_TXT.Text}\par}}}}";
        }

        // Get Year
        private string GetYear()
        {
            if (DateTime.Now.Year > 2025) return DateTime.Now.Year.ToString();
            copyright_Lbl.Location = new System.Drawing.Point(333, 424);
            return null!;
        }

        // MouseDown
        private void RichTextBox_TXT_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox_TXT.Cursor = Cursors.Default;
            this.ActiveControl = null;
        }

        // Click
        private void RichTextBox_TXT_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        // GitHub
        private void Github_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/amirargani") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}");
            }
        }

        // Homepage
        private void Homepage_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/amirargani/REBOOTMASTER") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}");
            }
        }

        // My Profile
        private void PictureBox_Profile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/amirargani") { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                NotificationService.GetException(ex);
                Log.Logger!.Error($"Unexpected error: {ex.Message} {Environment.NewLine + Log.CleanStackTrace(ex)}");
            }
        }
    }
}