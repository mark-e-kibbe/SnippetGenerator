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

            lblSSMSOutputDirectory.Text += new Models.Configuration().SSMSOutputFilePath;
            lblVSOutputDirectory.Text += new Models.Configuration().VStudioOutputFilePath;
        }

        private void btnGenerateAndSave_Click(object sender, EventArgs e)
        {

        }
    }
}
