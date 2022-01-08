namespace VLC_BluRay_Installer_WFA
{
    partial class Form1
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.VlcInstallationPathBox = new System.Windows.Forms.TextBox();
            this.SelectDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(158, 418);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFinish.Enabled = false;
            this.ButtonFinish.Location = new System.Drawing.Point(239, 418);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(75, 23);
            this.ButtonFinish.TabIndex = 1;
            this.ButtonFinish.Text = "Finish";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuit.Location = new System.Drawing.Point(320, 418);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(75, 23);
            this.ButtonQuit.TabIndex = 2;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // VlcInstallationPathBox
            // 
            this.VlcInstallationPathBox.Location = new System.Drawing.Point(12, 12);
            this.VlcInstallationPathBox.Name = "VlcInstallationPathBox";
            this.VlcInstallationPathBox.Size = new System.Drawing.Size(356, 23);
            this.VlcInstallationPathBox.TabIndex = 4;
            this.VlcInstallationPathBox.TextChanged += new System.EventHandler(this.VlcInstallationPathBox_TextChanged);
            // 
            // SelectDirectory
            // 
            this.SelectDirectory.Location = new System.Drawing.Point(374, 11);
            this.SelectDirectory.Name = "SelectDirectory";
            this.SelectDirectory.Size = new System.Drawing.Size(24, 23);
            this.SelectDirectory.TabIndex = 6;
            this.SelectDirectory.Text = "...";
            this.SelectDirectory.UseVisualStyleBackColor = true;
            this.SelectDirectory.Click += new System.EventHandler(this.SelectDirectory_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            this.folderBrowserDialog1.SelectedPath = "C:\\Program Files (x86)\\VideoLAN\\VLC";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(12, 426);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(110, 15);
            this.CopyrightLabel.TabIndex = 7;
            this.CopyrightLabel.Text = "© 2022 N. J. Rueber";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 41);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(356, 371);
            this.outputBox.TabIndex = 8;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.SelectDirectory);
            this.Controls.Add(this.VlcInstallationPathBox);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonFinish);
            this.Controls.Add(this.ButtonStart);
            this.Name = "Form1";
            this.Text = "VLC BluRay Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonStart;
        private Button ButtonFinish;
        private Button ButtonQuit;
        private TextBox VlcInstallationPathBox;
        private Button SelectDirectory;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label CopyrightLabel;
        private RichTextBox outputBox;
    }
}