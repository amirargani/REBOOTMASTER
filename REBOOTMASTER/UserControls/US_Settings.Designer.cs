namespace REBOOTMASTER.UserControls
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
            tabPage_Interruption = new TabPage();
            serviceOutages_CBox = new ComboBox();
            countingServiceOutages_Lbl = new Label();
            isStatus_CBox = new ComboBox();
            stoppedStatus_Lbl = new Label();
            isStatus_Lbl = new Label();
            autoRestarting_CBox = new ComboBox();
            autoRestarting_Lbl = new Label();
            autoChecking_CBox = new ComboBox();
            autoChecking_Lbl = new Label();
            tabPage_SMTP = new TabPage();
            email_TBox = new TextBox();
            pass_TBox = new TextBox();
            user_TBox = new TextBox();
            port_TBox = new TextBox();
            host_TBox = new TextBox();
            email_Lbl = new Label();
            pass_Lbl = new Label();
            host_Lbl = new Label();
            port_Lbl = new Label();
            user_Lbl = new Label();
            update_BTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
            tabControl_Settings.SuspendLayout();
            tabPage_Interruption.SuspendLayout();
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
            tabControl_Settings.Size = new Size(662, 336);
            tabControl_Settings.TabIndex = 36;
            tabControl_Settings.TabStop = false;
            // 
            // tabPage_Interruption
            // 
            tabPage_Interruption.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_Interruption.Controls.Add(serviceOutages_CBox);
            tabPage_Interruption.Controls.Add(countingServiceOutages_Lbl);
            tabPage_Interruption.Controls.Add(isStatus_CBox);
            tabPage_Interruption.Controls.Add(stoppedStatus_Lbl);
            tabPage_Interruption.Controls.Add(isStatus_Lbl);
            tabPage_Interruption.Controls.Add(autoRestarting_CBox);
            tabPage_Interruption.Controls.Add(autoRestarting_Lbl);
            tabPage_Interruption.Controls.Add(autoChecking_CBox);
            tabPage_Interruption.Controls.Add(autoChecking_Lbl);
            tabPage_Interruption.Location = new Point(4, 26);
            tabPage_Interruption.Name = "tabPage_Interruption";
            tabPage_Interruption.Padding = new Padding(3);
            tabPage_Interruption.Size = new Size(654, 306);
            tabPage_Interruption.TabIndex = 1;
            tabPage_Interruption.Text = "⏳Interruption";
            // 
            // serviceOutages_CBox
            // 
            serviceOutages_CBox.BackColor = Color.FromArgb(0, 8, 25);
            serviceOutages_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceOutages_CBox.Font = new Font("Nirmala UI", 8.25F);
            serviceOutages_CBox.ForeColor = Color.White;
            serviceOutages_CBox.FormattingEnabled = true;
            serviceOutages_CBox.Items.AddRange(new object[] { "3 service outages", "5 service outages", "10 service outages", "15 service outages", "20 service outages", "30 service outages", "60 service outages" });
            serviceOutages_CBox.Location = new Point(210, 115);
            serviceOutages_CBox.Name = "serviceOutages_CBox";
            serviceOutages_CBox.Size = new Size(134, 21);
            serviceOutages_CBox.TabIndex = 46;
            serviceOutages_CBox.TabStop = false;
            serviceOutages_CBox.Tag = "";
            serviceOutages_CBox.SelectedIndexChanged += serviceOutages_CBox_SelectedIndexChanged;
            // 
            // countingServiceOutages_Lbl
            // 
            countingServiceOutages_Lbl.AutoSize = true;
            countingServiceOutages_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            countingServiceOutages_Lbl.ForeColor = Color.White;
            countingServiceOutages_Lbl.Location = new Point(28, 115);
            countingServiceOutages_Lbl.Name = "countingServiceOutages_Lbl";
            countingServiceOutages_Lbl.Size = new Size(172, 17);
            countingServiceOutages_Lbl.TabIndex = 45;
            countingServiceOutages_Lbl.Text = "Counting Service Outages:";
            // 
            // isStatus_CBox
            // 
            isStatus_CBox.BackColor = Color.FromArgb(0, 8, 25);
            isStatus_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            isStatus_CBox.Font = new Font("Nirmala UI", 8.25F);
            isStatus_CBox.ForeColor = Color.White;
            isStatus_CBox.FormattingEnabled = true;
            isStatus_CBox.Items.AddRange(new object[] { "3 minutes", "5 minutes", "10 minutes", "15 minutes", "20 minutes", "30 minutes", "60 minutes" });
            isStatus_CBox.Location = new Point(210, 82);
            isStatus_CBox.Name = "isStatus_CBox";
            isStatus_CBox.Size = new Size(134, 21);
            isStatus_CBox.TabIndex = 44;
            isStatus_CBox.TabStop = false;
            isStatus_CBox.Tag = "";
            isStatus_CBox.SelectedIndexChanged += isStatus_CBox_SelectedIndexChanged;
            // 
            // stoppedStatus_Lbl
            // 
            stoppedStatus_Lbl.AutoSize = true;
            stoppedStatus_Lbl.BackColor = Color.Maroon;
            stoppedStatus_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stoppedStatus_Lbl.ForeColor = Color.White;
            stoppedStatus_Lbl.Location = new Point(93, 86);
            stoppedStatus_Lbl.Name = "stoppedStatus_Lbl";
            stoppedStatus_Lbl.Size = new Size(59, 17);
            stoppedStatus_Lbl.TabIndex = 43;
            stoppedStatus_Lbl.Text = "Stopped";
            // 
            // isStatus_Lbl
            // 
            isStatus_Lbl.AutoSize = true;
            isStatus_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            isStatus_Lbl.ForeColor = Color.White;
            isStatus_Lbl.Location = new Point(28, 86);
            isStatus_Lbl.Name = "isStatus_Lbl";
            isStatus_Lbl.Size = new Size(64, 17);
            isStatus_Lbl.TabIndex = 43;
            isStatus_Lbl.Text = "Is Status:";
            // 
            // autoRestarting_CBox
            // 
            autoRestarting_CBox.BackColor = Color.FromArgb(0, 8, 25);
            autoRestarting_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            autoRestarting_CBox.Font = new Font("Nirmala UI", 8.25F);
            autoRestarting_CBox.ForeColor = Color.White;
            autoRestarting_CBox.FormattingEnabled = true;
            autoRestarting_CBox.Items.AddRange(new object[] { "120 seconds", "180 seconds", "240 seconds", "300 seconds", "420 seconds" });
            autoRestarting_CBox.Location = new Point(210, 51);
            autoRestarting_CBox.Name = "autoRestarting_CBox";
            autoRestarting_CBox.Size = new Size(134, 21);
            autoRestarting_CBox.TabIndex = 42;
            autoRestarting_CBox.TabStop = false;
            autoRestarting_CBox.Tag = "";
            autoRestarting_CBox.SelectedIndexChanged += autoRestarting_CBox_SelectedIndexChanged;
            // 
            // autoRestarting_Lbl
            // 
            autoRestarting_Lbl.AutoSize = true;
            autoRestarting_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            autoRestarting_Lbl.ForeColor = Color.White;
            autoRestarting_Lbl.Location = new Point(28, 55);
            autoRestarting_Lbl.Name = "autoRestarting_Lbl";
            autoRestarting_Lbl.Size = new Size(110, 17);
            autoRestarting_Lbl.TabIndex = 41;
            autoRestarting_Lbl.Text = "Auto-Restarting:";
            // 
            // autoChecking_CBox
            // 
            autoChecking_CBox.BackColor = Color.FromArgb(0, 8, 25);
            autoChecking_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            autoChecking_CBox.Font = new Font("Nirmala UI", 8.25F);
            autoChecking_CBox.ForeColor = Color.White;
            autoChecking_CBox.FormattingEnabled = true;
            autoChecking_CBox.Items.AddRange(new object[] { "10 seconds", "30 seconds", "60 seconds", "90 seconds" });
            autoChecking_CBox.Location = new Point(210, 20);
            autoChecking_CBox.Name = "autoChecking_CBox";
            autoChecking_CBox.Size = new Size(134, 21);
            autoChecking_CBox.TabIndex = 40;
            autoChecking_CBox.TabStop = false;
            autoChecking_CBox.Tag = "";
            autoChecking_CBox.SelectedIndexChanged += autoChecking_CBox_SelectedIndexChanged;
            // 
            // autoChecking_Lbl
            // 
            autoChecking_Lbl.AutoSize = true;
            autoChecking_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            autoChecking_Lbl.ForeColor = Color.White;
            autoChecking_Lbl.Location = new Point(28, 23);
            autoChecking_Lbl.Name = "autoChecking_Lbl";
            autoChecking_Lbl.Size = new Size(103, 17);
            autoChecking_Lbl.TabIndex = 39;
            autoChecking_Lbl.Text = "Auto-Checking:";
            // 
            // tabPage_SMTP
            // 
            tabPage_SMTP.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_SMTP.Controls.Add(email_TBox);
            tabPage_SMTP.Controls.Add(pass_TBox);
            tabPage_SMTP.Controls.Add(user_TBox);
            tabPage_SMTP.Controls.Add(port_TBox);
            tabPage_SMTP.Controls.Add(host_TBox);
            tabPage_SMTP.Controls.Add(email_Lbl);
            tabPage_SMTP.Controls.Add(pass_Lbl);
            tabPage_SMTP.Controls.Add(host_Lbl);
            tabPage_SMTP.Controls.Add(port_Lbl);
            tabPage_SMTP.Controls.Add(user_Lbl);
            tabPage_SMTP.Location = new Point(4, 26);
            tabPage_SMTP.Name = "tabPage_SMTP";
            tabPage_SMTP.Padding = new Padding(3);
            tabPage_SMTP.Size = new Size(654, 306);
            tabPage_SMTP.TabIndex = 0;
            tabPage_SMTP.Text = "📜SMTP Configuration";
            // 
            // email_TBox
            // 
            email_TBox.BackColor = Color.FromArgb(0, 8, 25);
            email_TBox.ForeColor = Color.White;
            email_TBox.Location = new Point(198, 145);
            email_TBox.Name = "email_TBox";
            email_TBox.PlaceholderText = "devmail@example.com";
            email_TBox.Size = new Size(292, 25);
            email_TBox.TabIndex = 45;
            email_TBox.TabStop = false;
            email_TBox.TextAlign = HorizontalAlignment.Center;
            // 
            // pass_TBox
            // 
            pass_TBox.BackColor = Color.FromArgb(0, 8, 25);
            pass_TBox.ForeColor = Color.White;
            pass_TBox.Location = new Point(198, 114);
            pass_TBox.Name = "pass_TBox";
            pass_TBox.PasswordChar = '*';
            pass_TBox.PlaceholderText = "****************";
            pass_TBox.Size = new Size(292, 25);
            pass_TBox.TabIndex = 44;
            pass_TBox.TabStop = false;
            pass_TBox.TextAlign = HorizontalAlignment.Center;
            // 
            // user_TBox
            // 
            user_TBox.BackColor = Color.FromArgb(0, 8, 25);
            user_TBox.ForeColor = Color.White;
            user_TBox.Location = new Point(198, 83);
            user_TBox.Name = "user_TBox";
            user_TBox.PlaceholderText = "smtpusermail@example.com";
            user_TBox.Size = new Size(292, 25);
            user_TBox.TabIndex = 43;
            user_TBox.TabStop = false;
            user_TBox.TextAlign = HorizontalAlignment.Center;
            // 
            // port_TBox
            // 
            port_TBox.BackColor = Color.FromArgb(0, 8, 25);
            port_TBox.ForeColor = Color.White;
            port_TBox.Location = new Point(198, 51);
            port_TBox.Name = "port_TBox";
            port_TBox.PlaceholderText = "587";
            port_TBox.Size = new Size(292, 25);
            port_TBox.TabIndex = 42;
            port_TBox.TabStop = false;
            port_TBox.TextAlign = HorizontalAlignment.Center;
            // 
            // host_TBox
            // 
            host_TBox.BackColor = Color.FromArgb(0, 8, 25);
            host_TBox.ForeColor = Color.White;
            host_TBox.Location = new Point(198, 20);
            host_TBox.Name = "host_TBox";
            host_TBox.PlaceholderText = "smtp.example.com";
            host_TBox.Size = new Size(292, 25);
            host_TBox.TabIndex = 41;
            host_TBox.TabStop = false;
            host_TBox.TextAlign = HorizontalAlignment.Center;
            // 
            // email_Lbl
            // 
            email_Lbl.AutoSize = true;
            email_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            email_Lbl.ForeColor = Color.White;
            email_Lbl.Location = new Point(28, 148);
            email_Lbl.Name = "email_Lbl";
            email_Lbl.Size = new Size(107, 17);
            email_Lbl.TabIndex = 40;
            email_Lbl.Text = "Recipient Email:";
            // 
            // pass_Lbl
            // 
            pass_Lbl.AutoSize = true;
            pass_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            pass_Lbl.ForeColor = Color.White;
            pass_Lbl.Location = new Point(28, 117);
            pass_Lbl.Name = "pass_Lbl";
            pass_Lbl.Size = new Size(70, 17);
            pass_Lbl.TabIndex = 39;
            pass_Lbl.Text = "Password:";
            // 
            // host_Lbl
            // 
            host_Lbl.AutoSize = true;
            host_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            host_Lbl.ForeColor = Color.White;
            host_Lbl.Location = new Point(28, 23);
            host_Lbl.Name = "host_Lbl";
            host_Lbl.Size = new Size(41, 17);
            host_Lbl.TabIndex = 38;
            host_Lbl.Text = "Host:";
            // 
            // port_Lbl
            // 
            port_Lbl.AutoSize = true;
            port_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            port_Lbl.ForeColor = Color.White;
            port_Lbl.Location = new Point(28, 55);
            port_Lbl.Name = "port_Lbl";
            port_Lbl.Size = new Size(38, 17);
            port_Lbl.TabIndex = 37;
            port_Lbl.Text = "Port:";
            // 
            // user_Lbl
            // 
            user_Lbl.AutoSize = true;
            user_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            user_Lbl.ForeColor = Color.White;
            user_Lbl.Location = new Point(28, 86);
            user_Lbl.Name = "user_Lbl";
            user_Lbl.Size = new Size(40, 17);
            user_Lbl.TabIndex = 36;
            user_Lbl.Text = "User:";
            // 
            // update_BTN
            // 
            update_BTN.BackColor = Color.FromArgb(0, 8, 33);
            update_BTN.FlatAppearance.BorderSize = 0;
            update_BTN.FlatStyle = FlatStyle.Flat;
            update_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            update_BTN.ForeColor = Color.White;
            update_BTN.Location = new Point(33, 355);
            update_BTN.Name = "update_BTN";
            update_BTN.Size = new Size(662, 44);
            update_BTN.TabIndex = 37;
            update_BTN.TabStop = false;
            update_BTN.Text = "📥 Update";
            update_BTN.UseVisualStyleBackColor = false;
            update_BTN.Click += update_BTN_Click;
            // 
            // US_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(update_BTN);
            Controls.Add(tabControl_Settings);
            Controls.Add(pictureBox_Arrow);
            Name = "US_Settings";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            tabControl_Settings.ResumeLayout(false);
            tabPage_Interruption.ResumeLayout(false);
            tabPage_Interruption.PerformLayout();
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
        private TextBox host_TBox;
        private TextBox port_TBox;
        private TextBox email_TBox;
        private TextBox pass_TBox;
        private TextBox user_TBox;
        private ComboBox autoChecking_CBox;
        private Label autoChecking_Lbl;
        private Label autoRestarting_Lbl;
        private ComboBox autoRestarting_CBox;
        private Label isStatus_Lbl;
        private ComboBox isStatus_CBox;
        private Label stoppedStatus_Lbl;
        private Label countingServiceOutages_Lbl;
        private ComboBox serviceOutages_CBox;
        private Button update_BTN;
    }
}