namespace REBOOTMASTER_Free.UserControls
{
    partial class US_Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Settings));
            pictureBox_Arrow = new PictureBox();
            tabControl_Settings = new TabControl();
            tabPage_SMTP = new TabPage();
            email_Lbl = new Label();
            pass_Lbl = new Label();
            host_Lbl = new Label();
            port_Lbl = new Label();
            user_Lbl = new Label();
            tabPage_Interruption = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
            tabControl_Settings.SuspendLayout();
            tabPage_SMTP.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Arrow
            // 
            pictureBox_Arrow.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Arrow.Image = (Image)resources.GetObject("pictureBox_Arrow.Image");
            pictureBox_Arrow.Location = new Point(452, 223);
            pictureBox_Arrow.Name = "pictureBox_Arrow";
            pictureBox_Arrow.Size = new Size(724, 497);
            pictureBox_Arrow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Arrow.TabIndex = 30;
            pictureBox_Arrow.TabStop = false;
            // 
            // tabControl_Settings
            // 
            tabControl_Settings.Controls.Add(tabPage_Interruption);
            tabControl_Settings.Controls.Add(tabPage_SMTP);
            tabControl_Settings.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            tabControl_Settings.Location = new Point(33, 13);
            tabControl_Settings.Name = "tabControl_Settings";
            tabControl_Settings.SelectedIndex = 0;
            tabControl_Settings.Size = new Size(662, 420);
            tabControl_Settings.TabIndex = 36;
            // 
            // tabPage_SMTP
            // 
            tabPage_SMTP.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_SMTP.Controls.Add(email_Lbl);
            tabPage_SMTP.Controls.Add(pass_Lbl);
            tabPage_SMTP.Controls.Add(host_Lbl);
            tabPage_SMTP.Controls.Add(port_Lbl);
            tabPage_SMTP.Controls.Add(user_Lbl);
            tabPage_SMTP.Location = new Point(4, 26);
            tabPage_SMTP.Name = "tabPage_SMTP";
            tabPage_SMTP.Padding = new Padding(3);
            tabPage_SMTP.Size = new Size(654, 390);
            tabPage_SMTP.TabIndex = 0;
            tabPage_SMTP.Text = "📜SMTP Configuration";
            // 
            // email_Lbl
            // 
            email_Lbl.AutoSize = true;
            email_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            email_Lbl.ForeColor = Color.White;
            email_Lbl.Location = new Point(28, 148);
            email_Lbl.Name = "email_Lbl";
            email_Lbl.Size = new Size(117, 17);
            email_Lbl.TabIndex = 40;
            email_Lbl.Text = "Recipient's email:";
            // 
            // pass_Lbl
            // 
            pass_Lbl.AutoSize = true;
            pass_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            pass_Lbl.ForeColor = Color.White;
            pass_Lbl.Location = new Point(28, 117);
            pass_Lbl.Name = "pass_Lbl";
            pass_Lbl.Size = new Size(109, 17);
            pass_Lbl.TabIndex = 39;
            pass_Lbl.Text = "SMTP Password:";
            // 
            // host_Lbl
            // 
            host_Lbl.AutoSize = true;
            host_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            host_Lbl.ForeColor = Color.White;
            host_Lbl.Location = new Point(28, 23);
            host_Lbl.Name = "host_Lbl";
            host_Lbl.Size = new Size(80, 17);
            host_Lbl.TabIndex = 38;
            host_Lbl.Text = "SMTP Host:";
            // 
            // port_Lbl
            // 
            port_Lbl.AutoSize = true;
            port_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            port_Lbl.ForeColor = Color.White;
            port_Lbl.Location = new Point(28, 55);
            port_Lbl.Name = "port_Lbl";
            port_Lbl.Size = new Size(77, 17);
            port_Lbl.TabIndex = 37;
            port_Lbl.Text = "SMTP Port:";
            // 
            // user_Lbl
            // 
            user_Lbl.AutoSize = true;
            user_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            user_Lbl.ForeColor = Color.White;
            user_Lbl.Location = new Point(28, 86);
            user_Lbl.Name = "user_Lbl";
            user_Lbl.Size = new Size(79, 17);
            user_Lbl.TabIndex = 36;
            user_Lbl.Text = "SMTP User:";
            // 
            // tabPage_Interruption
            // 
            tabPage_Interruption.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_Interruption.Location = new Point(4, 26);
            tabPage_Interruption.Name = "tabPage_Interruption";
            tabPage_Interruption.Padding = new Padding(3);
            tabPage_Interruption.Size = new Size(654, 390);
            tabPage_Interruption.TabIndex = 1;
            tabPage_Interruption.Text = "⏳Interruption";
            // 
            // US_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(tabControl_Settings);
            Controls.Add(pictureBox_Arrow);
            Name = "US_Settings";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            tabControl_Settings.ResumeLayout(false);
            tabPage_SMTP.ResumeLayout(false);
            tabPage_SMTP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox_Arrow;
        private GroupBox groupBox1;
        private TabControl tabControl_Settings;
        private TabPage tabPage_SMTP;
        private TabPage tabPage_Interruption;
        private Label pass_Lbl;
        private Label host_Lbl;
        private Label port_Lbl;
        private Label user_Lbl;
        private Label email_Lbl;
    }
}
