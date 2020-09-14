﻿namespace ChryslerCCDSCIScanner
{
    partial class AboutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GUIFWVersionLabel = new System.Windows.Forms.Label();
            this.AboutDescriptionLabel01 = new System.Windows.Forms.Label();
            this.AboutTitleLabel = new System.Windows.Forms.Label();
            this.AboutDescriptionLabel02 = new System.Windows.Forms.Label();
            this.AboutDescriptionLabel03 = new System.Windows.Forms.Label();
            this.ScannerPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BlogLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GUIFWVersionLabel
            // 
            this.GUIFWVersionLabel.AutoSize = true;
            this.GUIFWVersionLabel.Location = new System.Drawing.Point(12, 38);
            this.GUIFWVersionLabel.Name = "GUIFWVersionLabel";
            this.GUIFWVersionLabel.Size = new System.Drawing.Size(123, 13);
            this.GUIFWVersionLabel.TabIndex = 0;
            this.GUIFWVersionLabel.Text = "GUI v0.0.0  |  FW v0.0.0";
            // 
            // AboutDescriptionLabel01
            // 
            this.AboutDescriptionLabel01.AutoSize = true;
            this.AboutDescriptionLabel01.Location = new System.Drawing.Point(12, 66);
            this.AboutDescriptionLabel01.Name = "AboutDescriptionLabel01";
            this.AboutDescriptionLabel01.Size = new System.Drawing.Size(266, 13);
            this.AboutDescriptionLabel01.TabIndex = 0;
            this.AboutDescriptionLabel01.Text = "A user interface to interact with the diagnostic scanner.";
            // 
            // AboutTitleLabel
            // 
            this.AboutTitleLabel.AutoSize = true;
            this.AboutTitleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AboutTitleLabel.Location = new System.Drawing.Point(9, 9);
            this.AboutTitleLabel.Name = "AboutTitleLabel";
            this.AboutTitleLabel.Size = new System.Drawing.Size(232, 26);
            this.AboutTitleLabel.TabIndex = 0;
            this.AboutTitleLabel.Text = "Chrysler CCD/SCI Scanner";
            // 
            // AboutDescriptionLabel02
            // 
            this.AboutDescriptionLabel02.AutoSize = true;
            this.AboutDescriptionLabel02.Location = new System.Drawing.Point(12, 84);
            this.AboutDescriptionLabel02.Name = "AboutDescriptionLabel02";
            this.AboutDescriptionLabel02.Size = new System.Drawing.Size(266, 13);
            this.AboutDescriptionLabel02.TabIndex = 0;
            this.AboutDescriptionLabel02.Text = "Compatible vehicles: 1983-2004 Chrysler/Dodge/Jeep.";
            // 
            // AboutDescriptionLabel03
            // 
            this.AboutDescriptionLabel03.AutoSize = true;
            this.AboutDescriptionLabel03.Location = new System.Drawing.Point(12, 112);
            this.AboutDescriptionLabel03.Name = "AboutDescriptionLabel03";
            this.AboutDescriptionLabel03.Size = new System.Drawing.Size(251, 13);
            this.AboutDescriptionLabel03.TabIndex = 0;
            this.AboutDescriptionLabel03.Text = "Developed by Daniel Laszlo @ Boundary Condition.";
            // 
            // ScannerPictureBox
            // 
            this.ScannerPictureBox.BackgroundImage = global::ChryslerCCDSCIScanner.Properties.Resources.scanner_preview_128x128;
            this.ScannerPictureBox.InitialImage = global::ChryslerCCDSCIScanner.Properties.Resources.scanner_preview_128x128;
            this.ScannerPictureBox.Location = new System.Drawing.Point(150, 150);
            this.ScannerPictureBox.Name = "ScannerPictureBox";
            this.ScannerPictureBox.Size = new System.Drawing.Size(128, 128);
            this.ScannerPictureBox.TabIndex = 10;
            this.ScannerPictureBox.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::ChryslerCCDSCIScanner.Properties.Resources.chrysler_icon_128x128;
            this.LogoPictureBox.InitialImage = global::ChryslerCCDSCIScanner.Properties.Resources.chrysler_icon_128x128;
            this.LogoPictureBox.Location = new System.Drawing.Point(16, 150);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // BlogLinkLabel
            // 
            this.BlogLinkLabel.AutoSize = true;
            this.BlogLinkLabel.Location = new System.Drawing.Point(13, 130);
            this.BlogLinkLabel.Name = "BlogLinkLabel";
            this.BlogLinkLabel.Size = new System.Drawing.Size(189, 13);
            this.BlogLinkLabel.TabIndex = 1;
            this.BlogLinkLabel.TabStop = true;
            this.BlogLinkLabel.Text = "https://chryslerccdsci.wordpress.com/";
            this.BlogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 295);
            this.Controls.Add(this.BlogLinkLabel);
            this.Controls.Add(this.ScannerPictureBox);
            this.Controls.Add(this.AboutDescriptionLabel03);
            this.Controls.Add(this.AboutDescriptionLabel02);
            this.Controls.Add(this.GUIFWVersionLabel);
            this.Controls.Add(this.AboutDescriptionLabel01);
            this.Controls.Add(this.AboutTitleLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label GUIFWVersionLabel;
        private System.Windows.Forms.Label AboutDescriptionLabel01;
        private System.Windows.Forms.Label AboutTitleLabel;
        private System.Windows.Forms.Label AboutDescriptionLabel02;
        private System.Windows.Forms.Label AboutDescriptionLabel03;
        private System.Windows.Forms.PictureBox ScannerPictureBox;
        private System.Windows.Forms.LinkLabel BlogLinkLabel;
    }
}