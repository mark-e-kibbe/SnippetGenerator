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
    public partial class ConfigurationForm : Form
    {
        private Configuration config = new Configuration();
        public ConfigurationForm()
        {
            InitializeComponent();
            txtDefaultAuthor.Text = config.Author;
            txtDefaultSSMSPath.Text = config.SSMSOutputFilePath;
            txtDefaultVisualStudioPath.Text = config.VStudioOutputFilePath;

            //find the default rad buttons and prepopulate
            switch(config.Platform)
            {
                case Configuration.PlatformEnums.None:
                    radConfigPlatformNone.Checked = true;
                    break;
                case Configuration.PlatformEnums.SSMS:
                    radConfigPlatformSSMS.Checked = true;
                    break;
                case Configuration.PlatformEnums.VS:
                    radConfigPlatformNone.Checked = true;
                    break;
            }

            switch (config.SnippetType)
            { 
                case Configuration.SnippetTypeEnums.Expansion:
                    radConfigTypeExpansion.Checked = true;
                    break;
                case Configuration.SnippetTypeEnums.None:
                    radConfigTypeNone.Checked = true;
                    break;
                case Configuration.SnippetTypeEnums.SurroundsWith:
                    radConfigTypeSurroundsWith.Checked = true;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.Author = txtDefaultAuthor.Text;
            config.SSMSOutputFilePath = txtDefaultSSMSPath.Text;
            config.VStudioOutputFilePath = txtDefaultVisualStudioPath.Text;
            config.Platform = (Configuration.PlatformEnums)Enum.Parse(typeof(Configuration.PlatformEnums), ValueOfChecked(pnlConfigPlatform));
            config.SnippetType = (Configuration.SnippetTypeEnums)Enum.Parse(typeof(Configuration.SnippetTypeEnums), ValueOfChecked(pnlConfigSnippetType));
            config.UpdateConfiguration();
            this.Close();
        }

        private string ValueOfChecked(Panel container)
        {
            foreach (Control control in container.Controls)
            {
                RadioButton rb = (RadioButton)control;
                if(rb.Checked == true)
                {
                    return rb.Text;
                }
                else
                {
                    continue;
                }
                
            }
            return string.Empty;
        }
    }
}
