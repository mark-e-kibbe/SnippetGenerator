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
    public partial class ConfigurationForm : Form
    {
        private Configuration config = new Configuration();
        public ConfigurationForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }
        private void InitializeDefaults()
        {
            txtDefaultAuthor.Text = config.Author;
            txtDefaultSSMSPath.Text = config.SSMSOutputFilePath;
            txtDefaultVisualStudioPath.Text = config.VStudioOutputFilePath;

            //find the default rad buttons and prepopulate
            switch (config.Platform)
            {
                case PlatformEnums.None:
                    radConfigPlatformNone.Checked = true;
                    break;
                case PlatformEnums.SSMS:
                    radConfigPlatformSSMS.Checked = true;
                    break;
                case PlatformEnums.VS:
                    radConfigPlatformNone.Checked = true;
                    break;
            }

            switch (config.SnippetType)
            {
                case SnippetTypeEnums.Expansion:
                    radConfigTypeExpansion.Checked = true;
                    break;
                case SnippetTypeEnums.None:
                    radConfigTypeNone.Checked = true;
                    break;
                case SnippetTypeEnums.SurroundsWith:
                    radConfigTypeSurroundsWith.Checked = true;
                    break;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            config.Author = txtDefaultAuthor.Text;
            config.SSMSOutputFilePath = txtDefaultSSMSPath.Text;
            config.VStudioOutputFilePath = txtDefaultVisualStudioPath.Text;
            config.Platform = (PlatformEnums)Enum.Parse(typeof(PlatformEnums), Utilities.ValueOfChecked(pnlConfigPlatform));
            config.SnippetType = (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), Utilities.ValueOfChecked(pnlConfigSnippetType));
            config.UpdateConfiguration();
            this.Close();
        }
    }
}
