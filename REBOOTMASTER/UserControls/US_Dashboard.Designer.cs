namespace REBOOTMASTER.UserControls
{
    partial class US_Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Dashboard));
            pictureBox_Arrow = new PictureBox();
            Stop_BTN = new Button();
            Start_BTN = new Button();
            sermonitoring_panel = new Panel();
            sermonitoringcount_lbl = new Label();
            sermonitoringsubtitle_Lbl = new Label();
            sermonitoring_Lbl = new Label();
            autorestartser_panel = new Panel();
            autorestartsercount_Lbl = new Label();
            autorestartsersubtitle_Lbl = new Label();
            autorestartser_Lbl = new Label();
            inactiveser_panel = new Panel();
            inactivesercount_Lbl = new Label();
            inactivesersubtitle_Lbl = new Label();
            inactiveser_Lbl = new Label();
            unexpectedfailures_panel = new Panel();
            unexpectedfailurescount_Lbl = new Label();
            unexpectedfailuressubtitle_Lbl = new Label();
            unexpectedfailures_Lbl = new Label();
            livelog_panel = new Panel();
            log_Lbl = new Label();
            livelogsubtitle_Lbl = new Label();
            livelog_Lbl = new Label();
            AutoCheckServiceTimer = new System.Windows.Forms.Timer(components);
            TimerWhenServiceStopped = new System.Windows.Forms.Timer(components);
            btns_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
            sermonitoring_panel.SuspendLayout();
            autorestartser_panel.SuspendLayout();
            inactiveser_panel.SuspendLayout();
            unexpectedfailures_panel.SuspendLayout();
            livelog_panel.SuspendLayout();
            btns_panel.SuspendLayout();
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
            // Stop_BTN
            // 
            Stop_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Stop_BTN.Enabled = false;
            Stop_BTN.FlatAppearance.BorderSize = 0;
            Stop_BTN.FlatStyle = FlatStyle.Flat;
            Stop_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Stop_BTN.ForeColor = Color.White;
            Stop_BTN.Location = new Point(7, 103);
            Stop_BTN.Name = "Stop_BTN";
            Stop_BTN.Size = new Size(37, 88);
            Stop_BTN.TabIndex = 44;
            Stop_BTN.TabStop = false;
            Stop_BTN.Text = "⛔";
            Stop_BTN.UseVisualStyleBackColor = false;
            Stop_BTN.Click += Stop_BTN_Click;
            // 
            // Start_BTN
            // 
            Start_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Start_BTN.FlatAppearance.BorderSize = 0;
            Start_BTN.FlatStyle = FlatStyle.Flat;
            Start_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Start_BTN.ForeColor = Color.White;
            Start_BTN.Location = new Point(7, 9);
            Start_BTN.Name = "Start_BTN";
            Start_BTN.Size = new Size(37, 88);
            Start_BTN.TabIndex = 43;
            Start_BTN.TabStop = false;
            Start_BTN.Text = "🚀";
            Start_BTN.UseVisualStyleBackColor = false;
            Start_BTN.Click += Start_BTN_Click;
            // 
            // sermonitoring_panel
            // 
            sermonitoring_panel.BackColor = Color.FromArgb(15, 23, 42);
            sermonitoring_panel.BorderStyle = BorderStyle.FixedSingle;
            sermonitoring_panel.Controls.Add(sermonitoringcount_lbl);
            sermonitoring_panel.Controls.Add(sermonitoringsubtitle_Lbl);
            sermonitoring_panel.Controls.Add(sermonitoring_Lbl);
            sermonitoring_panel.Location = new Point(91, 18);
            sermonitoring_panel.Name = "sermonitoring_panel";
            sermonitoring_panel.Size = new Size(298, 98);
            sermonitoring_panel.TabIndex = 45;
            // 
            // sermonitoringcount_lbl
            // 
            sermonitoringcount_lbl.AutoSize = true;
            sermonitoringcount_lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sermonitoringcount_lbl.ForeColor = Color.Silver;
            sermonitoringcount_lbl.Location = new Point(133, 52);
            sermonitoringcount_lbl.Name = "sermonitoringcount_lbl";
            sermonitoringcount_lbl.Size = new Size(32, 37);
            sermonitoringcount_lbl.TabIndex = 46;
            sermonitoringcount_lbl.Text = "0";
            // 
            // sermonitoringsubtitle_Lbl
            // 
            sermonitoringsubtitle_Lbl.AutoSize = true;
            sermonitoringsubtitle_Lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sermonitoringsubtitle_Lbl.ForeColor = Color.LightGray;
            sermonitoringsubtitle_Lbl.Location = new Point(71, 40);
            sermonitoringsubtitle_Lbl.Name = "sermonitoringsubtitle_Lbl";
            sermonitoringsubtitle_Lbl.Size = new Size(156, 13);
            sermonitoringsubtitle_Lbl.TabIndex = 46;
            sermonitoringsubtitle_Lbl.Text = "Currently monitored services.";
            // 
            // sermonitoring_Lbl
            // 
            sermonitoring_Lbl.AutoSize = true;
            sermonitoring_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sermonitoring_Lbl.ForeColor = Color.White;
            sermonitoring_Lbl.Location = new Point(43, 9);
            sermonitoring_Lbl.Name = "sermonitoring_Lbl";
            sermonitoring_Lbl.Size = new Size(212, 25);
            sermonitoring_Lbl.TabIndex = 46;
            sermonitoring_Lbl.Text = "📦 Monitored Services";
            // 
            // autorestartser_panel
            // 
            autorestartser_panel.BackColor = Color.FromArgb(15, 23, 42);
            autorestartser_panel.BorderStyle = BorderStyle.FixedSingle;
            autorestartser_panel.Controls.Add(autorestartsercount_Lbl);
            autorestartser_panel.Controls.Add(autorestartsersubtitle_Lbl);
            autorestartser_panel.Controls.Add(autorestartser_Lbl);
            autorestartser_panel.Location = new Point(91, 122);
            autorestartser_panel.Name = "autorestartser_panel";
            autorestartser_panel.Size = new Size(298, 98);
            autorestartser_panel.TabIndex = 47;
            // 
            // autorestartsercount_Lbl
            // 
            autorestartsercount_Lbl.AutoSize = true;
            autorestartsercount_Lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autorestartsercount_Lbl.ForeColor = Color.Silver;
            autorestartsercount_Lbl.Location = new Point(133, 52);
            autorestartsercount_Lbl.Name = "autorestartsercount_Lbl";
            autorestartsercount_Lbl.Size = new Size(32, 37);
            autorestartsercount_Lbl.TabIndex = 46;
            autorestartsercount_Lbl.Text = "0";
            // 
            // autorestartsersubtitle_Lbl
            // 
            autorestartsersubtitle_Lbl.AutoSize = true;
            autorestartsersubtitle_Lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autorestartsersubtitle_Lbl.ForeColor = Color.LightGray;
            autorestartsersubtitle_Lbl.Location = new Point(35, 40);
            autorestartsersubtitle_Lbl.Name = "autorestartsersubtitle_Lbl";
            autorestartsersubtitle_Lbl.Size = new Size(227, 13);
            autorestartsersubtitle_Lbl.TabIndex = 46;
            autorestartsersubtitle_Lbl.Text = "Number of services that are auto-restarted.";
            // 
            // autorestartser_Lbl
            // 
            autorestartser_Lbl.AutoSize = true;
            autorestartser_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autorestartser_Lbl.ForeColor = Color.White;
            autorestartser_Lbl.Location = new Point(24, 9);
            autorestartser_Lbl.Name = "autorestartser_Lbl";
            autorestartser_Lbl.Size = new Size(250, 25);
            autorestartser_Lbl.TabIndex = 46;
            autorestartser_Lbl.Text = "🔥 Auto Restarted Services";
            // 
            // inactiveser_panel
            // 
            inactiveser_panel.BackColor = Color.FromArgb(15, 23, 42);
            inactiveser_panel.BorderStyle = BorderStyle.FixedSingle;
            inactiveser_panel.Controls.Add(inactivesercount_Lbl);
            inactiveser_panel.Controls.Add(inactivesersubtitle_Lbl);
            inactiveser_panel.Controls.Add(inactiveser_Lbl);
            inactiveser_panel.Location = new Point(395, 122);
            inactiveser_panel.Name = "inactiveser_panel";
            inactiveser_panel.Size = new Size(298, 98);
            inactiveser_panel.TabIndex = 48;
            // 
            // inactivesercount_Lbl
            // 
            inactivesercount_Lbl.AutoSize = true;
            inactivesercount_Lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inactivesercount_Lbl.ForeColor = Color.Silver;
            inactivesercount_Lbl.Location = new Point(133, 52);
            inactivesercount_Lbl.Name = "inactivesercount_Lbl";
            inactivesercount_Lbl.Size = new Size(32, 37);
            inactivesercount_Lbl.TabIndex = 46;
            inactivesercount_Lbl.Text = "0";
            // 
            // inactivesersubtitle_Lbl
            // 
            inactivesersubtitle_Lbl.AutoSize = true;
            inactivesersubtitle_Lbl.Font = new Font("Segoe UI", 8.25F);
            inactivesersubtitle_Lbl.ForeColor = Color.LightGray;
            inactivesersubtitle_Lbl.Location = new Point(45, 40);
            inactivesersubtitle_Lbl.Name = "inactivesersubtitle_Lbl";
            inactivesersubtitle_Lbl.Size = new Size(208, 13);
            inactivesersubtitle_Lbl.TabIndex = 46;
            inactivesersubtitle_Lbl.Text = "Tracking the status of stopped services.";
            // 
            // inactiveser_Lbl
            // 
            inactiveser_Lbl.AutoSize = true;
            inactiveser_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            inactiveser_Lbl.ForeColor = Color.White;
            inactiveser_Lbl.Location = new Point(9, 9);
            inactiveser_Lbl.Name = "inactiveser_Lbl";
            inactiveser_Lbl.Size = new Size(277, 25);
            inactiveser_Lbl.TabIndex = 46;
            inactiveser_Lbl.Text = "Count of All Stopped Services";
            // 
            // unexpectedfailures_panel
            // 
            unexpectedfailures_panel.BackColor = Color.FromArgb(15, 23, 42);
            unexpectedfailures_panel.BorderStyle = BorderStyle.FixedSingle;
            unexpectedfailures_panel.Controls.Add(unexpectedfailurescount_Lbl);
            unexpectedfailures_panel.Controls.Add(unexpectedfailuressubtitle_Lbl);
            unexpectedfailures_panel.Controls.Add(unexpectedfailures_Lbl);
            unexpectedfailures_panel.Location = new Point(395, 18);
            unexpectedfailures_panel.Name = "unexpectedfailures_panel";
            unexpectedfailures_panel.Size = new Size(298, 98);
            unexpectedfailures_panel.TabIndex = 47;
            // 
            // unexpectedfailurescount_Lbl
            // 
            unexpectedfailurescount_Lbl.AutoSize = true;
            unexpectedfailurescount_Lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unexpectedfailurescount_Lbl.ForeColor = Color.Silver;
            unexpectedfailurescount_Lbl.Location = new Point(133, 52);
            unexpectedfailurescount_Lbl.Name = "unexpectedfailurescount_Lbl";
            unexpectedfailurescount_Lbl.Size = new Size(32, 37);
            unexpectedfailurescount_Lbl.TabIndex = 46;
            unexpectedfailurescount_Lbl.Text = "0";
            // 
            // unexpectedfailuressubtitle_Lbl
            // 
            unexpectedfailuressubtitle_Lbl.AutoSize = true;
            unexpectedfailuressubtitle_Lbl.Font = new Font("Segoe UI", 8.25F);
            unexpectedfailuressubtitle_Lbl.ForeColor = Color.LightGray;
            unexpectedfailuressubtitle_Lbl.Location = new Point(31, 40);
            unexpectedfailuressubtitle_Lbl.Name = "unexpectedfailuressubtitle_Lbl";
            unexpectedfailuressubtitle_Lbl.Size = new Size(236, 13);
            unexpectedfailuressubtitle_Lbl.TabIndex = 46;
            unexpectedfailuressubtitle_Lbl.Text = "Total number of unexpected system outages.";
            // 
            // unexpectedfailures_Lbl
            // 
            unexpectedfailures_Lbl.AutoSize = true;
            unexpectedfailures_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            unexpectedfailures_Lbl.ForeColor = Color.White;
            unexpectedfailures_Lbl.Location = new Point(6, 9);
            unexpectedfailures_Lbl.Name = "unexpectedfailures_Lbl";
            unexpectedfailures_Lbl.Size = new Size(286, 25);
            unexpectedfailures_Lbl.TabIndex = 46;
            unexpectedfailures_Lbl.Text = "💥 Unexpected System Failures";
            // 
            // livelog_panel
            // 
            livelog_panel.BackColor = Color.FromArgb(15, 23, 42);
            livelog_panel.BorderStyle = BorderStyle.FixedSingle;
            livelog_panel.Controls.Add(log_Lbl);
            livelog_panel.Controls.Add(livelogsubtitle_Lbl);
            livelog_panel.Controls.Add(livelog_Lbl);
            livelog_panel.Location = new Point(33, 230);
            livelog_panel.Name = "livelog_panel";
            livelog_panel.Size = new Size(660, 207);
            livelog_panel.TabIndex = 49;
            // 
            // log_Lbl
            // 
            log_Lbl.AutoSize = true;
            log_Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_Lbl.ForeColor = Color.White;
            log_Lbl.Location = new Point(5, 67);
            log_Lbl.Name = "log_Lbl";
            log_Lbl.Size = new Size(0, 15);
            log_Lbl.TabIndex = 47;
            // 
            // livelogsubtitle_Lbl
            // 
            livelogsubtitle_Lbl.AutoSize = true;
            livelogsubtitle_Lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            livelogsubtitle_Lbl.ForeColor = Color.LightGray;
            livelogsubtitle_Lbl.Location = new Point(183, 40);
            livelogsubtitle_Lbl.Name = "livelogsubtitle_Lbl";
            livelogsubtitle_Lbl.Size = new Size(293, 13);
            livelogsubtitle_Lbl.TabIndex = 46;
            livelogsubtitle_Lbl.Text = "Monitor system services as they run, with real-time logs.";
            // 
            // livelog_Lbl
            // 
            livelog_Lbl.AutoSize = true;
            livelog_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            livelog_Lbl.ForeColor = Color.White;
            livelog_Lbl.Location = new Point(190, 9);
            livelog_Lbl.Name = "livelog_Lbl";
            livelog_Lbl.Size = new Size(280, 25);
            livelog_Lbl.TabIndex = 46;
            livelog_Lbl.Text = "📝 Real-time log of all services";
            // 
            // AutoCheckServiceTimer
            // 
            AutoCheckServiceTimer.Interval = 30000;
            AutoCheckServiceTimer.Tick += AutoCheckServiceTimer_Tick;
            // 
            // TimerWhenServiceStopped
            // 
            TimerWhenServiceStopped.Interval = 600000;
            TimerWhenServiceStopped.Tick += TimerWhenServiceStopped_Tick;
            // 
            // btns_panel
            // 
            btns_panel.BackColor = Color.FromArgb(15, 23, 42);
            btns_panel.BorderStyle = BorderStyle.FixedSingle;
            btns_panel.Controls.Add(Start_BTN);
            btns_panel.Controls.Add(Stop_BTN);
            btns_panel.Location = new Point(33, 18);
            btns_panel.Name = "btns_panel";
            btns_panel.Size = new Size(52, 202);
            btns_panel.TabIndex = 50;
            // 
            // US_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(btns_panel);
            Controls.Add(livelog_panel);
            Controls.Add(unexpectedfailures_panel);
            Controls.Add(inactiveser_panel);
            Controls.Add(autorestartser_panel);
            Controls.Add(sermonitoring_panel);
            Controls.Add(pictureBox_Arrow);
            Name = "US_Dashboard";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            sermonitoring_panel.ResumeLayout(false);
            sermonitoring_panel.PerformLayout();
            autorestartser_panel.ResumeLayout(false);
            autorestartser_panel.PerformLayout();
            inactiveser_panel.ResumeLayout(false);
            inactiveser_panel.PerformLayout();
            unexpectedfailures_panel.ResumeLayout(false);
            unexpectedfailures_panel.PerformLayout();
            livelog_panel.ResumeLayout(false);
            livelog_panel.PerformLayout();
            btns_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox_Arrow;
        private Button Stop_BTN;
        private Button Start_BTN;
        private Panel sermonitoring_panel;
        private Label sermonitoringcount_lbl;
        private Label sermonitoringsubtitle_Lbl;
        private Label sermonitoring_Lbl;
        private Panel autorestartser_panel;
        private Label autorestartsercount_Lbl;
        private Label autorestartsersubtitle_Lbl;
        private Label autorestartser_Lbl;
        private Panel inactiveser_panel;
        private Label inactivesercount_Lbl;
        private Label inactivesersubtitle_Lbl;
        private Label inactiveser_Lbl;
        private Panel unexpectedfailures_panel;
        private Label unexpectedfailurescount_Lbl;
        private Label unexpectedfailuressubtitle_Lbl;
        private Label unexpectedfailures_Lbl;
        private Panel livelog_panel;
        private Label livelogsubtitle_Lbl;
        private Label livelog_Lbl;
        private System.Windows.Forms.Timer AutoCheckServiceTimer;
        private System.Windows.Forms.Timer TimerWhenServiceStopped;
        private Label log_Lbl;
        private Panel btns_panel;
    }
}