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
                    break;
            }

        }
    }
}
