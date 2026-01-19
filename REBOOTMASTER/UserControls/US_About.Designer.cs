namespace REBOOTMASTER.UserControls
{
    partial class US_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_About));
            pictureBox_TXT_Logo = new PictureBox();
            pictureBox_Logo = new PictureBox();
            copyright_Lbl = new Label();
            authorName_Lbl = new Label();
            author_Lbl = new Label();
            github_Lnk = new LinkLabel();
            github_Lbl = new Label();
            homepage_Lnk = new LinkLabel();
            homepage_Lbl = new Label();
            pictureBox_Arrow = new PictureBox();
            richTextBox_TXT = new RichTextBox();
            pictureBox_Profile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TXT_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Profile).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_TXT_Logo
            // 
            pictureBox_TXT_Logo.BackgroundImageLayout = ImageLayout.None;
            pictureBox_TXT_Logo.Image = (Image)resources.GetObject("pictureBox_TXT_Logo.Image");
            pictureBox_TXT_Logo.Location = new Point(300, 337);
            pictureBox_TXT_Logo.Name = "pictureBox_TXT_Logo";
            pictureBox_TXT_Logo.Size = new Size(254, 84);
            pictureBox_TXT_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_TXT_Logo.TabIndex = 13;
            pictureBox_TXT_Logo.TabStop = false;
            // 
            // pictureBox_Logo
            // 
            pictureBox_Logo.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Logo.Image = (Image)resources.GetObject("pictureBox_Logo.Image");
            pictureBox_Logo.Location = new Point(220, 348);
            pictureBox_Logo.Name = "pictureBox_Logo";
            pictureBox_Logo.Size = new Size(75, 69);
            pictureBox_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Logo.TabIndex = 14;
            pictureBox_Logo.TabStop = false;
            // 
            // copyright_Lbl
            // 
            copyright_Lbl.AutoSize = true;
            copyright_Lbl.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyright_Lbl.ForeColor = Color.Gainsboro;
            copyright_Lbl.Location = new Point(317, 424);
            copyright_Lbl.Name = "copyright_Lbl";
            copyright_Lbl.Size = new Size(219, 13);
            copyright_Lbl.TabIndex = 18;
            copyright_Lbl.Text = "© Copyright 2025 - XXXX REBOOTMASTER";
            // 
            // authorName_Lbl
            // 
            authorName_Lbl.AutoSize = true;
            authorName_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorName_Lbl.ForeColor = Color.White;
            authorName_Lbl.Location = new Point(141, 50);
            authorName_Lbl.Name = "authorName_Lbl";
            authorName_Lbl.Size = new Size(77, 17);
            authorName_Lbl.TabIndex = 29;
            authorName_Lbl.Text = "Amir Argani";
            // 
            // author_Lbl
            // 
            author_Lbl.AutoSize = true;
            author_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            author_Lbl.ForeColor = Color.White;
            author_Lbl.Location = new Point(58, 50);
            author_Lbl.Name = "author_Lbl";
            author_Lbl.Size = new Size(56, 17);
            author_Lbl.TabIndex = 28;
            author_Lbl.Text = "Author:";
            // 
            // github_Lnk
            // 
            github_Lnk.ActiveLinkColor = Color.FromArgb(217, 79, 38);
            github_Lnk.AutoSize = true;
            github_Lnk.LinkColor = Color.White;
            github_Lnk.Location = new Point(143, 84);
            github_Lnk.Name = "github_Lnk";
            github_Lnk.Size = new Size(171, 15);
            github_Lnk.TabIndex = 27;
            github_Lnk.TabStop = true;
            github_Lnk.Text = "https://github.com/amirargani";
            github_Lnk.LinkClicked += github_Lnk_LinkClicked;
            // 
            // github_Lbl
            // 
            github_Lbl.AutoSize = true;
            github_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            github_Lbl.ForeColor = Color.White;
            github_Lbl.Location = new Point(58, 82);
            github_Lbl.Name = "github_Lbl";
            github_Lbl.Size = new Size(56, 17);
            github_Lbl.TabIndex = 26;
            github_Lbl.Text = "GitHub:";
            // 
            // homepage_Lnk
            // 
            homepage_Lnk.ActiveLinkColor = Color.FromArgb(217, 79, 38);
            homepage_Lnk.AutoSize = true;
            homepage_Lnk.LinkColor = Color.White;
            homepage_Lnk.Location = new Point(143, 115);
            homepage_Lnk.Name = "homepage_Lnk";
            homepage_Lnk.Size = new Size(265, 15);
            homepage_Lnk.TabIndex = 25;
            homepage_Lnk.TabStop = true;
            homepage_Lnk.Text = "https://github.com/amirargani/REBOOTMASTER";
            homepage_Lnk.LinkClicked += homepage_Lnk_LinkClicked;
            // 
            // homepage_Lbl
            // 
            homepage_Lbl.AutoSize = true;
            homepage_Lbl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            homepage_Lbl.ForeColor = Color.White;
            homepage_Lbl.Location = new Point(58, 113);
            homepage_Lbl.Name = "homepage_Lbl";
            homepage_Lbl.Size = new Size(79, 17);
            homepage_Lbl.TabIndex = 24;
            homepage_Lbl.Text = "Homepage:";
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
            // richTextBox_TXT
            // 
            richTextBox_TXT.BackColor = Color.FromArgb(0, 8, 25);
            richTextBox_TXT.BorderStyle = BorderStyle.None;
            richTextBox_TXT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_TXT.ForeColor = SystemColors.Control;
            richTextBox_TXT.Location = new Point(58, 174);
            richTextBox_TXT.Name = "richTextBox_TXT";
            richTextBox_TXT.ReadOnly = true;
            richTextBox_TXT.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_TXT.Size = new Size(674, 110);
            richTextBox_TXT.TabIndex = 32;
            richTextBox_TXT.Text = resources.GetString("richTextBox_TXT.Text");
            richTextBox_TXT.Click += richTextBox_TXT_Click;
            richTextBox_TXT.MouseDown += richTextBox_TXT_MouseDown;
            // 
            // pictureBox_Profile
            // 
            pictureBox_Profile.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Profile.Image = (Image)resources.GetObject("pictureBox_Profile.Image");
            pictureBox_Profile.Location = new Point(580, 26);
            pictureBox_Profile.Name = "pictureBox_Profile";
            pictureBox_Profile.Size = new Size(166, 140);
            pictureBox_Profile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Profile.TabIndex = 33;
            pictureBox_Profile.TabStop = false;
            pictureBox_Profile.Click += pictureBox_Profile_Click;
            // 
            // US_About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 8, 25);
            Controls.Add(richTextBox_TXT);
            Controls.Add(pictureBox_Profile);
            Controls.Add(authorName_Lbl);
            Controls.Add(author_Lbl);
            Controls.Add(github_Lnk);
            Controls.Add(github_Lbl);
            Controls.Add(homepage_Lnk);
            Controls.Add(homepage_Lbl);
            Controls.Add(copyright_Lbl);
            Controls.Add(pictureBox_Logo);
            Controls.Add(pictureBox_TXT_Logo);
            Controls.Add(pictureBox_Arrow);
            Name = "US_About";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox_TXT_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_TXT_Logo;
        private PictureBox pictureBox_Logo;
        private Label copyright_Lbl;
        private Label authorName_Lbl;
        private Label author_Lbl;
        private LinkLabel github_Lnk;
        private Label github_Lbl;
        private LinkLabel homepage_Lnk;
        private Label homepage_Lbl;
        private PictureBox pictureBox_Arrow;
        private RichTextBox richTextBox_TXT;
        private PictureBox pictureBox_Profile;
    }
}