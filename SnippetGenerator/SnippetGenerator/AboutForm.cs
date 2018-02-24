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
    /// <summary>
    /// About Form for showing project information
    /// </summary>
    public partial class AboutForm : Form
    {
        private const string GitHubLink = @"https://github.com/mark-e-kibbe/SnippetGenerator";
        private const string LinkedInLink = @"https://www.linkedin.com/in/mark-kibbe-729629122/";

        /// <summary>
        /// Basic constructor for generating form components
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Copies email to cliboard and displays a notification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLblEmailAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ToastMessage = "Email Copied to Clipboard";
            Clipboard.SetText(linkLblEmailAddress.Text);
            ToastNotification Toast = new ToastNotification(ToastMessage, Cursor.Position);
            Toast.Show();
        }

        /// <summary>
        /// Opens Browser and sends user to GitHub Repo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GitHubLink); 
        }

        /// <summary>
        /// Opens browser and sends user to Linked In Profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLblLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LinkedInLink);
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
