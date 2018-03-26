using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.Models
{
    /// <summary>
    /// Metadata Class For Sql and VS Code Snippet Metadata
    /// </summary>
    /// <remarks>
    /// Metadata is used to set how the snippet presents itself in SSMS and VS
    /// including title, shortcut, description, and the author.
    /// NOTE: Currently stock SSMS does not support shortcuts but certain third party extensions do
    /// NOTE2: Title is searchable with the stock shortcuts mentioned above
    /// </remarks>
    public class Metadata
    {
        private Metadata_BLL metadata_BLL = new Metadata_BLL();

        /// <summary>
        /// The Title of the snippet that will show when using ctrl+k ctrl+x or ctrl+k ctrl+x
        /// </summary>
        public string _Title {get;set;}
        /// <summary>
        /// The shorthand required while in a text editor, ss would require ss tab to be typed, stock SSMS not supported but extensions enable this functionality
        /// </summary>
        public string _Shortcut {get;set;}
        /// <summary>
        /// The description field that will show in a tool tip or Snippet Manager during usage/selection
        /// </summary>
        public string _Description {get;set;}
        /// <summary>
        /// The creator of the Snippet, can be defaulted through configuration
        /// </summary>
        public string _Author {get;set;}
        /// <summary>
        /// For setting the type of snippet
        /// </summary>
        public SnippetTypeEnums _SnippetType { get; set; }

        /// <summary>
        /// Clean slate empty constructor for self initialization of metadata properties
        /// </summary>
        public Metadata() { }

        /// <summary>
        /// Constructor to fully initialize and set properties required for Metadata object
        /// </summary>
        /// <param name="Title">Title of Snippet</param>
        /// <param name="Shortcut">Keyboard shorthand for quick population, stock VS only or SSMS with extensions</param>
        /// <param name="Description">Description field for the snippet when being used</param>
        /// <param name="Author">Snippet Creator</param>
        /// <param name="SnippetType">Enumeration for the only types of snippets</param>
        public Metadata(string Title, string Shortcut, string Description, string Author, SnippetTypeEnums SnippetType)
        {
            _Title = Title;
            _Shortcut = Shortcut;
            _Description = Description;
            _Author = Author;
            _SnippetType = SnippetType;
        }

        /// <summary>
        /// Creates xml of Metadata object
        /// </summary>
        /// <returns>Complete Metadata XML string</returns>
        public string GetMetadataXMLStr()
        {
            return metadata_BLL.FormattedMetadataXMLString(this);
        }

        /// <summary>
        /// Validates the title for null, whitespace, and lessthen or greaterthen  invalid xml characters
        /// </summary>
        /// <param name="titleToValidate">Title that needs validated as string</param>
        /// <param name="errorMessage">Error message returned, is out param</param>
        /// <returns>boolean value on if validation was successful</returns>
        public static bool ValidateTitle(string titleToValidate, out string errorMessage)
        {
            return Metadata_BLL.ValidateTitle(titleToValidate, out errorMessage);
        }

        /// <summary>
        /// Validates and ensures a snippet type is selected in the Panel container with the types being represented by radio buttons
        /// </summary>
        /// <param name="parentWithRadioButtons">Container Panel that contains the Snippet Types as Radio Buttons</param>
        /// <param name="errorMessage">Error message returned, is out param</param>
        /// <returns>boolean value on if validation was successful</returns>
        public static bool ValidateSnippetType(Panel parentWithRadioButtons, out string errorMessage)
        {
            return Metadata_BLL.ValidateSnippetType(parentWithRadioButtons, out errorMessage);
        }
    }
}
