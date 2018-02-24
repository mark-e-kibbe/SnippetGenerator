﻿using SnippetGenerator.Models;
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
        /*
         * LblOutputDefault_Text: Default value for dynamic label Output Directory
         * Snippet: The snippet to be used for applying model properties to from the GUI
        */
        private const string LblOutputDefault_Text = "Output Directory :";
        private Snippet _Snippet = new Snippet();

        /// <summary>
        /// Sets up Form and form defaults
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        /// <summary>
        /// Populates user configuration defaults
        /// </summary>
        private void InitializeDefaults()
        { 
            Configuration config = new Configuration();

            txtMetadataAuthor.Text = config.Author;
            
            switch (config.Platform)
            {
                case PlatformEnums.SSMS:
                    radSSMS.Checked = true;
                    lblOutput.Text = $"{radSSMS.Text} {LblOutputDefault_Text}";
                    txtOutputDirectory.Text = config.SSMSOutputFilePath;
                    break;
                case PlatformEnums.VS:
                    radVS.Checked = true;
                    lblOutput.Text = $"{radVS.Text} {LblOutputDefault_Text}";
                    txtOutputDirectory.Text = config.VStudioOutputFilePath;
                    break;
                default:
                    radSSMS.Checked = false;
                    radSSMS.TabStop = true;
                    radVS.Checked = false;
                    lblOutput.Text = LblOutputDefault_Text;
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

        #region Menu Events
        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the configuration form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ConfigurationForm();
            configForm.ShowDialog();
            InitializeDefaults();
        }

        /// <summary>
        /// Opens the about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        } 
        #endregion

        /// <summary>
        /// Processes form data and saves the Code Snippet to the output directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerateAndSave_Click(object sender, EventArgs e)
        {
            ProcessFormData(_Snippet);

            //TODO Make This Better, Currently functional using title for the filename
            _Snippet.Save($@"{txtOutputDirectory.Text}\{_Snippet._Metadata._Title}.snippet");
        }

        /// <summary>
        /// Helper method to populate Snippet model with Form information
        /// </summary>
        /// <param name="snippet"></param>
        private void ProcessFormData(Snippet snippet)
        {
            snippet._Metadata._Author = txtMetadataAuthor.Text;
            snippet._Metadata._Description = txtMetadataDescription.Text;
            snippet._Metadata._Shortcut = txtMetadataShortcut.Text;
            snippet._Metadata._Title = txtMetadataTitle.Text;
            snippet._Metadata._SnippetType = Utilities.EnumParseToSnippetTypeEnum(pnlSnippetType);

            _Snippet.CodeToSnippet = txtCodeToSnippet.Text;

            snippet._Platform = Utilities.EnumParseToSnippetTypeEnum(grpBoxPlatform);
        }

        /// <summary>
        /// Clears all fields and defaults off the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Resets all fields to empty
        /// </summary>
        /// <remarks>
        /// Without the Tab Stops being set to true, on unchecking the radio buttons Tab Stops would break
        /// </remarks>
        private void Clear()
        {
            radSSMS.Checked = false;
            radSSMS.TabStop = true;
            radVS.Checked = false;
            radExpansion.Checked = false;
            radExpansion.TabStop = true;
            radSurroundsWith.Checked = false;
            lblOutput.Text = LblOutputDefault_Text;
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

        /// <summary>
        /// Clears the form and populates the defaulted fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            Clear();
            InitializeDefaults();
        }

        #region Platform Radio Button Check Changed Events
        /// <summary>
        /// Event that changes output text according to if SSMS was checked or unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radSSMS_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = LblOutputDefault_Text;
            if (radSSMS.Checked == true)
            {
                lblOutput.Text = $"{radSSMS.Text} {LblOutputDefault_Text}";
                txtOutputDirectory.Text = new Configuration().SSMSOutputFilePath;
            }
        }

        /// <summary>
        /// Event that that also changes output text according ot if SSMS was checked or unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radVS_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = LblOutputDefault_Text;
            if (radVS.Checked == true)
            {
                lblOutput.Text = $"{radVS.Text} {LblOutputDefault_Text}";
                txtOutputDirectory.Text = new Configuration().VStudioOutputFilePath;
            }
        } 
        #endregion
    }
}
