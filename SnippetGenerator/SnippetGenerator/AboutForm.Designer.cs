namespace SnippetGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.linkLblGitHub = new System.Windows.Forms.LinkLabel();
            this.lblProjectOrigin = new System.Windows.Forms.Label();
            this.lblProjectPurpose = new System.Windows.Forms.Label();
            this.lblBackground = new System.Windows.Forms.Label();
            this.linkLblEmailAddress = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLblLinkedIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1207, 591);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLblGitHub
            // 
            this.linkLblGitHub.AutoSize = true;
            this.linkLblGitHub.Location = new System.Drawing.Point(279, 564);
            this.linkLblGitHub.Name = "linkLblGitHub";
            this.linkLblGitHub.Size = new System.Drawing.Size(265, 20);
            this.linkLblGitHub.TabIndex = 1;
            this.linkLblGitHub.TabStop = true;
            this.linkLblGitHub.Text = "Go To My GitHub Project Repository";
            this.linkLblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblGitHub_LinkClicked);
            // 
            // lblProjectOrigin
            // 
            this.lblProjectOrigin.Location = new System.Drawing.Point(279, 14);
            this.lblProjectOrigin.Name = "lblProjectOrigin";
            this.lblProjectOrigin.Size = new System.Drawing.Size(1003, 110);
            this.lblProjectOrigin.TabIndex = 2;
            this.lblProjectOrigin.Text = resources.GetString("lblProjectOrigin.Text");
            // 
            // lblProjectPurpose
            // 
            this.lblProjectPurpose.Location = new System.Drawing.Point(279, 145);
            this.lblProjectPurpose.Name = "lblProjectPurpose";
            this.lblProjectPurpose.Size = new System.Drawing.Size(1003, 75);
            this.lblProjectPurpose.TabIndex = 3;
            this.lblProjectPurpose.Text = resources.GetString("lblProjectPurpose.Text");
            // 
            // lblBackground
            // 
            this.lblBackground.Location = new System.Drawing.Point(279, 237);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(1003, 283);
            this.lblBackground.TabIndex = 4;
            this.lblBackground.Text = resources.GetString("lblBackground.Text");
            // 
            // linkLblEmailAddress
            // 
            this.linkLblEmailAddress.AutoSize = true;
            this.linkLblEmailAddress.Location = new System.Drawing.Point(279, 531);
            this.linkLblEmailAddress.Name = "linkLblEmailAddress";
            this.linkLblEmailAddress.Size = new System.Drawing.Size(186, 20);
            this.linkLblEmailAddress.TabIndex = 5;
            this.linkLblEmailAddress.TabStop = true;
            this.linkLblEmailAddress.Text = "mark.e.kibbe@gmail.com";
            this.linkLblEmailAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEmailAddress_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "About the Application:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "GitHub Project Repository Link:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Email (Click to Copy):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "About the Developer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Application Purpose:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "LinkedIn Profile:";
            // 
            // linkLblLinkedIn
            // 
            this.linkLblLinkedIn.AutoSize = true;
            this.linkLblLinkedIn.Location = new System.Drawing.Point(279, 597);
            this.linkLblLinkedIn.Name = "linkLblLinkedIn";
            this.linkLblLinkedIn.Size = new System.Drawing.Size(194, 20);
            this.linkLblLinkedIn.TabIndex = 11;
            this.linkLblLinkedIn.TabStop = true;
            this.linkLblLinkedIn.Text = "Go To My Linked In Profile";
            this.linkLblLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLinkedIn_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 635);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLblLinkedIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLblEmailAddress);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.lblProjectPurpose);
            this.Controls.Add(this.lblProjectOrigin);
            this.Controls.Add(this.linkLblGitHub);
            this.Controls.Add(this.btnClose);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkLblGitHub;
        private System.Windows.Forms.Label lblProjectOrigin;
        private System.Windows.Forms.Label lblProjectPurpose;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.LinkLabel linkLblEmailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLblLinkedIn;
    }
}