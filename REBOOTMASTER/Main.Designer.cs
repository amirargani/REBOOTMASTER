namespace REBOOTMASTER_Free
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel_Top = new Panel();
            version_Lbl = new Label();
            pictureBox_TXT_Logo = new PictureBox();
            panel_Border = new Panel();
            minimized_BTN = new Button();
            close_BTN = new Button();
            pictureBox_Logo = new PictureBox();
            panel_Bottom = new Panel();
            panel_ProgressBar = new Panel();
            timer_ProgressBar = new System.Windows.Forms.Timer(components);
            timer_ProgressBar_Reset = new System.Windows.Forms.Timer(components);
            dashboard_BTN = new Button();
            services_BTN = new Button();
            settings_BTN = new Button();
            about_BTN = new Button();
            notifyIcon_Main = new NotifyIcon(components);
            contextMenuStrip_NotifyIcon = new ContextMenuStrip(components);
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            panel_UserControl = new Panel();
            panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TXT_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
            contextMenuStrip_NotifyIcon.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Top
            // 
            panel_Top.BackColor = Color.FromArgb(0, 8, 33);
            panel_Top.Controls.Add(version_Lbl);
            panel_Top.Controls.Add(pictureBox_TXT_Logo);
            panel_Top.Controls.Add(panel_Border);
            panel_Top.Controls.Add(minimized_BTN);
            panel_Top.Controls.Add(close_BTN);
            panel_Top.Controls.Add(pictureBox_Logo);
            panel_Top.Location = new Point(0, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(800, 80);
            panel_Top.TabIndex = 0;
            // 
            // version_Lbl
            // 
            version_Lbl.AutoSize = true;
            version_Lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            version_Lbl.ForeColor = Color.White;
            version_Lbl.Location = new Point(82, 55);
            version_Lbl.Name = "version_Lbl";
            version_Lbl.Size = new Size(86, 13);
            version_Lbl.TabIndex = 19;
            version_Lbl.Text = "Free v20251220";
            // 
            // pictureBox_TXT_Logo
            // 
            pictureBox_TXT_Logo.BackgroundImageLayout = ImageLayout.None;
            pictureBox_TXT_Logo.Image = (Image)resources.GetObject("pictureBox_TXT_Logo.Image");
            pictureBox_TXT_Logo.Location = new Point(79, 12);
            pictureBox_TXT_Logo.Name = "pictureBox_TXT_Logo";
            pictureBox_TXT_Logo.Size = new Size(94, 58);
            pictureBox_TXT_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_TXT_Logo.TabIndex = 12;
            pictureBox_TXT_Logo.TabStop = false;
            // 
            // panel_Border
            // 
            panel_Border.BackColor = Color.FromArgb(242, 9, 7);
            panel_Border.Location = new Point(0, 76);
            panel_Border.Name = "panel_Border";
            panel_Border.Size = new Size(800, 10);
            panel_Border.TabIndex = 1;
            // 
            // minimized_BTN
            // 
            minimized_BTN.FlatAppearance.BorderSize = 0;
            minimized_BTN.FlatStyle = FlatStyle.Flat;
            minimized_BTN.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimized_BTN.ForeColor = Color.White;
            minimized_BTN.Location = new Point(688, 12);
            minimized_BTN.Name = "minimized_BTN";
            minimized_BTN.Size = new Size(50, 43);
            minimized_BTN.TabIndex = 11;
            minimized_BTN.TabStop = false;
            minimized_BTN.Text = "-";
            minimized_BTN.UseVisualStyleBackColor = true;
            minimized_BTN.Visible = false;
            minimized_BTN.Click += minimized_BTN_Click;
            // 
            // close_BTN
            // 
            close_BTN.FlatAppearance.BorderSize = 0;
            close_BTN.FlatStyle = FlatStyle.Flat;
            close_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_BTN.ForeColor = Color.White;
            close_BTN.Location = new Point(738, 12);
            close_BTN.Name = "close_BTN";
            close_BTN.Size = new Size(50, 43);
            close_BTN.TabIndex = 10;
            close_BTN.TabStop = false;
            close_BTN.Text = "x";
            close_BTN.UseVisualStyleBackColor = false;
            close_BTN.Visible = false;
            close_BTN.Click += close_BTN_Click;
            // 
            // pictureBox_Logo
            // 
            pictureBox_Logo.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Logo.Image = (Image)resources.GetObject("pictureBox_Logo.Image");
            pictureBox_Logo.Location = new Point(14, 12);
            pictureBox_Logo.Name = "pictureBox_Logo";
            pictureBox_Logo.Size = new Size(59, 58);
            pictureBox_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Logo.TabIndex = 1;
            pictureBox_Logo.TabStop = false;
            // 
            // panel_Bottom
            // 
            panel_Bottom.BackColor = Color.FromArgb(0, 8, 33);
            panel_Bottom.Location = new Point(0, 595);
            panel_Bottom.Name = "panel_Bottom";
            panel_Bottom.Size = new Size(800, 10);
            panel_Bottom.TabIndex = 1;
            // 
            // panel_ProgressBar
            // 
            panel_ProgressBar.BackColor = Color.FromArgb(242, 9, 7);
            panel_ProgressBar.Location = new Point(0, 595);
            panel_ProgressBar.Name = "panel_ProgressBar";
            panel_ProgressBar.Size = new Size(0, 10);
            panel_ProgressBar.TabIndex = 2;
            // 
            // timer_ProgressBar
            // 
            timer_ProgressBar.Interval = 1;
            timer_ProgressBar.Tick += timer_ProgressBar_Tick;
            // 
            // timer_ProgressBar_Reset
            // 
            timer_ProgressBar_Reset.Interval = 1;
            timer_ProgressBar_Reset.Tick += timer_ProgressBar_Reset_Tick;
            // 
            // dashboard_BTN
            // 
            dashboard_BTN.BackColor = Color.FromArgb(0, 8, 33);
            dashboard_BTN.FlatAppearance.BorderSize = 0;
            dashboard_BTN.FlatStyle = FlatStyle.Flat;
            dashboard_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            dashboard_BTN.ForeColor = Color.White;
            dashboard_BTN.Location = new Point(143, 540);
            dashboard_BTN.Name = "dashboard_BTN";
            dashboard_BTN.Size = new Size(127, 44);
            dashboard_BTN.TabIndex = 15;
            dashboard_BTN.TabStop = false;
            dashboard_BTN.Text = "☰ Dashboard";
            dashboard_BTN.UseVisualStyleBackColor = false;
            dashboard_BTN.Visible = false;
            dashboard_BTN.Click += dashboard_BTN_Click;
            // 
            // services_BTN
            // 
            services_BTN.BackColor = Color.FromArgb(0, 8, 33);
            services_BTN.FlatAppearance.BorderSize = 0;
            services_BTN.FlatStyle = FlatStyle.Flat;
            services_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            services_BTN.ForeColor = Color.White;
            services_BTN.Location = new Point(276, 540);
            services_BTN.Name = "services_BTN";
            services_BTN.Size = new Size(127, 44);
            services_BTN.TabIndex = 16;
            services_BTN.TabStop = false;
            services_BTN.Text = "💻 Services";
            services_BTN.UseVisualStyleBackColor = false;
            services_BTN.Visible = false;
            services_BTN.Click += services_BTN_Click;
            // 
            // settings_BTN
            // 
            settings_BTN.BackColor = Color.FromArgb(0, 8, 33);
            settings_BTN.FlatAppearance.BorderSize = 0;
            settings_BTN.FlatStyle = FlatStyle.Flat;
            settings_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            settings_BTN.ForeColor = Color.White;
            settings_BTN.Location = new Point(409, 540);
            settings_BTN.Name = "settings_BTN";
            settings_BTN.Size = new Size(127, 44);
            settings_BTN.TabIndex = 17;
            settings_BTN.TabStop = false;
            settings_BTN.Text = "🛠️ Settings";
            settings_BTN.UseVisualStyleBackColor = false;
            settings_BTN.Visible = false;
            settings_BTN.Click += settings_BTN_Click;
            // 
            // about_BTN
            // 
            about_BTN.BackColor = Color.FromArgb(0, 8, 33);
            about_BTN.FlatAppearance.BorderSize = 0;
            about_BTN.FlatStyle = FlatStyle.Flat;
            about_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            about_BTN.ForeColor = Color.White;
            about_BTN.Location = new Point(542, 540);
            about_BTN.Name = "about_BTN";
            about_BTN.Size = new Size(127, 44);
            about_BTN.TabIndex = 18;
            about_BTN.TabStop = false;
            about_BTN.Text = "📢 About";
            about_BTN.UseVisualStyleBackColor = false;
            about_BTN.Visible = false;
            about_BTN.Click += about_BTN_Click;
            // 
            // notifyIcon_Main
            // 
            notifyIcon_Main.ContextMenuStrip = contextMenuStrip_NotifyIcon;
            notifyIcon_Main.Icon = (Icon)resources.GetObject("notifyIcon_Main.Icon");
            notifyIcon_Main.Text = "notifyIcon_Main";
            notifyIcon_Main.Visible = true;
            notifyIcon_Main.MouseDoubleClick += notifyIcon_Main_MouseDoubleClick;
            // 
            // contextMenuStrip_NotifyIcon
            // 
            contextMenuStrip_NotifyIcon.Items.AddRange(new ToolStripItem[] { exitApplicationToolStripMenuItem });
            contextMenuStrip_NotifyIcon.Name = "contextMenuStrip_NotifyIcon";
            contextMenuStrip_NotifyIcon.Size = new Size(108, 26);
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(107, 22);
            exitApplicationToolStripMenuItem.Text = "✖ Exit";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // panel_UserControl
            // 
            panel_UserControl.Location = new Point(0, 79);
            panel_UserControl.Name = "panel_UserControl";
            panel_UserControl.Size = new Size(800, 450);
            panel_UserControl.TabIndex = 19;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 600);
            Controls.Add(panel_UserControl);
            Controls.Add(about_BTN);
            Controls.Add(settings_BTN);
            Controls.Add(services_BTN);
            Controls.Add(dashboard_BTN);
            Controls.Add(panel_ProgressBar);
            Controls.Add(panel_Bottom);
            Controls.Add(panel_Top);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REBOOTMASTER";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TXT_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
            contextMenuStrip_NotifyIcon.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Top;
        private Button minimized_BTN;
        private Button close_BTN;
        private Panel panel_Border;
        private PictureBox pictureBox_Logo;
        private PictureBox pictureBox_TXT_Logo;
        private Panel panel_Bottom;
        private Panel panel_ProgressBar;
        private System.Windows.Forms.Timer timer_ProgressBar;
        private System.Windows.Forms.Timer timer_ProgressBar_Reset;
        private Button dashboard_BTN;
        private Button services_BTN;
        private Button settings_BTN;
        private Button about_BTN;
        private Label version_Lbl;
        private NotifyIcon notifyIcon_Main;
        private ContextMenuStrip contextMenuStrip_NotifyIcon;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private Panel panel_UserControl;
    }
}