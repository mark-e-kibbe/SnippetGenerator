namespace SnippetGenerator
{
    partial class MainForm
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
            this.btnUnapply = new System.Windows.Forms.Button();
            this.lstboxAppliedLiterals = new System.Windows.Forms.ListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRemoveFromUnapplied = new System.Windows.Forms.Button();
            this.btnAddLiteral = new System.Windows.Forms.Button();
            this.lstboxUnappliedLiterals = new System.Windows.Forms.ListBox();
            this.lblLiterals = new System.Windows.Forms.Label();
            this.txtLiteralID = new System.Windows.Forms.TextBox();
            this.txtLiteralToolTip = new System.Windows.Forms.TextBox();
            this.txtLiteralDefault = new System.Windows.Forms.TextBox();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblLiteralsToolTip = new System.Windows.Forms.Label();
            this.lblLiteralID = new System.Windows.Forms.Label();
            this.txtCodeToSnippet = new System.Windows.Forms.RichTextBox();
            this.btnGenerateAndSave = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlSnippetType = new System.Windows.Forms.Panel();
            this.radExpansion = new System.Windows.Forms.RadioButton();
            this.radSurroundsWith = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.grpBoxPlatform = new System.Windows.Forms.GroupBox();
            this.radVS = new System.Windows.Forms.RadioButton();
            this.radSSMS = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOutputDirectory = new System.Windows.Forms.Button();
            this.pnlMetaData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSnippetType.SuspendLayout();
            this.grpBoxPlatform.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.pnlMetaData.Location = new System.Drawing.Point(18, 112);
            this.pnlMetaData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMetaData.Name = "pnlMetaData";
            this.pnlMetaData.Size = new System.Drawing.Size(272, 209);
            this.pnlMetaData.TabIndex = 3;
            // 
            // lblMetadata
            // 
            this.lblMetadata.AutoSize = true;
            this.lblMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMetadata.Location = new System.Drawing.Point(78, 11);
            this.lblMetadata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetadata.Name = "lblMetadata";
            this.lblMetadata.Size = new System.Drawing.Size(118, 29);
            this.lblMetadata.TabIndex = 0;
            this.lblMetadata.Text = "Metadata";
            this.lblMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMetadataTitle
            // 
            this.txtMetadataTitle.Location = new System.Drawing.Point(105, 51);
            this.txtMetadataTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetadataTitle.Name = "txtMetadataTitle";
            this.txtMetadataTitle.Size = new System.Drawing.Size(148, 26);
            this.txtMetadataTitle.TabIndex = 2;
            // 
            // txtMetadataAuthor
            // 
            this.txtMetadataAuthor.Location = new System.Drawing.Point(105, 171);
            this.txtMetadataAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetadataAuthor.Name = "txtMetadataAuthor";
            this.txtMetadataAuthor.Size = new System.Drawing.Size(148, 26);
            this.txtMetadataAuthor.TabIndex = 8;
            // 
            // txtMetadataShortcut
            // 
            this.txtMetadataShortcut.Location = new System.Drawing.Point(105, 91);
            this.txtMetadataShortcut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetadataShortcut.Name = "txtMetadataShortcut";
            this.txtMetadataShortcut.Size = new System.Drawing.Size(148, 26);
            this.txtMetadataShortcut.TabIndex = 4;
            // 
            // txtMetadataDescription
            // 
            this.txtMetadataDescription.Location = new System.Drawing.Point(105, 131);
            this.txtMetadataDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetadataDescription.Name = "txtMetadataDescription";
            this.txtMetadataDescription.Size = new System.Drawing.Size(148, 26);
            this.txtMetadataDescription.TabIndex = 6;
            // 
            // lblMetadataAuthor
            // 
            this.lblMetadataAuthor.AutoSize = true;
            this.lblMetadataAuthor.Location = new System.Drawing.Point(4, 175);
            this.lblMetadataAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetadataAuthor.Name = "lblMetadataAuthor";
            this.lblMetadataAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblMetadataAuthor.TabIndex = 7;
            this.lblMetadataAuthor.Text = "Author";
            // 
            // lblMetadataDescription
            // 
            this.lblMetadataDescription.AutoSize = true;
            this.lblMetadataDescription.Location = new System.Drawing.Point(4, 135);
            this.lblMetadataDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetadataDescription.Name = "lblMetadataDescription";
            this.lblMetadataDescription.Size = new System.Drawing.Size(89, 20);
            this.lblMetadataDescription.TabIndex = 5;
            this.lblMetadataDescription.Text = "Description";
            // 
            // lblMetadataShortcut
            // 
            this.lblMetadataShortcut.AutoSize = true;
            this.lblMetadataShortcut.Location = new System.Drawing.Point(4, 95);
            this.lblMetadataShortcut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetadataShortcut.Name = "lblMetadataShortcut";
            this.lblMetadataShortcut.Size = new System.Drawing.Size(70, 20);
            this.lblMetadataShortcut.TabIndex = 3;
            this.lblMetadataShortcut.Text = "Shortcut";
            // 
            // lblMetadataTitle
            // 
            this.lblMetadataTitle.AutoSize = true;
            this.lblMetadataTitle.Location = new System.Drawing.Point(4, 55);
            this.lblMetadataTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetadataTitle.Name = "lblMetadataTitle";
            this.lblMetadataTitle.Size = new System.Drawing.Size(38, 20);
            this.lblMetadataTitle.TabIndex = 1;
            this.lblMetadataTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnapply);
            this.panel1.Controls.Add(this.lstboxAppliedLiterals);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnRemoveFromUnapplied);
            this.panel1.Controls.Add(this.btnAddLiteral);
            this.panel1.Controls.Add(this.lstboxUnappliedLiterals);
            this.panel1.Controls.Add(this.lblLiterals);
            this.panel1.Controls.Add(this.txtLiteralID);
            this.panel1.Controls.Add(this.txtLiteralToolTip);
            this.panel1.Controls.Add(this.txtLiteralDefault);
            this.panel1.Controls.Add(this.lblDefault);
            this.panel1.Controls.Add(this.lblLiteralsToolTip);
            this.panel1.Controls.Add(this.lblLiteralID);
            this.panel1.Location = new System.Drawing.Point(298, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 245);
            this.panel1.TabIndex = 4;
            // 
            // btnUnapply
            // 
            this.btnUnapply.Enabled = false;
            this.btnUnapply.Location = new System.Drawing.Point(405, 205);
            this.btnUnapply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnapply.Name = "btnUnapply";
            this.btnUnapply.Size = new System.Drawing.Size(117, 35);
            this.btnUnapply.TabIndex = 12;
            this.btnUnapply.Text = "Unapply";
            this.btnUnapply.UseVisualStyleBackColor = true;
            this.btnUnapply.Click += new System.EventHandler(this.btnUnapply_Click);
            // 
            // lstboxAppliedLiterals
            // 
            this.lstboxAppliedLiterals.FormattingEnabled = true;
            this.lstboxAppliedLiterals.ItemHeight = 20;
            this.lstboxAppliedLiterals.Location = new System.Drawing.Point(405, 15);
            this.lstboxAppliedLiterals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstboxAppliedLiterals.Name = "lstboxAppliedLiterals";
            this.lstboxAppliedLiterals.Size = new System.Drawing.Size(117, 184);
            this.lstboxAppliedLiterals.TabIndex = 11;
            this.lstboxAppliedLiterals.SelectedIndexChanged += new System.EventHandler(this.lstboxAppliedLiterals_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(4, 205);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 35);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnRemoveFromUnapplied
            // 
            this.btnRemoveFromUnapplied.Enabled = false;
            this.btnRemoveFromUnapplied.Location = new System.Drawing.Point(290, 167);
            this.btnRemoveFromUnapplied.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveFromUnapplied.Name = "btnRemoveFromUnapplied";
            this.btnRemoveFromUnapplied.Size = new System.Drawing.Size(80, 35);
            this.btnRemoveFromUnapplied.TabIndex = 8;
            this.btnRemoveFromUnapplied.Text = "Remove";
            this.btnRemoveFromUnapplied.UseVisualStyleBackColor = true;
            this.btnRemoveFromUnapplied.Click += new System.EventHandler(this.btnRemoveFromUnapplied_Click);
            // 
            // btnAddLiteral
            // 
            this.btnAddLiteral.Location = new System.Drawing.Point(183, 167);
            this.btnAddLiteral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddLiteral.Name = "btnAddLiteral";
            this.btnAddLiteral.Size = new System.Drawing.Size(94, 35);
            this.btnAddLiteral.TabIndex = 7;
            this.btnAddLiteral.Text = "Add Literal";
            this.btnAddLiteral.UseVisualStyleBackColor = true;
            this.btnAddLiteral.Click += new System.EventHandler(this.btnAddLiteral_Click);
            // 
            // lstboxUnappliedLiterals
            // 
            this.lstboxUnappliedLiterals.FormattingEnabled = true;
            this.lstboxUnappliedLiterals.ItemHeight = 20;
            this.lstboxUnappliedLiterals.Location = new System.Drawing.Point(4, 15);
            this.lstboxUnappliedLiterals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstboxUnappliedLiterals.Name = "lstboxUnappliedLiterals";
            this.lstboxUnappliedLiterals.Size = new System.Drawing.Size(117, 184);
            this.lstboxUnappliedLiterals.TabIndex = 9;
            this.lstboxUnappliedLiterals.SelectedIndexChanged += new System.EventHandler(this.lstboxUnappliedLiterals_SelectedIndexChanged);
            // 
            // lblLiterals
            // 
            this.lblLiterals.AutoSize = true;
            this.lblLiterals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLiterals.Location = new System.Drawing.Point(209, 11);
            this.lblLiterals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiterals.Name = "lblLiterals";
            this.lblLiterals.Size = new System.Drawing.Size(95, 29);
            this.lblLiterals.TabIndex = 0;
            this.lblLiterals.Text = "Literals";
            this.lblLiterals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLiteralID
            // 
            this.txtLiteralID.Location = new System.Drawing.Point(236, 51);
            this.txtLiteralID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLiteralID.Name = "txtLiteralID";
            this.txtLiteralID.Size = new System.Drawing.Size(148, 26);
            this.txtLiteralID.TabIndex = 2;
            // 
            // txtLiteralToolTip
            // 
            this.txtLiteralToolTip.Location = new System.Drawing.Point(236, 91);
            this.txtLiteralToolTip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLiteralToolTip.Name = "txtLiteralToolTip";
            this.txtLiteralToolTip.Size = new System.Drawing.Size(148, 26);
            this.txtLiteralToolTip.TabIndex = 4;
            // 
            // txtLiteralDefault
            // 
            this.txtLiteralDefault.Location = new System.Drawing.Point(236, 131);
            this.txtLiteralDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLiteralDefault.Name = "txtLiteralDefault";
            this.txtLiteralDefault.Size = new System.Drawing.Size(148, 26);
            this.txtLiteralDefault.TabIndex = 6;
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.Location = new System.Drawing.Point(135, 135);
            this.lblDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(61, 20);
            this.lblDefault.TabIndex = 5;
            this.lblDefault.Text = "Default";
            // 
            // lblLiteralsToolTip
            // 
            this.lblLiteralsToolTip.AutoSize = true;
            this.lblLiteralsToolTip.Location = new System.Drawing.Point(135, 95);
            this.lblLiteralsToolTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiteralsToolTip.Name = "lblLiteralsToolTip";
            this.lblLiteralsToolTip.Size = new System.Drawing.Size(60, 20);
            this.lblLiteralsToolTip.TabIndex = 3;
            this.lblLiteralsToolTip.Text = "ToolTip";
            // 
            // lblLiteralID
            // 
            this.lblLiteralID.AutoSize = true;
            this.lblLiteralID.Location = new System.Drawing.Point(135, 55);
            this.lblLiteralID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiteralID.Name = "lblLiteralID";
            this.lblLiteralID.Size = new System.Drawing.Size(26, 20);
            this.lblLiteralID.TabIndex = 1;
            this.lblLiteralID.Text = "ID";
            // 
            // txtCodeToSnippet
            // 
            this.txtCodeToSnippet.Location = new System.Drawing.Point(18, 367);
            this.txtCodeToSnippet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeToSnippet.Name = "txtCodeToSnippet";
            this.txtCodeToSnippet.Size = new System.Drawing.Size(812, 173);
            this.txtCodeToSnippet.TabIndex = 5;
            this.txtCodeToSnippet.Text = "";
            // 
            // btnGenerateAndSave
            // 
            this.btnGenerateAndSave.Location = new System.Drawing.Point(167, 582);
            this.btnGenerateAndSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateAndSave.Name = "btnGenerateAndSave";
            this.btnGenerateAndSave.Size = new System.Drawing.Size(164, 35);
            this.btnGenerateAndSave.TabIndex = 8;
            this.btnGenerateAndSave.Text = "Generate and Save";
            this.btnGenerateAndSave.UseVisualStyleBackColor = true;
            this.btnGenerateAndSave.Click += new System.EventHandler(this.BtnGenerateAndSave_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(22, 551);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(133, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output Directory :";
            // 
            // pnlSnippetType
            // 
            this.pnlSnippetType.Controls.Add(this.radExpansion);
            this.pnlSnippetType.Controls.Add(this.radSurroundsWith);
            this.pnlSnippetType.Controls.Add(this.label1);
            this.pnlSnippetType.Location = new System.Drawing.Point(390, 45);
            this.pnlSnippetType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSnippetType.Name = "pnlSnippetType";
            this.pnlSnippetType.Size = new System.Drawing.Size(440, 57);
            this.pnlSnippetType.TabIndex = 2;
            // 
            // radExpansion
            // 
            this.radExpansion.AutoSize = true;
            this.radExpansion.Location = new System.Drawing.Point(170, 15);
            this.radExpansion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radExpansion.Name = "radExpansion";
            this.radExpansion.Size = new System.Drawing.Size(108, 24);
            this.radExpansion.TabIndex = 1;
            this.radExpansion.Text = "Expansion";
            this.radExpansion.UseVisualStyleBackColor = true;
            // 
            // radSurroundsWith
            // 
            this.radSurroundsWith.AutoSize = true;
            this.radSurroundsWith.Location = new System.Drawing.Point(290, 15);
            this.radSurroundsWith.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSurroundsWith.Name = "radSurroundsWith";
            this.radSurroundsWith.Size = new System.Drawing.Size(140, 24);
            this.radSurroundsWith.TabIndex = 2;
            this.radSurroundsWith.TabStop = true;
            this.radSurroundsWith.Text = "SurroundsWith";
            this.radSurroundsWith.UseVisualStyleBackColor = true;
            this.radSurroundsWith.CheckedChanged += new System.EventHandler(this.radSurroundsWith_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snippet Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Enabled = false;
            this.txtOutputDirectory.Location = new System.Drawing.Point(216, 547);
            this.txtOutputDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(530, 26);
            this.txtOutputDirectory.TabIndex = 7;
            // 
            // grpBoxPlatform
            // 
            this.grpBoxPlatform.Controls.Add(this.radVS);
            this.grpBoxPlatform.Controls.Add(this.radSSMS);
            this.grpBoxPlatform.Location = new System.Drawing.Point(50, 38);
            this.grpBoxPlatform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPlatform.Name = "grpBoxPlatform";
            this.grpBoxPlatform.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPlatform.Size = new System.Drawing.Size(164, 65);
            this.grpBoxPlatform.TabIndex = 1;
            this.grpBoxPlatform.TabStop = false;
            this.grpBoxPlatform.Text = "Platform";
            // 
            // radVS
            // 
            this.radVS.AutoSize = true;
            this.radVS.Location = new System.Drawing.Point(96, 23);
            this.radVS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radVS.Name = "radVS";
            this.radVS.Size = new System.Drawing.Size(56, 24);
            this.radVS.TabIndex = 1;
            this.radVS.Text = "VS";
            this.radVS.UseVisualStyleBackColor = true;
            this.radVS.CheckedChanged += new System.EventHandler(this.radVS_CheckedChanged);
            // 
            // radSSMS
            // 
            this.radSSMS.AutoSize = true;
            this.radSSMS.Location = new System.Drawing.Point(4, 23);
            this.radSSMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSSMS.Name = "radSSMS";
            this.radSSMS.Size = new System.Drawing.Size(80, 24);
            this.radSSMS.TabIndex = 0;
            this.radSSMS.TabStop = true;
            this.radSSMS.Text = "SSMS";
            this.radSSMS.UseVisualStyleBackColor = true;
            this.radSSMS.CheckedChanged += new System.EventHandler(this.radSSMS_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(340, 582);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear All Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.Location = new System.Drawing.Point(512, 582);
            this.btnResetDefaults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(164, 35);
            this.btnResetDefaults.TabIndex = 0;
            this.btnResetDefaults.Text = "Reset Defaults";
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(843, 35);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.configurationsToolStripMenuItem.Text = "Settings";
            this.configurationsToolStripMenuItem.Click += new System.EventHandler(this.configurationsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // btnOutputDirectory
            // 
            this.btnOutputDirectory.Location = new System.Drawing.Point(754, 545);
            this.btnOutputDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutputDirectory.Name = "btnOutputDirectory";
            this.btnOutputDirectory.Size = new System.Drawing.Size(76, 31);
            this.btnOutputDirectory.TabIndex = 11;
            this.btnOutputDirectory.Text = "Pick";
            this.btnOutputDirectory.UseVisualStyleBackColor = true;
            this.btnOutputDirectory.Click += new System.EventHandler(this.btnOutputDirectory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 618);
            this.Controls.Add(this.btnOutputDirectory);
            this.Controls.Add(this.btnResetDefaults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpBoxPlatform);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.pnlSnippetType);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGenerateAndSave);
            this.Controls.Add(this.txtCodeToSnippet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMetaData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Snippet Generator";
            this.pnlMetaData.ResumeLayout(false);
            this.pnlMetaData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSnippetType.ResumeLayout(false);
            this.pnlSnippetType.PerformLayout();
            this.grpBoxPlatform.ResumeLayout(false);
            this.grpBoxPlatform.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtLiteralToolTip;
        private System.Windows.Forms.TextBox txtLiteralDefault;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.Label lblLiteralsToolTip;
        private System.Windows.Forms.Label lblLiteralID;
        private System.Windows.Forms.RichTextBox txtCodeToSnippet;
        private System.Windows.Forms.ListBox lstboxUnappliedLiterals;
        private System.Windows.Forms.Button btnRemoveFromUnapplied;
        private System.Windows.Forms.Button btnAddLiteral;
        private System.Windows.Forms.Button btnGenerateAndSave;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel pnlSnippetType;
        private System.Windows.Forms.RadioButton radSurroundsWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radExpansion;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.GroupBox grpBoxPlatform;
        private System.Windows.Forms.RadioButton radVS;
        private System.Windows.Forms.RadioButton radSSMS;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResetDefaults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOutputDirectory;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ListBox lstboxAppliedLiterals;
        private System.Windows.Forms.Button btnUnapply;
    }
}

