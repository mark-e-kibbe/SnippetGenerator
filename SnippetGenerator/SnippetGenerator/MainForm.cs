using SnippetGenerator.Models;
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
        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        private void btnGenerateAndSave_Click(object sender, EventArgs e)
        {

        }

        private void InitializeDefaults()
        { 
            Configuration config = new Configuration();

            txtMetadataAuthor.Text = config.Author;
            
            switch (config.Platform)
            {
                case Configuration.PlatformEnums.SSMS:
                    radSSMS.Checked = true;
                    lblOutput.Text = $"{radSSMS.Text} {lblOutput.Text}";
                    txtOutputDirectory.Text = config.SSMSOutputFilePath;
                    break;
                case Configuration.PlatformEnums.VS:
                    radVS.Checked = true;
                    lblOutput.Text = $"{radVS.Text} {lblOutput.Text}";
                    break;
                default:
                    break;
            }

            switch (config.SnippetType)
            {
                case Configuration.SnippetTypeEnums.Expansion:
                    radExpansion.Checked = true;
                    break;
                case Configuration.SnippetTypeEnums.SurroundsWith:
                    radSurroundsWith.Checked = true;
                    break;
                default:
                    break;
            }

        }
    }
}
