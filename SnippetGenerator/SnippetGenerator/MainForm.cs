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
        private Snippet _Snippet = new Snippet();

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        private void btnGenerateAndSave_Click(object sender, EventArgs e)
        {
            _Snippet.CompleteSnippetToXMLString();

            _Snippet.Save(txtOutputDirectory.Text);
        }

        private void InitializeDefaults()
        { 
            Configuration config = new Configuration();

            txtMetadataAuthor.Text = config.Author;
            
            switch (config.Platform)
            {
                case PlatformEnums.SSMS:
                    radSSMS.Checked = true;
                    lblOutput.Text = $"{radSSMS.Text} {lblOutput.Text}";
                    txtOutputDirectory.Text = config.SSMSOutputFilePath;
                    break;
                case PlatformEnums.VS:
                    radVS.Checked = true;
                    lblOutput.Text = $"{radVS.Text} {lblOutput.Text}";
                    txtOutputDirectory.Text = config.VStudioOutputFilePath;
                    break;
                default:
                    radSSMS.Checked = false;
                    radSSMS.TabStop = true;
                    radVS.Checked = false;
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
            lblOutput.Text = "Output Directory :";
            if (radSSMS.Checked == true)
            {
                lblOutput.Text = $"{radSSMS.Text} {lblOutput.Text}";
                txtOutputDirectory.Text = new Configuration().SSMSOutputFilePath;
            }
        }

        private void radVS_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "Output Directory :";
            if (radVS.Checked == true)
            {
                lblOutput.Text = $"{radVS.Text} {lblOutput.Text}";
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
    }
}
