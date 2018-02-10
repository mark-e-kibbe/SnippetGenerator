namespace SnippetGenerator
{
    partial class Main
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
            this.pnlMetaData = new System.Windows.Forms.Panel();
            this.lblMetadata = new System.Windows.Forms.Label();
            this.txtMetadataTitle = new System.Windows.Forms.TextBox();
            this.txtMetadataAuthor = new System.Windows.Forms.TextBox();
            this.txtMetadataShortcut = new System.Windows.Forms.TextBox();
            this.txtMetadataDescription = new System.Windows.Forms.TextBox();
            this.lblMetadataAuthor = new System.Windows.Forms.Label();
            this.lblMetadataDescription = new System.Windows.Forms.Label();
            this.lblMetadataShortcut = new System.Windows.Forms.Label();
            this.lblMetadataTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLiterals = new System.Windows.Forms.Label();
            this.txtLiteralID = new System.Windows.Forms.TextBox();
            this.txtToolTip = new System.Windows.Forms.TextBox();
            this.txtLiteralDefault = new System.Windows.Forms.TextBox();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblLiteralsToolTip = new System.Windows.Forms.Label();
            this.lblLiteralID = new System.Windows.Forms.Label();
            this.txtCodeToSnippet = new System.Windows.Forms.TextBox();
            this.pnlMetaData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMetaData
            // 
            this.pnlMetaData.Controls.Add(this.lblMetadata);
            this.pnlMetaData.Controls.Add(this.txtMetadataTitle);
            this.pnlMetaData.Controls.Add(this.txtMetadataAuthor);
            this.pnlMetaData.Controls.Add(this.txtMetadataShortcut);
            this.pnlMetaData.Controls.Add(this.txtMetadataDescription);
            this.pnlMetaData.Controls.Add(this.lblMetadataAuthor);
            this.pnlMetaData.Controls.Add(this.lblMetadataDescription);
            this.pnlMetaData.Controls.Add(this.lblMetadataShortcut);
            this.pnlMetaData.Controls.Add(this.lblMetadataTitle);
            this.pnlMetaData.Location = new System.Drawing.Point(12, 12);
            this.pnlMetaData.Name = "pnlMetaData";
            this.pnlMetaData.Size = new System.Drawing.Size(181, 136);
            this.pnlMetaData.TabIndex = 0;
            // 
            // lblMetadata
            // 
            this.lblMetadata.AutoSize = true;
            this.lblMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMetadata.Location = new System.Drawing.Point(52, 7);
            this.lblMetadata.Name = "lblMetadata";
            this.lblMetadata.Size = new System.Drawing.Size(78, 20);
            this.lblMetadata.TabIndex = 8;
            this.lblMetadata.Text = "Metadata";
            this.lblMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMetadataTitle
            // 
            this.txtMetadataTitle.Location = new System.Drawing.Point(70, 33);
            this.txtMetadataTitle.Name = "txtMetadataTitle";
            this.txtMetadataTitle.Size = new System.Drawing.Size(100, 20);
            this.txtMetadataTitle.TabIndex = 7;
            // 
            // txtMetadataAuthor
            // 
            this.txtMetadataAuthor.Location = new System.Drawing.Point(70, 111);
            this.txtMetadataAuthor.Name = "txtMetadataAuthor";
            this.txtMetadataAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtMetadataAuthor.TabIndex = 6;
            // 
            // txtMetadataShortcut
            // 
            this.txtMetadataShortcut.Location = new System.Drawing.Point(70, 59);
            this.txtMetadataShortcut.Name = "txtMetadataShortcut";
            this.txtMetadataShortcut.Size = new System.Drawing.Size(100, 20);
            this.txtMetadataShortcut.TabIndex = 5;
            // 
            // txtMetadataDescription
            // 
            this.txtMetadataDescription.Location = new System.Drawing.Point(70, 85);
            this.txtMetadataDescription.Name = "txtMetadataDescription";
            this.txtMetadataDescription.Size = new System.Drawing.Size(100, 20);
            this.txtMetadataDescription.TabIndex = 4;
            // 
            // lblMetadataAuthor
            // 
            this.lblMetadataAuthor.AutoSize = true;
            this.lblMetadataAuthor.Location = new System.Drawing.Point(3, 114);
            this.lblMetadataAuthor.Name = "lblMetadataAuthor";
            this.lblMetadataAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblMetadataAuthor.TabIndex = 3;
            this.lblMetadataAuthor.Text = "Author";
            // 
            // lblMetadataDescription
            // 
            this.lblMetadataDescription.AutoSize = true;
            this.lblMetadataDescription.Location = new System.Drawing.Point(3, 88);
            this.lblMetadataDescription.Name = "lblMetadataDescription";
            this.lblMetadataDescription.Size = new System.Drawing.Size(60, 13);
            this.lblMetadataDescription.TabIndex = 2;
            this.lblMetadataDescription.Text = "Description";
            // 
            // lblMetadataShortcut
            // 
            this.lblMetadataShortcut.AutoSize = true;
            this.lblMetadataShortcut.Location = new System.Drawing.Point(3, 62);
            this.lblMetadataShortcut.Name = "lblMetadataShortcut";
            this.lblMetadataShortcut.Size = new System.Drawing.Size(47, 13);
            this.lblMetadataShortcut.TabIndex = 1;
            this.lblMetadataShortcut.Text = "Shortcut";
            // 
            // lblMetadataTitle
            // 
            this.lblMetadataTitle.AutoSize = true;
            this.lblMetadataTitle.Location = new System.Drawing.Point(3, 36);
            this.lblMetadataTitle.Name = "lblMetadataTitle";
            this.lblMetadataTitle.Size = new System.Drawing.Size(27, 13);
            this.lblMetadataTitle.TabIndex = 0;
            this.lblMetadataTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLiterals);
            this.panel1.Controls.Add(this.txtLiteralID);
            this.panel1.Controls.Add(this.txtToolTip);
            this.panel1.Controls.Add(this.txtLiteralDefault);
            this.panel1.Controls.Add(this.lblDefault);
            this.panel1.Controls.Add(this.lblLiteralsToolTip);
            this.panel1.Controls.Add(this.lblLiteralID);
            this.panel1.Location = new System.Drawing.Point(285, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 136);
            this.panel1.TabIndex = 9;
            // 
            // lblLiterals
            // 
            this.lblLiterals.AutoSize = true;
            this.lblLiterals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLiterals.Location = new System.Drawing.Point(52, 7);
            this.lblLiterals.Name = "lblLiterals";
            this.lblLiterals.Size = new System.Drawing.Size(65, 20);
            this.lblLiterals.TabIndex = 8;
            this.lblLiterals.Text = "Literals";
            this.lblLiterals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLiteralID
            // 
            this.txtLiteralID.Location = new System.Drawing.Point(70, 33);
            this.txtLiteralID.Name = "txtLiteralID";
            this.txtLiteralID.Size = new System.Drawing.Size(100, 20);
            this.txtLiteralID.TabIndex = 7;
            // 
            // txtToolTip
            // 
            this.txtToolTip.Location = new System.Drawing.Point(70, 59);
            this.txtToolTip.Name = "txtToolTip";
            this.txtToolTip.Size = new System.Drawing.Size(100, 20);
            this.txtToolTip.TabIndex = 5;
            // 
            // txtLiteralDefault
            // 
            this.txtLiteralDefault.Location = new System.Drawing.Point(70, 85);
            this.txtLiteralDefault.Name = "txtLiteralDefault";
            this.txtLiteralDefault.Size = new System.Drawing.Size(100, 20);
            this.txtLiteralDefault.TabIndex = 4;
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.Location = new System.Drawing.Point(3, 88);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(41, 13);
            this.lblDefault.TabIndex = 2;
            this.lblDefault.Text = "Default";
            // 
            // lblLiteralsToolTip
            // 
            this.lblLiteralsToolTip.AutoSize = true;
            this.lblLiteralsToolTip.Location = new System.Drawing.Point(3, 62);
            this.lblLiteralsToolTip.Name = "lblLiteralsToolTip";
            this.lblLiteralsToolTip.Size = new System.Drawing.Size(43, 13);
            this.lblLiteralsToolTip.TabIndex = 1;
            this.lblLiteralsToolTip.Text = "ToolTip";
            // 
            // lblLiteralID
            // 
            this.lblLiteralID.AutoSize = true;
            this.lblLiteralID.Location = new System.Drawing.Point(3, 36);
            this.lblLiteralID.Name = "lblLiteralID";
            this.lblLiteralID.Size = new System.Drawing.Size(18, 13);
            this.lblLiteralID.TabIndex = 0;
            this.lblLiteralID.Text = "ID";
            // 
            // txtCodeToSnippet
            // 
            this.txtCodeToSnippet.Location = new System.Drawing.Point(12, 154);
            this.txtCodeToSnippet.Multiline = true;
            this.txtCodeToSnippet.Name = "txtCodeToSnippet";
            this.txtCodeToSnippet.Size = new System.Drawing.Size(454, 114);
            this.txtCodeToSnippet.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 395);
            this.Controls.Add(this.txtCodeToSnippet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMetaData);
            this.Name = "Main";
            this.Text = "Snippet Generator";
            this.pnlMetaData.ResumeLayout(false);
            this.pnlMetaData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMetaData;
        private System.Windows.Forms.Label lblMetadata;
        private System.Windows.Forms.TextBox txtMetadataTitle;
        private System.Windows.Forms.TextBox txtMetadataAuthor;
        private System.Windows.Forms.TextBox txtMetadataShortcut;
        private System.Windows.Forms.TextBox txtMetadataDescription;
        private System.Windows.Forms.Label lblMetadataAuthor;
        private System.Windows.Forms.Label lblMetadataDescription;
        private System.Windows.Forms.Label lblMetadataShortcut;
        private System.Windows.Forms.Label lblMetadataTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLiterals;
        private System.Windows.Forms.TextBox txtLiteralID;
        private System.Windows.Forms.TextBox txtToolTip;
        private System.Windows.Forms.TextBox txtLiteralDefault;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.Label lblLiteralsToolTip;
        private System.Windows.Forms.Label lblLiteralID;
        private System.Windows.Forms.TextBox txtCodeToSnippet;
    }
}

