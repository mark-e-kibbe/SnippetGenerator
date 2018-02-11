namespace SnippetGenerator
{
    partial class ConfigurationForm
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
            this.lblDefaultAuthor = new System.Windows.Forms.Label();
            this.lblVisualStudioPath = new System.Windows.Forms.Label();
            this.lblSSMSPath = new System.Windows.Forms.Label();
            this.txtDefaultAuthor = new System.Windows.Forms.TextBox();
            this.txtDefaultSSMSPath = new System.Windows.Forms.TextBox();
            this.txtDefaultVisualStudioPath = new System.Windows.Forms.TextBox();
            this.lblOutputs = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDefaultAuthor
            // 
            this.lblDefaultAuthor.AutoSize = true;
            this.lblDefaultAuthor.Location = new System.Drawing.Point(18, 17);
            this.lblDefaultAuthor.Name = "lblDefaultAuthor";
            this.lblDefaultAuthor.Size = new System.Drawing.Size(75, 13);
            this.lblDefaultAuthor.TabIndex = 0;
            this.lblDefaultAuthor.Text = "Default Author";
            // 
            // lblVisualStudioPath
            // 
            this.lblVisualStudioPath.AutoSize = true;
            this.lblVisualStudioPath.Location = new System.Drawing.Point(18, 83);
            this.lblVisualStudioPath.Name = "lblVisualStudioPath";
            this.lblVisualStudioPath.Size = new System.Drawing.Size(68, 13);
            this.lblVisualStudioPath.TabIndex = 1;
            this.lblVisualStudioPath.Text = "Visual Studio";
            // 
            // lblSSMSPath
            // 
            this.lblSSMSPath.AutoSize = true;
            this.lblSSMSPath.Location = new System.Drawing.Point(18, 149);
            this.lblSSMSPath.Name = "lblSSMSPath";
            this.lblSSMSPath.Size = new System.Drawing.Size(37, 13);
            this.lblSSMSPath.TabIndex = 2;
            this.lblSSMSPath.Text = "SSMS";
            // 
            // txtDefaultAuthor
            // 
            this.txtDefaultAuthor.Location = new System.Drawing.Point(92, 14);
            this.txtDefaultAuthor.Name = "txtDefaultAuthor";
            this.txtDefaultAuthor.Size = new System.Drawing.Size(196, 20);
            this.txtDefaultAuthor.TabIndex = 3;
            // 
            // txtDefaultSSMSPath
            // 
            this.txtDefaultSSMSPath.Location = new System.Drawing.Point(92, 146);
            this.txtDefaultSSMSPath.Name = "txtDefaultSSMSPath";
            this.txtDefaultSSMSPath.Size = new System.Drawing.Size(196, 20);
            this.txtDefaultSSMSPath.TabIndex = 4;
            // 
            // txtDefaultVisualStudioPath
            // 
            this.txtDefaultVisualStudioPath.Location = new System.Drawing.Point(92, 80);
            this.txtDefaultVisualStudioPath.Name = "txtDefaultVisualStudioPath";
            this.txtDefaultVisualStudioPath.Size = new System.Drawing.Size(196, 20);
            this.txtDefaultVisualStudioPath.TabIndex = 5;
            // 
            // lblOutputs
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.Location = new System.Drawing.Point(89, 64);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(118, 13);
            this.lblOutputs.TabIndex = 6;
            this.lblOutputs.Text = "Snippet Output Filepath";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOutputs);
            this.Controls.Add(this.txtDefaultVisualStudioPath);
            this.Controls.Add(this.txtDefaultSSMSPath);
            this.Controls.Add(this.txtDefaultAuthor);
            this.Controls.Add(this.lblSSMSPath);
            this.Controls.Add(this.lblVisualStudioPath);
            this.Controls.Add(this.lblDefaultAuthor);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDefaultAuthor;
        private System.Windows.Forms.Label lblVisualStudioPath;
        private System.Windows.Forms.Label lblSSMSPath;
        private System.Windows.Forms.TextBox txtDefaultAuthor;
        private System.Windows.Forms.TextBox txtDefaultSSMSPath;
        private System.Windows.Forms.TextBox txtDefaultVisualStudioPath;
        private System.Windows.Forms.Label lblOutputs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}