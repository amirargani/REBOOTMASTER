namespace REBOOTMASTER
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
            Minimized_BTN = new Button();
            Close_BTN = new Button();
            pictureBox_Logo = new PictureBox();
            panel_Bottom = new Panel();
            panel_ProgressBar = new Panel();
            ProgressBarTimer = new System.Windows.Forms.Timer(components);
            ResetProgressBarTimer = new System.Windows.Forms.Timer(components);
            Dashboard_BTN = new Button();
            Services_BTN = new Button();
            Settings_BTN = new Button();
            About_BTN = new Button();
            MainNotifyIcon = new NotifyIcon(components);
            NotifyIconMenu = new ContextMenuStrip(components);
            ExitApplicationToolStripMenuItem = new ToolStripMenuItem();
            panel_UserControl = new Panel();
            panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TXT_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
            NotifyIconMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Top
            // 
            panel_Top.BackColor = Color.FromArgb(0, 8, 33);
            panel_Top.Controls.Add(version_Lbl);
            panel_Top.Controls.Add(pictureBox_TXT_Logo);
            panel_Top.Controls.Add(panel_Border);
            panel_Top.Controls.Add(Minimized_BTN);
            panel_Top.Controls.Add(Close_BTN);
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
            version_Lbl.Text = "Free v20260202";
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
            // Minimized_BTN
            // 
            Minimized_BTN.FlatAppearance.BorderSize = 0;
            Minimized_BTN.FlatStyle = FlatStyle.Flat;
            Minimized_BTN.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minimized_BTN.ForeColor = Color.White;
            Minimized_BTN.Location = new Point(688, 12);
            Minimized_BTN.Name = "Minimized_BTN";
            Minimized_BTN.Size = new Size(50, 43);
            Minimized_BTN.TabIndex = 11;
            Minimized_BTN.TabStop = false;
            Minimized_BTN.Text = "-";
            Minimized_BTN.UseVisualStyleBackColor = true;
            Minimized_BTN.Visible = false;
            Minimized_BTN.Click += Minimized_BTN_Click;
            // 
            // Close_BTN
            // 
            Close_BTN.FlatAppearance.BorderSize = 0;
            Close_BTN.FlatStyle = FlatStyle.Flat;
            Close_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_BTN.ForeColor = Color.White;
            Close_BTN.Location = new Point(738, 12);
            Close_BTN.Name = "Close_BTN";
            Close_BTN.Size = new Size(50, 43);
            Close_BTN.TabIndex = 10;
            Close_BTN.TabStop = false;
            Close_BTN.Text = "x";
            Close_BTN.UseVisualStyleBackColor = false;
            Close_BTN.Visible = false;
            Close_BTN.Click += Close_BTN_Click;
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
            // ProgressBarTimer
            // 
            ProgressBarTimer.Interval = 1;
            ProgressBarTimer.Tick += ProgressBarTimer_Tick;
            // 
            // ResetProgressBarTimer
            // 
            ResetProgressBarTimer.Interval = 1;
            ResetProgressBarTimer.Tick += ResetProgressBarTimer_Tick;
            // 
            // Dashboard_BTN
            // 
            Dashboard_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Dashboard_BTN.FlatAppearance.BorderSize = 0;
            Dashboard_BTN.FlatStyle = FlatStyle.Flat;
            Dashboard_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Dashboard_BTN.ForeColor = Color.White;
            Dashboard_BTN.Location = new Point(143, 540);
            Dashboard_BTN.Name = "Dashboard_BTN";
            Dashboard_BTN.Size = new Size(127, 44);
            Dashboard_BTN.TabIndex = 15;
            Dashboard_BTN.TabStop = false;
            Dashboard_BTN.Text = "☰ Dashboard";
            Dashboard_BTN.UseVisualStyleBackColor = false;
            Dashboard_BTN.Visible = false;
            Dashboard_BTN.Click += Dashboard_BTN_Click;
            // 
            // Services_BTN
            // 
            Services_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Services_BTN.FlatAppearance.BorderSize = 0;
            Services_BTN.FlatStyle = FlatStyle.Flat;
            Services_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Services_BTN.ForeColor = Color.White;
            Services_BTN.Location = new Point(276, 540);
            Services_BTN.Name = "Services_BTN";
            Services_BTN.Size = new Size(127, 44);
            Services_BTN.TabIndex = 16;
            Services_BTN.TabStop = false;
            Services_BTN.Text = "💻 Services";
            Services_BTN.UseVisualStyleBackColor = false;
            Services_BTN.Visible = false;
            Services_BTN.Click += Services_BTN_Click;
            // 
            // Settings_BTN
            // 
            Settings_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Settings_BTN.FlatAppearance.BorderSize = 0;
            Settings_BTN.FlatStyle = FlatStyle.Flat;
            Settings_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Settings_BTN.ForeColor = Color.White;
            Settings_BTN.Location = new Point(409, 540);
            Settings_BTN.Name = "Settings_BTN";
            Settings_BTN.Size = new Size(127, 44);
            Settings_BTN.TabIndex = 17;
            Settings_BTN.TabStop = false;
            Settings_BTN.Text = "🛠️ Settings";
            Settings_BTN.UseVisualStyleBackColor = false;
            Settings_BTN.Visible = false;
            Settings_BTN.Click += Settings_BTN_Click;
            // 
            // About_BTN
            // 
            About_BTN.BackColor = Color.FromArgb(0, 8, 33);
            About_BTN.FlatAppearance.BorderSize = 0;
            About_BTN.FlatStyle = FlatStyle.Flat;
            About_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            About_BTN.ForeColor = Color.White;
            About_BTN.Location = new Point(542, 540);
            About_BTN.Name = "About_BTN";
            About_BTN.Size = new Size(127, 44);
            About_BTN.TabIndex = 18;
            About_BTN.TabStop = false;
            About_BTN.Text = "📢 About";
            About_BTN.UseVisualStyleBackColor = false;
            About_BTN.Visible = false;
            About_BTN.Click += About_BTN_Click;
            // 
            // MainNotifyIcon
            // 
            MainNotifyIcon.ContextMenuStrip = NotifyIconMenu;
            MainNotifyIcon.Icon = (Icon)resources.GetObject("MainNotifyIcon.Icon");
            MainNotifyIcon.MouseDoubleClick += MainNotifyIcon_MouseDoubleClick;
            // 
            // NotifyIconMenu
            // 
            NotifyIconMenu.Items.AddRange(new ToolStripItem[] { ExitApplicationToolStripMenuItem });
            NotifyIconMenu.Name = "notifyIconMenu";
            NotifyIconMenu.Size = new Size(181, 48);
            // 
            // ExitApplicationToolStripMenuItem
            // 
            ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem";
            ExitApplicationToolStripMenuItem.Size = new Size(180, 22);
            ExitApplicationToolStripMenuItem.Text = "✖ Exit";
            ExitApplicationToolStripMenuItem.Click += ExitApplicationToolStripMenuItem_Click;
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
            Controls.Add(About_BTN);
            Controls.Add(Settings_BTN);
            Controls.Add(Services_BTN);
            Controls.Add(Dashboard_BTN);
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
            NotifyIconMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Top;
        private Button Minimized_BTN;
        private Button Close_BTN;
        private Panel panel_Border;
        private PictureBox pictureBox_Logo;
        private PictureBox pictureBox_TXT_Logo;
        private Panel panel_Bottom;
        private Panel panel_ProgressBar;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.Timer ResetProgressBarTimer;
        private Button Dashboard_BTN;
        private Button Services_BTN;
        private Button Settings_BTN;
        private Button About_BTN;
        private Label version_Lbl;
        private NotifyIcon MainNotifyIcon;
        private ContextMenuStrip NotifyIconMenu;
        private ToolStripMenuItem ExitApplicationToolStripMenuItem;
        private Panel panel_UserControl;
    }
}