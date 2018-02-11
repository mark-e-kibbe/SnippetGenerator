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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.UpdateConfiguration();
            this.Close();
        }
    }
}
