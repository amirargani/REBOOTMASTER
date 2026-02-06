namespace REBOOTMASTER.UserControls
{
    partial class US_Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Services));
            pictureBox_Arrow = new PictureBox();
            Update_BTN = new Button();
            tabControl_Services = new TabControl();
            tabPage_Services = new TabPage();
            autoRestarting_CHBox = new CheckBox();
            serdescription_richTextBox = new RichTextBox();
            description_Lbl = new Label();
            serstatus_Lbl = new Label();
            sername_Lbl = new Label();
            sstatus_Lbl = new Label();
            service_Lbl = new Label();
            Service_CBox = new ComboBox();
            disname_Lbl = new Label();
            Myser_Rad = new RadioButton();
            Services_Rad = new RadioButton();
            Services_CHBox = new CheckBox();
            added_Lbl = new Label();
            Delete_BTN = new Button();
            Start_BTN = new Button();
            Stop_BTN = new Button();
            Restart_BTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
            tabControl_Services.SuspendLayout();
            tabPage_Services.SuspendLayout();
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
            // Update_BTN
            // 
            Update_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Update_BTN.Enabled = false;
            Update_BTN.FlatAppearance.BorderSize = 0;
            Update_BTN.FlatStyle = FlatStyle.Flat;
            Update_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Update_BTN.ForeColor = Color.White;
            Update_BTN.Location = new Point(32, 355);
            Update_BTN.Name = "Update_BTN";
            Update_BTN.Size = new Size(228, 44);
            Update_BTN.TabIndex = 39;
            Update_BTN.TabStop = false;
            Update_BTN.Text = "▶ Add or Update Service in List";
            Update_BTN.UseVisualStyleBackColor = false;
            Update_BTN.Click += Update_BTN_Click;
            // 
            // tabControl_Services
            // 
            tabControl_Services.Controls.Add(tabPage_Services);
            tabControl_Services.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            tabControl_Services.Location = new Point(33, 13);
            tabControl_Services.Name = "tabControl_Services";
            tabControl_Services.SelectedIndex = 0;
            tabControl_Services.Size = new Size(662, 336);
            tabControl_Services.TabIndex = 38;
            tabControl_Services.TabStop = false;
            // 
            // tabPage_Services
            // 
            tabPage_Services.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_Services.Controls.Add(autoRestarting_CHBox);
            tabPage_Services.Controls.Add(serdescription_richTextBox);
            tabPage_Services.Controls.Add(description_Lbl);
            tabPage_Services.Controls.Add(serstatus_Lbl);
            tabPage_Services.Controls.Add(sername_Lbl);
            tabPage_Services.Controls.Add(sstatus_Lbl);
            tabPage_Services.Controls.Add(service_Lbl);
            tabPage_Services.Controls.Add(Service_CBox);
            tabPage_Services.Controls.Add(disname_Lbl);
            tabPage_Services.Location = new Point(4, 26);
            tabPage_Services.Name = "tabPage_Services";
            tabPage_Services.Padding = new Padding(3);
            tabPage_Services.Size = new Size(654, 306);
            tabPage_Services.TabIndex = 1;
            tabPage_Services.Text = "📦 Services";
            // 
            // autoRestarting_CHBox
            // 
            autoRestarting_CHBox.AutoSize = true;
            autoRestarting_CHBox.ForeColor = Color.White;
            autoRestarting_CHBox.Location = new Point(28, 144);
            autoRestarting_CHBox.Name = "autoRestarting_CHBox";
            autoRestarting_CHBox.Size = new Size(164, 21);
            autoRestarting_CHBox.TabIndex = 51;
            autoRestarting_CHBox.TabStop = false;
            autoRestarting_CHBox.Text = "Restart automatically?";
            autoRestarting_CHBox.UseVisualStyleBackColor = true;
            // 
            // serdescription_richTextBox
            // 
            serdescription_richTextBox.BackColor = Color.FromArgb(0, 8, 25);
            serdescription_richTextBox.BorderStyle = BorderStyle.None;
            serdescription_richTextBox.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            serdescription_richTextBox.ForeColor = Color.White;
            serdescription_richTextBox.Location = new Point(212, 115);
            serdescription_richTextBox.Name = "serdescription_richTextBox";
            serdescription_richTextBox.ReadOnly = true;
            serdescription_richTextBox.ScrollBars = RichTextBoxScrollBars.None;
            serdescription_richTextBox.Size = new Size(422, 83);
            serdescription_richTextBox.TabIndex = 50;
            serdescription_richTextBox.TabStop = false;
            serdescription_richTextBox.Text = "-";
            // 
            // description_Lbl
            // 
            description_Lbl.AutoSize = true;
            description_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            description_Lbl.ForeColor = Color.White;
            description_Lbl.Location = new Point(28, 115);
            description_Lbl.Name = "description_Lbl";
            description_Lbl.Size = new Size(131, 17);
            description_Lbl.TabIndex = 48;
            description_Lbl.Text = "Service Description:";
            // 
            // serstatus_Lbl
            // 
            serstatus_Lbl.AutoSize = true;
            serstatus_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            serstatus_Lbl.ForeColor = Color.White;
            serstatus_Lbl.Location = new Point(210, 89);
            serstatus_Lbl.Name = "serstatus_Lbl";
            serstatus_Lbl.Size = new Size(13, 17);
            serstatus_Lbl.TabIndex = 47;
            serstatus_Lbl.Text = "-";
            // 
            // sername_Lbl
            // 
            sername_Lbl.AutoSize = true;
            sername_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            sername_Lbl.ForeColor = Color.White;
            sername_Lbl.Location = new Point(210, 55);
            sername_Lbl.Name = "sername_Lbl";
            sername_Lbl.Size = new Size(13, 17);
            sername_Lbl.TabIndex = 46;
            sername_Lbl.Text = "-";
            // 
            // sstatus_Lbl
            // 
            sstatus_Lbl.AutoSize = true;
            sstatus_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            sstatus_Lbl.ForeColor = Color.White;
            sstatus_Lbl.Location = new Point(28, 86);
            sstatus_Lbl.Name = "sstatus_Lbl";
            sstatus_Lbl.Size = new Size(98, 17);
            sstatus_Lbl.TabIndex = 45;
            sstatus_Lbl.Text = "Service Status:";
            // 
            // service_Lbl
            // 
            service_Lbl.AutoSize = true;
            service_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            service_Lbl.ForeColor = Color.White;
            service_Lbl.Location = new Point(28, 55);
            service_Lbl.Name = "service_Lbl";
            service_Lbl.Size = new Size(96, 17);
            service_Lbl.TabIndex = 44;
            service_Lbl.Text = "Service Name:";
            // 
            // Service_CBox
            // 
            Service_CBox.BackColor = Color.FromArgb(0, 8, 25);
            Service_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Service_CBox.Font = new Font("Nirmala UI", 8.25F);
            Service_CBox.ForeColor = Color.White;
            Service_CBox.FormattingEnabled = true;
            Service_CBox.Location = new Point(210, 20);
            Service_CBox.Name = "Service_CBox";
            Service_CBox.Size = new Size(438, 21);
            Service_CBox.TabIndex = 42;
            Service_CBox.TabStop = false;
            Service_CBox.Tag = "";
            Service_CBox.SelectedIndexChanged += Service_CBox_SelectedIndexChanged;
            // 
            // disname_Lbl
            // 
            disname_Lbl.AutoSize = true;
            disname_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            disname_Lbl.ForeColor = Color.White;
            disname_Lbl.Location = new Point(28, 23);
            disname_Lbl.Name = "disname_Lbl";
            disname_Lbl.Size = new Size(98, 17);
            disname_Lbl.TabIndex = 41;
            disname_Lbl.Text = "Display Name:";
            // 
            // Myser_Rad
            // 
            Myser_Rad.AutoSize = true;
            Myser_Rad.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Myser_Rad.ForeColor = Color.White;
            Myser_Rad.Location = new Point(699, 81);
            Myser_Rad.Name = "Myser_Rad";
            Myser_Rad.Size = new Size(103, 16);
            Myser_Rad.TabIndex = 53;
            Myser_Rad.Text = "My Active Services";
            Myser_Rad.UseVisualStyleBackColor = true;
            Myser_Rad.CheckedChanged += Myser_Rad_CheckedChanged;
            // 
            // Services_Rad
            // 
            Services_Rad.AutoSize = true;
            Services_Rad.Checked = true;
            Services_Rad.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold);
            Services_Rad.ForeColor = Color.White;
            Services_Rad.Location = new Point(699, 41);
            Services_Rad.Name = "Services_Rad";
            Services_Rad.Size = new Size(72, 16);
            Services_Rad.TabIndex = 52;
            Services_Rad.TabStop = true;
            Services_Rad.Text = "All Services";
            Services_Rad.UseVisualStyleBackColor = true;
            Services_Rad.CheckedChanged += Services_Rad_CheckedChanged;
            // 
            // Services_CHBox
            // 
            Services_CHBox.AutoSize = true;
            Services_CHBox.Checked = true;
            Services_CHBox.CheckState = CheckState.Checked;
            Services_CHBox.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Services_CHBox.ForeColor = Color.White;
            Services_CHBox.Location = new Point(699, 61);
            Services_CHBox.Name = "Services_CHBox";
            Services_CHBox.Size = new Size(92, 16);
            Services_CHBox.TabIndex = 43;
            Services_CHBox.TabStop = false;
            Services_CHBox.Text = "System Services";
            Services_CHBox.UseVisualStyleBackColor = true;
            Services_CHBox.CheckedChanged += Services_CHBox_CheckedChanged;
            // 
            // added_Lbl
            // 
            added_Lbl.AutoSize = true;
            added_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            added_Lbl.ForeColor = Color.White;
            added_Lbl.Location = new Point(33, 424);
            added_Lbl.Name = "added_Lbl";
            added_Lbl.Size = new Size(0, 17);
            added_Lbl.TabIndex = 52;
            // 
            // Delete_BTN
            // 
            Delete_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Delete_BTN.Enabled = false;
            Delete_BTN.FlatAppearance.BorderSize = 0;
            Delete_BTN.FlatStyle = FlatStyle.Flat;
            Delete_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Delete_BTN.ForeColor = Color.White;
            Delete_BTN.Location = new Point(266, 355);
            Delete_BTN.Name = "Delete_BTN";
            Delete_BTN.Size = new Size(130, 44);
            Delete_BTN.TabIndex = 40;
            Delete_BTN.TabStop = false;
            Delete_BTN.Text = "🗑️ Delete Service"; // 🧹
            Delete_BTN.UseVisualStyleBackColor = false;
            Delete_BTN.Click += Delete_BTN_Click;
            // 
            // Start_BTN
            // 
            Start_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Start_BTN.Enabled = false;
            Start_BTN.FlatAppearance.BorderSize = 0;
            Start_BTN.FlatStyle = FlatStyle.Flat;
            Start_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Start_BTN.ForeColor = Color.White;
            Start_BTN.Location = new Point(402, 355);
            Start_BTN.Name = "Start_BTN";
            Start_BTN.Size = new Size(75, 44);
            Start_BTN.TabIndex = 41;
            Start_BTN.TabStop = false;
            Start_BTN.Text = "▶ Start";
            Start_BTN.UseVisualStyleBackColor = false;
            Start_BTN.Click += Start_BTN_Click;
            // 
            // Stop_BTN
            // 
            Stop_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Stop_BTN.Enabled = false;
            Stop_BTN.FlatAppearance.BorderSize = 0;
            Stop_BTN.FlatStyle = FlatStyle.Flat;
            Stop_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Stop_BTN.ForeColor = Color.White;
            Stop_BTN.Location = new Point(483, 355);
            Stop_BTN.Name = "Stop_BTN";
            Stop_BTN.Size = new Size(75, 44);
            Stop_BTN.TabIndex = 42;
            Stop_BTN.TabStop = false;
            Stop_BTN.Text = "🚫 Stop";
            Stop_BTN.UseVisualStyleBackColor = false;
            Stop_BTN.Click += Stop_BTN_Click;
            // 
            // Restart_BTN
            // 
            Restart_BTN.BackColor = Color.FromArgb(0, 8, 33);
            Restart_BTN.Enabled = false;
            Restart_BTN.FlatAppearance.BorderSize = 0;
            Restart_BTN.FlatStyle = FlatStyle.Flat;
            Restart_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Restart_BTN.ForeColor = Color.White;
            Restart_BTN.Location = new Point(564, 355);
            Restart_BTN.Name = "Restart_BTN";
            Restart_BTN.Size = new Size(131, 44);
            Restart_BTN.TabIndex = 43;
            Restart_BTN.TabStop = false;
            Restart_BTN.Text = "⚡ Restart";
            Restart_BTN.UseVisualStyleBackColor = false;
            Restart_BTN.Click += Restart_BTN_Click;
            // 
            // US_Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(Myser_Rad);
            Controls.Add(added_Lbl);
            Controls.Add(Services_Rad);
            Controls.Add(Restart_BTN);
            Controls.Add(Stop_BTN);
            Controls.Add(Start_BTN);
            Controls.Add(Delete_BTN);
            Controls.Add(Update_BTN);
            Controls.Add(tabControl_Services);
            Controls.Add(pictureBox_Arrow);
            Controls.Add(Services_CHBox);
            Name = "US_Services";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            tabControl_Services.ResumeLayout(false);
            tabPage_Services.ResumeLayout(false);
            tabPage_Services.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox_Arrow;
        private Button Update_BTN;
        private TabControl tabControl_Services;
        private TabPage tabPage_Services;
        private ComboBox Service_CBox;
        private Label disname_Lbl;
        private CheckBox Services_CHBox;
        private Label service_Lbl;
        private Label sstatus_Lbl;
        private Label serstatus_Lbl;
        private Label sername_Lbl;
        private Label description_Lbl;
        private RichTextBox serdescription_richTextBox;
        private Button Delete_BTN;
        private Button Start_BTN;
        private Button Stop_BTN;
        private Button Restart_BTN;
        private CheckBox autoRestarting_CHBox;
        private Label added_Lbl;
        private RadioButton Myser_Rad;
        private RadioButton Services_Rad;
    }
}