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
            this.lblSnippetType = new System.Windows.Forms.Label();
            this.pnlConfigSnippetType = new System.Windows.Forms.Panel();
            this.radConfigTypeExpansion = new System.Windows.Forms.RadioButton();
            this.radConfigTypeSurroundsWith = new System.Windows.Forms.RadioButton();
            this.pnlConfigPlatform = new System.Windows.Forms.Panel();
            this.radConfigPlatformVS = new System.Windows.Forms.RadioButton();
            this.radConfigPlatformSSMS = new System.Windows.Forms.RadioButton();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.radConfigPlatformNone = new System.Windows.Forms.RadioButton();
            this.radConfigTypeNone = new System.Windows.Forms.RadioButton();
            this.pnlConfigSnippetType.SuspendLayout();
            this.pnlConfigPlatform.SuspendLayout();
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
            this.lblVisualStudioPath.Location = new System.Drawing.Point(18, 145);
            this.lblVisualStudioPath.Name = "lblVisualStudioPath";
            this.lblVisualStudioPath.Size = new System.Drawing.Size(68, 13);
            this.lblVisualStudioPath.TabIndex = 1;
            this.lblVisualStudioPath.Text = "Visual Studio";
            // 
            // lblSSMSPath
            // 
            this.lblSSMSPath.AutoSize = true;
            this.lblSSMSPath.Location = new System.Drawing.Point(18, 173);
            this.lblSSMSPath.Name = "lblSSMSPath";
            this.lblSSMSPath.Size = new System.Drawing.Size(37, 13);
            this.lblSSMSPath.TabIndex = 2;
            this.lblSSMSPath.Text = "SSMS";
            // 
            // txtDefaultAuthor
            // 
            this.txtDefaultAuthor.Location = new System.Drawing.Point(92, 14);
            this.txtDefaultAuthor.Name = "txtDefaultAuthor";
            this.txtDefaultAuthor.Size = new System.Drawing.Size(266, 20);
            this.txtDefaultAuthor.TabIndex = 3;
            // 
            // txtDefaultSSMSPath
            // 
            this.txtDefaultSSMSPath.Location = new System.Drawing.Point(92, 179);
            this.txtDefaultSSMSPath.Name = "txtDefaultSSMSPath";
            this.txtDefaultSSMSPath.Size = new System.Drawing.Size(266, 20);
            this.txtDefaultSSMSPath.TabIndex = 4;
            // 
            // txtDefaultVisualStudioPath
            // 
            this.txtDefaultVisualStudioPath.Location = new System.Drawing.Point(92, 142);
            this.txtDefaultVisualStudioPath.Name = "txtDefaultVisualStudioPath";
            this.txtDefaultVisualStudioPath.Size = new System.Drawing.Size(266, 20);
            this.txtDefaultVisualStudioPath.TabIndex = 5;
            // 
            // lblOutputs
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.Location = new System.Drawing.Point(160, 126);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(123, 13);
            this.lblOutputs.TabIndex = 6;
            this.lblOutputs.Text = "Snippet Output Filepaths";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSnippetType
            // 
            this.lblSnippetType.AutoSize = true;
            this.lblSnippetType.Location = new System.Drawing.Point(18, 44);
            this.lblSnippetType.Name = "lblSnippetType";
            this.lblSnippetType.Size = new System.Drawing.Size(70, 13);
            this.lblSnippetType.TabIndex = 9;
            this.lblSnippetType.Text = "Snippet Type";
            // 
            // pnlConfigSnippetType
            // 
            this.pnlConfigSnippetType.Controls.Add(this.radConfigTypeNone);
            this.pnlConfigSnippetType.Controls.Add(this.radConfigTypeExpansion);
            this.pnlConfigSnippetType.Controls.Add(this.radConfigTypeSurroundsWith);
            this.pnlConfigSnippetType.Location = new System.Drawing.Point(92, 40);
            this.pnlConfigSnippetType.Name = "pnlConfigSnippetType";
            this.pnlConfigSnippetType.Size = new System.Drawing.Size(266, 20);
            this.pnlConfigSnippetType.TabIndex = 10;
            // 
            // radConfigTypeExpansion
            // 
            this.radConfigTypeExpansion.AutoSize = true;
            this.radConfigTypeExpansion.Location = new System.Drawing.Point(112, 2);
            this.radConfigTypeExpansion.Name = "radConfigTypeExpansion";
            this.radConfigTypeExpansion.Size = new System.Drawing.Size(74, 17);
            this.radConfigTypeExpansion.TabIndex = 13;
            this.radConfigTypeExpansion.Text = "Expansion";
            this.radConfigTypeExpansion.UseVisualStyleBackColor = true;
            // 
            // radConfigTypeSurroundsWith
            // 
            this.radConfigTypeSurroundsWith.AutoSize = true;
            this.radConfigTypeSurroundsWith.Location = new System.Drawing.Point(11, 2);
            this.radConfigTypeSurroundsWith.Name = "radConfigTypeSurroundsWith";
            this.radConfigTypeSurroundsWith.Size = new System.Drawing.Size(95, 17);
            this.radConfigTypeSurroundsWith.TabIndex = 12;
            this.radConfigTypeSurroundsWith.Text = "SurroundsWith";
            this.radConfigTypeSurroundsWith.UseVisualStyleBackColor = true;
            // 
            // pnlConfigPlatform
            // 
            this.pnlConfigPlatform.Controls.Add(this.radConfigPlatformNone);
            this.pnlConfigPlatform.Controls.Add(this.radConfigPlatformVS);
            this.pnlConfigPlatform.Controls.Add(this.radConfigPlatformSSMS);
            this.pnlConfigPlatform.Location = new System.Drawing.Point(92, 65);
            this.pnlConfigPlatform.Name = "pnlConfigPlatform";
            this.pnlConfigPlatform.Size = new System.Drawing.Size(266, 20);
            this.pnlConfigPlatform.TabIndex = 12;
            // 
            // radConfigPlatformVS
            // 
            this.radConfigPlatformVS.AutoSize = true;
            this.radConfigPlatformVS.Location = new System.Drawing.Point(112, 2);
            this.radConfigPlatformVS.Name = "radConfigPlatformVS";
            this.radConfigPlatformVS.Size = new System.Drawing.Size(39, 17);
            this.radConfigPlatformVS.TabIndex = 13;
            this.radConfigPlatformVS.Text = "VS";
            this.radConfigPlatformVS.UseVisualStyleBackColor = true;
            // 
            // radConfigPlatformSSMS
            // 
            this.radConfigPlatformSSMS.AutoSize = true;
            this.radConfigPlatformSSMS.Location = new System.Drawing.Point(11, 2);
            this.radConfigPlatformSSMS.Name = "radConfigPlatformSSMS";
            this.radConfigPlatformSSMS.Size = new System.Drawing.Size(55, 17);
            this.radConfigPlatformSSMS.TabIndex = 12;
            this.radConfigPlatformSSMS.Text = "SSMS";
            this.radConfigPlatformSSMS.UseVisualStyleBackColor = true;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(21, 69);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(45, 13);
            this.lblPlatform.TabIndex = 11;
            this.lblPlatform.Text = "Platform";
            // 
            // radConfigPlatformNone
            // 
            this.radConfigPlatformNone.AutoSize = true;
            this.radConfigPlatformNone.Checked = true;
            this.radConfigPlatformNone.Location = new System.Drawing.Point(193, 2);
            this.radConfigPlatformNone.Name = "radConfigPlatformNone";
            this.radConfigPlatformNone.Size = new System.Drawing.Size(51, 17);
            this.radConfigPlatformNone.TabIndex = 14;
            this.radConfigPlatformNone.TabStop = true;
            this.radConfigPlatformNone.Text = "None";
            this.radConfigPlatformNone.UseVisualStyleBackColor = true;
            // 
            // radConfigTypeNone
            // 
            this.radConfigTypeNone.AutoSize = true;
            this.radConfigTypeNone.Checked = true;
            this.radConfigTypeNone.Location = new System.Drawing.Point(193, 2);
            this.radConfigTypeNone.Name = "radConfigTypeNone";
            this.radConfigTypeNone.Size = new System.Drawing.Size(51, 17);
            this.radConfigTypeNone.TabIndex = 15;
            this.radConfigTypeNone.TabStop = true;
            this.radConfigTypeNone.Text = "None";
            this.radConfigTypeNone.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 239);
            this.Controls.Add(this.pnlConfigPlatform);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.pnlConfigSnippetType);
            this.Controls.Add(this.lblSnippetType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOutputs);
            this.Controls.Add(this.txtDefaultVisualStudioPath);
            this.Controls.Add(this.txtDefaultSSMSPath);
            this.Controls.Add(this.txtDefaultAuthor);
            this.Controls.Add(this.lblSSMSPath);
            this.Controls.Add(this.lblVisualStudioPath);
            this.Controls.Add(this.lblDefaultAuthor);
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.pnlConfigSnippetType.ResumeLayout(false);
            this.pnlConfigSnippetType.PerformLayout();
            this.pnlConfigPlatform.ResumeLayout(false);
            this.pnlConfigPlatform.PerformLayout();
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
        private System.Windows.Forms.Label lblSnippetType;
        private System.Windows.Forms.Panel pnlConfigSnippetType;
        private System.Windows.Forms.RadioButton radConfigTypeExpansion;
        private System.Windows.Forms.RadioButton radConfigTypeSurroundsWith;
        private System.Windows.Forms.Panel pnlConfigPlatform;
        private System.Windows.Forms.RadioButton radConfigPlatformVS;
        private System.Windows.Forms.RadioButton radConfigPlatformSSMS;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.RadioButton radConfigPlatformNone;
        private System.Windows.Forms.RadioButton radConfigTypeNone;
    }
}