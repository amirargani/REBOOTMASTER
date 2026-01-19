namespace REBOOTMASTER_Free.UserControls
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
            update_BTN = new Button();
            tabControl_Services = new TabControl();
            tabPage_Services = new TabPage();
            autoRestarting_CHBox = new CheckBox();
            serdescription_richTextBox = new RichTextBox();
            description_Lbl = new Label();
            serstatus_Lbl = new Label();
            sername_Lbl = new Label();
            sstatus_Lbl = new Label();
            service_Lbl = new Label();
            service_CBox = new ComboBox();
            disname_Lbl = new Label();
            myser_Rad = new RadioButton();
            services_Rad = new RadioButton();
            services_CHBox = new CheckBox();
            added_Lbl = new Label();
            delete_BTN = new Button();
            start_BTN = new Button();
            stop_BTN = new Button();
            restart_BTN = new Button();
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
            // update_BTN
            // 
            update_BTN.BackColor = Color.FromArgb(0, 8, 33);
            update_BTN.Enabled = false;
            update_BTN.FlatAppearance.BorderSize = 0;
            update_BTN.FlatStyle = FlatStyle.Flat;
            update_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            update_BTN.ForeColor = Color.White;
            update_BTN.Location = new Point(33, 355);
            update_BTN.Name = "update_BTN";
            update_BTN.Size = new Size(228, 44);
            update_BTN.TabIndex = 39;
            update_BTN.TabStop = false;
            update_BTN.Text = "▶ Add or Update Service in List";
            update_BTN.UseVisualStyleBackColor = false;
            update_BTN.Click += update_BTN_Click;
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
            tabPage_Services.Controls.Add(service_CBox);
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
            // service_CBox
            // 
            service_CBox.BackColor = Color.FromArgb(0, 8, 25);
            service_CBox.DropDownStyle = ComboBoxStyle.DropDownList;
            service_CBox.Font = new Font("Nirmala UI", 8.25F);
            service_CBox.ForeColor = Color.White;
            service_CBox.FormattingEnabled = true;
            service_CBox.Location = new Point(210, 20);
            service_CBox.Name = "service_CBox";
            service_CBox.Size = new Size(438, 21);
            service_CBox.TabIndex = 42;
            service_CBox.TabStop = false;
            service_CBox.Tag = "";
            service_CBox.SelectedIndexChanged += service_CBox_SelectedIndexChanged;
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
            // myser_Rad
            // 
            myser_Rad.AutoSize = true;
            myser_Rad.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myser_Rad.ForeColor = Color.White;
            myser_Rad.Location = new Point(699, 81);
            myser_Rad.Name = "myser_Rad";
            myser_Rad.Size = new Size(103, 16);
            myser_Rad.TabIndex = 53;
            myser_Rad.Text = "My Active Services";
            myser_Rad.UseVisualStyleBackColor = true;
            myser_Rad.CheckedChanged += myser_Rad_CheckedChanged;
            // 
            // services_Rad
            // 
            services_Rad.AutoSize = true;
            services_Rad.Checked = true;
            services_Rad.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold);
            services_Rad.ForeColor = Color.White;
            services_Rad.Location = new Point(699, 41);
            services_Rad.Name = "services_Rad";
            services_Rad.Size = new Size(72, 16);
            services_Rad.TabIndex = 52;
            services_Rad.TabStop = true;
            services_Rad.Text = "All Services";
            services_Rad.UseVisualStyleBackColor = true;
            services_Rad.CheckedChanged += services_Rad_CheckedChanged;
            // 
            // services_CHBox
            // 
            services_CHBox.AutoSize = true;
            services_CHBox.Checked = true;
            services_CHBox.CheckState = CheckState.Checked;
            services_CHBox.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            services_CHBox.ForeColor = Color.White;
            services_CHBox.Location = new Point(699, 61);
            services_CHBox.Name = "services_CHBox";
            services_CHBox.Size = new Size(92, 16);
            services_CHBox.TabIndex = 43;
            services_CHBox.TabStop = false;
            services_CHBox.Text = "System Services";
            services_CHBox.UseVisualStyleBackColor = true;
            services_CHBox.CheckedChanged += services_CHBox_CheckedChanged;
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
            // delete_BTN
            // 
            delete_BTN.BackColor = Color.FromArgb(0, 8, 33);
            delete_BTN.Enabled = false;
            delete_BTN.FlatAppearance.BorderSize = 0;
            delete_BTN.FlatStyle = FlatStyle.Flat;
            delete_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            delete_BTN.ForeColor = Color.White;
            delete_BTN.Location = new Point(267, 355);
            delete_BTN.Name = "delete_BTN";
            delete_BTN.Size = new Size(130, 44);
            delete_BTN.TabIndex = 40;
            delete_BTN.TabStop = false;
            delete_BTN.Text = "\U0001f9f9 Delete Service";
            delete_BTN.UseVisualStyleBackColor = false;
            delete_BTN.Click += delete_BTN_Click;
            // 
            // start_BTN
            // 
            start_BTN.BackColor = Color.FromArgb(0, 8, 33);
            start_BTN.Enabled = false;
            start_BTN.FlatAppearance.BorderSize = 0;
            start_BTN.FlatStyle = FlatStyle.Flat;
            start_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            start_BTN.ForeColor = Color.White;
            start_BTN.Location = new Point(403, 355);
            start_BTN.Name = "start_BTN";
            start_BTN.Size = new Size(75, 44);
            start_BTN.TabIndex = 41;
            start_BTN.TabStop = false;
            start_BTN.Text = "▶ Start";
            start_BTN.UseVisualStyleBackColor = false;
            start_BTN.Click += start_BTN_Click;
            // 
            // stop_BTN
            // 
            stop_BTN.BackColor = Color.FromArgb(0, 8, 33);
            stop_BTN.Enabled = false;
            stop_BTN.FlatAppearance.BorderSize = 0;
            stop_BTN.FlatStyle = FlatStyle.Flat;
            stop_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            stop_BTN.ForeColor = Color.White;
            stop_BTN.Location = new Point(484, 355);
            stop_BTN.Name = "stop_BTN";
            stop_BTN.Size = new Size(75, 44);
            stop_BTN.TabIndex = 42;
            stop_BTN.TabStop = false;
            stop_BTN.Text = "🚫 Stop";
            stop_BTN.UseVisualStyleBackColor = false;
            stop_BTN.Click += stop_BTN_Click;
            // 
            // restart_BTN
            // 
            restart_BTN.BackColor = Color.FromArgb(0, 8, 33);
            restart_BTN.Enabled = false;
            restart_BTN.FlatAppearance.BorderSize = 0;
            restart_BTN.FlatStyle = FlatStyle.Flat;
            restart_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            restart_BTN.ForeColor = Color.White;
            restart_BTN.Location = new Point(565, 355);
            restart_BTN.Name = "restart_BTN";
            restart_BTN.Size = new Size(130, 44);
            restart_BTN.TabIndex = 43;
            restart_BTN.TabStop = false;
            restart_BTN.Text = "⚡ Restart";
            restart_BTN.UseVisualStyleBackColor = false;
            restart_BTN.Click += restart_BTN_Click;
            // 
            // US_Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(myser_Rad);
            Controls.Add(added_Lbl);
            Controls.Add(services_Rad);
            Controls.Add(restart_BTN);
            Controls.Add(stop_BTN);
            Controls.Add(start_BTN);
            Controls.Add(delete_BTN);
            Controls.Add(update_BTN);
            Controls.Add(tabControl_Services);
            Controls.Add(pictureBox_Arrow);
            Controls.Add(services_CHBox);
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
        private Button update_BTN;
        private TabControl tabControl_Services;
        private TabPage tabPage_Services;
        private ComboBox service_CBox;
        private Label disname_Lbl;
        private CheckBox services_CHBox;
        private Label service_Lbl;
        private Label sstatus_Lbl;
        private Label serstatus_Lbl;
        private Label sername_Lbl;
        private Label description_Lbl;
        private RichTextBox serdescription_richTextBox;
        private Button delete_BTN;
        private Button start_BTN;
        private Button stop_BTN;
        private Button restart_BTN;
        private CheckBox autoRestarting_CHBox;
        private Label added_Lbl;
        private RadioButton myser_Rad;
        private RadioButton services_Rad;
    }
}