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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Dashboard));
            pictureBox_Arrow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
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
            // US_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(pictureBox_Arrow);
            Name = "US_Dashboard";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox_Arrow;
    }
}