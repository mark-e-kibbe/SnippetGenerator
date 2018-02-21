using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /*
         * Title: The Title of the snippet that will show when using ctrl+k ctrl+x or ctrl+k ctrl+x
         * Shortcut: The shorthand required while in a text editor, ss would require ss tab to be typed, stock SSMS not supported but extensions enable this functionality
         * Description: The description field that will show in a tool tip or Snippet Manager during usage/selection
         * Author: The creator of the Snippet
         * SnippetType: Either VS or SSMS
        */
        public string _Title {get;set;}
        public string _Shortcut {get;set;}
        public string _Description {get;set;}
        public string _Author {get;set;}
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
    }
}
