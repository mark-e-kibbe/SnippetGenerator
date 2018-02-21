using SnippetGenerator.Models;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippetGenerator
{
    public partial class MainForm : Form
    {
        private const string LblOutputDefault_Text = "Output Directory :";
        private Snippet _Snippet = new Snippet();

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        private void BtnGenerateAndSave_Click(object sender, EventArgs e)
        {
            ProcessFormData(_Snippet);

            //TODO Make This Better, Currently functional using title for the filename
            _Snippet.Save($@"{txtOutputDirectory.Text}\{_Snippet._Metadata._Title}.snippet");
        }

        private void InitializeDefaults()
        { 
            Configuration config = new Configuration();

            txtMetadataAuthor.Text = config.Author;
            
            switch (config.Platform)
            {
                case PlatformEnums.SSMS:
                    radSSMS.Checked = true;
                    lblOutput.Text = $"{radSSMS.Text} {LblOutputDefault_Text}";
                    txtOutputDirectory.Text = config.SSMSOutputFilePath;
                    break;
                case PlatformEnums.VS:
                    radVS.Checked = true;
                    lblOutput.Text = $"{radVS.Text} {LblOutputDefault_Text}";
                    txtOutputDirectory.Text = config.VStudioOutputFilePath;
                    break;
                default:
                    radSSMS.Checked = false;
                    radSSMS.TabStop = true;
                    radVS.Checked = false;
                    lblOutput.Text = LblOutputDefault_Text;
                    txtOutputDirectory.Text = string.Empty;
                    break;
            }

            switch (config.SnippetType)
            {
                case SnippetTypeEnums.Expansion:
                    radExpansion.Checked = true;
                    break;
                case SnippetTypeEnums.SurroundsWith:
                    radSurroundsWith.Checked = true;
                    break;
                default:
                    radExpansion.Checked = false;
                    radExpansion.TabStop = true;
                    radSurroundsWith.Checked = false;
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            radSSMS.Checked = false;
            radSSMS.TabStop = true;
            radVS.Checked = false;
            radExpansion.Checked = false;
            radExpansion.TabStop = true;
            radSurroundsWith.Checked = false;
            lblOutput.Text = LblOutputDefault_Text;
            txtMetadataAuthor.Text = string.Empty;
            txtMetadataDescription.Text = string.Empty;
            txtMetadataShortcut.Text = string.Empty;
            txtMetadataTitle.Text = string.Empty;
            txtOutputDirectory.Text = string.Empty;
            txtLiteralID.Text = string.Empty;
            txtLiteralToolTip.Text = string.Empty;
            txtLiteralDefault.Text = string.Empty;
            txtCodeToSnippet.Text = string.Empty;
            lstboxLiterals.Items.Clear();
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            Clear();
            InitializeDefaults();
        }

        private void radSSMS_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = LblOutputDefault_Text;
            if (radSSMS.Checked == true)
            {
                lblOutput.Text = $"{radSSMS.Text} {LblOutputDefault_Text}";
                txtOutputDirectory.Text = new Configuration().SSMSOutputFilePath;
            }
        }

        private void radVS_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = LblOutputDefault_Text;
            if (radVS.Checked == true)
            {
                lblOutput.Text = $"{radVS.Text} {LblOutputDefault_Text}";
                txtOutputDirectory.Text = new Configuration().VStudioOutputFilePath;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ConfigurationForm();
            configForm.ShowDialog();
            InitializeDefaults();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create about form
        }

        private void ProcessFormData(Snippet snippet)
        {
            snippet._Metadata._Author = txtMetadataAuthor.Text;
            snippet._Metadata._Description = txtMetadataDescription.Text;
            snippet._Metadata._Shortcut = txtMetadataShortcut.Text;
            snippet._Metadata._Title = txtMetadataTitle.Text;
            snippet._Metadata._SnippetType = Utilities.EnumParseToSnippetTypeEnum(pnlSnippetType);

            _Snippet.CodeToSnippet = txtCodeToSnippet.Text;

            snippet._Platform = Utilities.EnumParseToSnippetTypeEnum(grpBoxPlatform);
        }
    }
}
