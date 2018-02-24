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
    public partial class AboutForm : Form
    {
        private const string GitHubLink = @"https://github.com/mark-e-kibbe/SnippetGenerator";
        private const string LinkedInLink = @"https://www.linkedin.com/in/mark-kibbe-729629122/";

        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GitHubLink); 
        }

        private void linkLblEmailAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(linkLblEmailAddress.Text);
        }

        private void linkLblLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LinkedInLink);
        }
    }
}
