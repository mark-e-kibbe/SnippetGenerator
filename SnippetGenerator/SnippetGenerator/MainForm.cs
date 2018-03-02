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
using System.IO;

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
        private BindingList<Literal> bindingListLiteralsToApply = new BindingList<Literal>();
        private BindingList<Literal> bindingListLiteralsApplied = new BindingList<Literal>();
        private Dictionary<string, string> textReplacedRecoveryDict = new Dictionary<string, string>();

        /// <summary>
        /// Sets up Form and form defaults
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
            lstboxUnappliedLiterals.DataSource = bindingListLiteralsToApply;
            lstboxUnappliedLiterals.DisplayMember = "_ID";
            lstboxAppliedLiterals.DataSource = bindingListLiteralsApplied;
            lstboxAppliedLiterals.DisplayMember = "_ID";
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
        /// Processes form data and saves the Code Snippet to the output directory using SaveFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerateAndSave_Click(object sender, EventArgs e)
        {
            ProcessFormData(_Snippet);

            //Save File Dialog Setup
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileOk += SaveFileDialog_FileOk;

            //Set Initial Directory to what the output directory was, set extension and filter. Preset filename
            saveFileDialog.InitialDirectory = txtOutputDirectory.Text;
            saveFileDialog.DefaultExt = ".snippet";
            saveFileDialog.Filter = "Snippet Files (*.snippet)|*.snippet";
            saveFileDialog.FileName = _Snippet._Metadata._Title;
            saveFileDialog.ValidateNames = true;
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// EventHandler for DialogResult == Ok from SaveFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog sfDialog = (SaveFileDialog)sender;
            _Snippet.Save(Path.GetFullPath(sfDialog.FileName));
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
            lstboxUnappliedLiterals.Items.Clear();
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

        /// <summary>
        /// Folder Picker button click event. Sets folder for output directory
        /// </summary>
        /// <param name="sender">The sending button causing the event</param>
        /// <param name="e"></param>
        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog commonOpenFileDialog = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog();
            commonOpenFileDialog.IsFolderPicker = true;

            //Check if there is a default, if not open at Program Files
            if (string.IsNullOrWhiteSpace(txtOutputDirectory.Text))
            {
                commonOpenFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            }
            else//there is a default
            {
                commonOpenFileDialog.InitialDirectory = txtOutputDirectory.Text;
            }

            //Filename and directory OK - set OutputDir
            if (commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            {
                txtOutputDirectory.Text = commonOpenFileDialog.FileName;
            }
        }

        private void btnAddLiteral_Click(object sender, EventArgs e)
        {
            bindingListLiteralsToApply.Add(new Literal(txtLiteralID.Text, txtLiteralToolTip.Text, txtLiteralDefault.Text));
            ValidateLiteralControls();
        }

        private void btnRemoveFromUnapplied_Click(object sender, EventArgs e)
        {
            if (lstboxUnappliedLiterals.SelectedItem == null || lstboxUnappliedLiterals.Items.Count <= 0)
            {
                MessageBox.Show("Select the Literal to Remove From the Left ListBox");
            }
            else
            {
                bindingListLiteralsToApply.Remove((Literal)lstboxUnappliedLiterals.SelectedItem);
                ValidateLiteralControls();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (lstboxUnappliedLiterals.SelectedItem == null || lstboxUnappliedLiterals.Items.Count <= 0 || txtCodeToSnippet.SelectedText == null)
            {
                MessageBox.Show("Select the Literal to Apply From the Left ListBox and the Text to Replace with the Literal");
            }
            else
            {
                Literal literalToManipulate = (Literal)lstboxUnappliedLiterals.SelectedItem;

                //add text to replacement dictionary before replacement
                textReplacedRecoveryDict.Add(literalToManipulate._ID.ToString(), txtCodeToSnippet.SelectedText);

                //replace the selection with the id being applied
                txtCodeToSnippet.SelectedText = $"${literalToManipulate._ID.ToString()}$";

                //check to see if literal being applied is selected or end for SurroundsWith, if not add to snippet as literal
                if (!(literalToManipulate._ID.Equals("selected") || literalToManipulate._ID.Equals("end")))
                {
                    //add applied literal to snippet to be used during snippet generation
                    _Snippet._Literals.Add(literalToManipulate);
                }

                //transfer the literal to the other listbox
                bindingListLiteralsApplied.Add(literalToManipulate);
                bindingListLiteralsToApply.Remove((Literal)lstboxUnappliedLiterals.SelectedItem);

                //add to text recovery dictionary
                ValidateLiteralControls();
            }
        }

        private void btnUnapply_Click(object sender, EventArgs e)
        {
            Literal literalToManipulate = (Literal)lstboxAppliedLiterals.SelectedItem;

            //recover and reapply the text initially replaced then remove it from recovery dictionary
            txtCodeToSnippet.Text = txtCodeToSnippet.Text.Replace($"${literalToManipulate._ID}$", textReplacedRecoveryDict[literalToManipulate._ID.ToString()]);
            textReplacedRecoveryDict.Remove(literalToManipulate._ID.ToString());
            
            //check if literal is reserved ID for SurroundsWith, if not then it can be removed from snippet
            if (!(literalToManipulate._ID.Equals("selected") || literalToManipulate._ID.Equals("end")))
            {
                _Snippet._Literals.Remove(literalToManipulate);
            }

            bindingListLiteralsToApply.Add(literalToManipulate);
            bindingListLiteralsApplied.Remove((Literal)lstboxAppliedLiterals.SelectedItem);
            ValidateLiteralControls();
        }

        private void ValidateLiteralControls()
        {
            if (lstboxUnappliedLiterals.Items.Count == 0)
            {
                btnRemoveFromUnapplied.Enabled = false;
                btnApply.Enabled = false;
            }
            else
            {
                btnRemoveFromUnapplied.Enabled = true;
                btnApply.Enabled = true;
            }

            if (lstboxAppliedLiterals.Items.Count == 0)
            {
                btnUnapply.Enabled = false;
            }
            else
            {
                btnUnapply.Enabled = true;
            }

            lstboxAppliedLiterals.ClearSelected();
            lstboxUnappliedLiterals.ClearSelected();

            txtLiteralDefault.Text = string.Empty;
            txtLiteralID.Text = string.Empty;
            txtLiteralToolTip.Text = string.Empty;
        }

        private void PopulateLiteralFieldsOnSelection(Literal literalToRepopulateTextboxes)
        {
            txtLiteralID.Text = literalToRepopulateTextboxes._ID;
            txtLiteralToolTip.Text = literalToRepopulateTextboxes._ToolTip;
            txtLiteralDefault.Text = literalToRepopulateTextboxes._Default;
        }

        private void lstboxUnappliedLiterals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxUnappliedLiterals.SelectedItem != null && lstboxUnappliedLiterals.SelectedIndex > -1 && lstboxUnappliedLiterals.Items.Count > 0)
            {
                PopulateLiteralFieldsOnSelection((Literal)lstboxUnappliedLiterals.SelectedItem);
                lstboxAppliedLiterals.ClearSelected();
            }
            else
            {
                lstboxUnappliedLiterals.ClearSelected();
            }
        }

        private void lstboxAppliedLiterals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxAppliedLiterals.SelectedItem != null && lstboxAppliedLiterals.SelectedIndex > -1 && lstboxAppliedLiterals.Items.Count > 0)
            {
                PopulateLiteralFieldsOnSelection((Literal)lstboxAppliedLiterals.SelectedItem);
                lstboxUnappliedLiterals.ClearSelected();
            }
            else
            {
                lstboxAppliedLiterals.ClearSelected();
            }
        }

        /// <summary>
        /// Checks if SurroundsWith was selected and if so adds Required tags into literals unapplied, else removes if there
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radSurroundsWith_CheckedChanged(object sender, EventArgs e)
        {
            if(radSurroundsWith.Checked)
            {
                bindingListLiteralsToApply.Add(new Literal("selected", "", ""));
                bindingListLiteralsToApply.Add(new Literal("end", "", ""));
                ValidateLiteralControls();
            }
            else
            {
                //check if applied first, as it'll be unapplied then removed
                if (bindingListLiteralsApplied.Any<Literal>(l => l._ID.Equals("selected")))
                {
                    lstboxAppliedLiterals.SelectedItem = bindingListLiteralsApplied.First<Literal>(l => l._ID.Equals("selected"));
                    btnUnapply_Click(sender, e);
                }
                if (bindingListLiteralsApplied.Any<Literal>(l => l._ID.Equals("end")))
                {
                    lstboxAppliedLiterals.SelectedItem = bindingListLiteralsApplied.First<Literal>(l => l._ID.Equals("end"));
                    btnUnapply_Click(sender, e);
                }
                if (bindingListLiteralsToApply.Any<Literal>(l => l._ID.Equals("selected")))
                {
                    lstboxUnappliedLiterals.SelectedItem = bindingListLiteralsToApply.First<Literal>(l => l._ID.Equals("selected"));
                    btnRemoveFromUnapplied_Click(sender, e);
                }
                if(bindingListLiteralsToApply.Any<Literal>(l => l._ID.Equals("end")))
                {
                    lstboxUnappliedLiterals.SelectedItem = bindingListLiteralsToApply.First<Literal>(l => l._ID.Equals("end"));
                    btnRemoveFromUnapplied_Click(sender, e);
                }
            }
        }
    }
}
