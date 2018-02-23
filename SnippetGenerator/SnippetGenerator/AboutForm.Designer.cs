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
            this.btnClose = new System.Windows.Forms.Button();
            this.linkLblGitHub = new System.Windows.Forms.LinkLabel();
            this.lblProjectOrigin = new System.Windows.Forms.Label();
            this.lblProjectPurpose = new System.Windows.Forms.Label();
            this.lblBackground = new System.Windows.Forms.Label();
            this.linkLblEmailAddress = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // linkLblGitHub
            // 
            this.linkLblGitHub.AutoSize = true;
            this.linkLblGitHub.Location = new System.Drawing.Point(35, 241);
            this.linkLblGitHub.Name = "linkLblGitHub";
            this.linkLblGitHub.Size = new System.Drawing.Size(193, 20);
            this.linkLblGitHub.TabIndex = 1;
            this.linkLblGitHub.TabStop = true;
            this.linkLblGitHub.Text = "GitHub Project Repository";
            // 
            // lblProjectOrigin
            // 
            this.lblProjectOrigin.AutoSize = true;
            this.lblProjectOrigin.Location = new System.Drawing.Point(50, 55);
            this.lblProjectOrigin.Name = "lblProjectOrigin";
            this.lblProjectOrigin.Size = new System.Drawing.Size(102, 20);
            this.lblProjectOrigin.TabIndex = 2;
            this.lblProjectOrigin.Text = "project Origin";
            // 
            // lblProjectPurpose
            // 
            this.lblProjectPurpose.AutoSize = true;
            this.lblProjectPurpose.Location = new System.Drawing.Point(54, 106);
            this.lblProjectPurpose.Name = "lblProjectPurpose";
            this.lblProjectPurpose.Size = new System.Drawing.Size(121, 20);
            this.lblProjectPurpose.TabIndex = 3;
            this.lblProjectPurpose.Text = "Project Purpose";
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(54, 166);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(141, 20);
            this.lblBackground.TabIndex = 4;
            this.lblBackground.Text = "background on me";
            // 
            // linkLblEmailAddress
            // 
            this.linkLblEmailAddress.AutoSize = true;
            this.linkLblEmailAddress.Location = new System.Drawing.Point(58, 204);
            this.linkLblEmailAddress.Name = "linkLblEmailAddress";
            this.linkLblEmailAddress.Size = new System.Drawing.Size(186, 20);
            this.linkLblEmailAddress.TabIndex = 5;
            this.linkLblEmailAddress.TabStop = true;
            this.linkLblEmailAddress.Text = "mark.e.kibbe@gmail.com";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 333);
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
    }
}