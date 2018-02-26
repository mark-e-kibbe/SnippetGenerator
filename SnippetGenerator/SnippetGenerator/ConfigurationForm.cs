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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace SnippetGenerator
{
    /// <summary>
    /// Configuration Settings Form
    /// </summary>
    public partial class ConfigurationForm : Form
    {
        private Configuration config = new Configuration();

        /// <summary>
        /// Initializes form and defaults
        /// </summary>
        public ConfigurationForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        /// <summary>
        /// helper for prepopulating configuration settings if already set once
        /// </summary>
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

        /// <summary>
        /// Button save event for saving all current configuration settings on the configuration form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Button Cancel event that will either not save configuration settings unless first run.
        /// First run saves default Platform and SnippetType to none.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (config.IsFirstTimeRun == false)
            {
                this.Close();
            }
            else
            {
                config.Platform = (PlatformEnums)Enum.Parse(typeof(PlatformEnums), Utilities.ValueOfChecked(pnlConfigPlatform));
                config.SnippetType = (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), Utilities.ValueOfChecked(pnlConfigSnippetType));
                config.UpdateConfiguration();
                this.Close();
            }
        }

        private void btnPickOutputDirectory_Click(object sender, EventArgs e)
        {
            Button btnThatSent = (Button)sender;

            Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog commonOpenFileDialog = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog();
            commonOpenFileDialog.IsFolderPicker = true;

            if (config.IsFirstTimeRun)
            {
                commonOpenFileDialog.DefaultDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if(btnThatSent.Name.Equals(btnPickSSMSOutputDirectory.Text))
                {
                    txtDefaultSSMSPath.Text = commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok ? commonOpenFileDialog.FileName : string.Empty;
                }
                else
                {
                    txtDefaultVisualStudioPath.Text = commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok ? commonOpenFileDialog.FileName : string.Empty;
                }
            }
            else
            {
                if (btnThatSent.Name.Equals(btnPickSSMSOutputDirectory.Name))
                {
                    commonOpenFileDialog.DefaultDirectory = config.SSMSOutputFilePath;
                    txtDefaultSSMSPath.Text = commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok ? commonOpenFileDialog.FileName : string.Empty;

                }
                else//btnThatSent.Name.Equals(btnPicksVisualStudioOutputDirectory.Text
                {
                    commonOpenFileDialog.DefaultDirectory = config.VStudioOutputFilePath;
                    txtDefaultVisualStudioPath.Text = commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok ? commonOpenFileDialog.FileName : string.Empty;
                }
            }
        }
    }
}
