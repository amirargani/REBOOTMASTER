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
            tabPage_addService = new TabPage();
            tabPage_Sverices = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
            tabControl_Services.SuspendLayout();
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
            update_BTN.FlatAppearance.BorderSize = 0;
            update_BTN.FlatStyle = FlatStyle.Flat;
            update_BTN.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            update_BTN.ForeColor = Color.White;
            update_BTN.Location = new Point(33, 355);
            update_BTN.Name = "update_BTN";
            update_BTN.Size = new Size(662, 44);
            update_BTN.TabIndex = 39;
            update_BTN.TabStop = false;
            update_BTN.Text = "📥 Update";
            update_BTN.UseVisualStyleBackColor = false;
            // 
            // tabControl_Services
            // 
            tabControl_Services.Controls.Add(tabPage_addService);
            tabControl_Services.Controls.Add(tabPage_Sverices);
            tabControl_Services.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            tabControl_Services.Location = new Point(33, 13);
            tabControl_Services.Name = "tabControl_Services";
            tabControl_Services.SelectedIndex = 0;
            tabControl_Services.Size = new Size(662, 336);
            tabControl_Services.TabIndex = 38;
            tabControl_Services.TabStop = false;
            // 
            // tabPage_addService
            // 
            tabPage_addService.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_addService.Location = new Point(4, 26);
            tabPage_addService.Name = "tabPage_addService";
            tabPage_addService.Padding = new Padding(3);
            tabPage_addService.Size = new Size(654, 306);
            tabPage_addService.TabIndex = 1;
            tabPage_addService.Text = "🛠️ Add Service";
            // 
            // tabPage_Sverices
            // 
            tabPage_Sverices.BackColor = Color.FromArgb(0, 8, 25);
            tabPage_Sverices.Location = new Point(4, 26);
            tabPage_Sverices.Name = "tabPage_Sverices";
            tabPage_Sverices.Padding = new Padding(3);
            tabPage_Sverices.Size = new Size(654, 306);
            tabPage_Sverices.TabIndex = 0;
            tabPage_Sverices.Text = "📦 Services Configuration";
            // 
            // US_Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(update_BTN);
            Controls.Add(tabControl_Services);
            Controls.Add(pictureBox_Arrow);
            Name = "US_Services";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            tabControl_Services.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox_Arrow;
        private Button update_BTN;
        private TabControl tabControl_Services;
        private TabPage tabPage_addService;
        private TabPage tabPage_Sverices;
    }
}