using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.Models
{
    /// <summary>
    /// Complete SSMS and VS Snippet Model
    /// </summary>
    public class Snippet
    {
        private Snippet_BLL snippet_BLL = new Snippet_BLL();

        /// <summary>
        /// The code to be turned into a code snippet
        /// </summary>
        public string CodeToSnippet { get; set; }
        /// <summary>
        /// Targeted platform for code snippet - SSMS or VS
        /// </summary>
        public PlatformEnums Platform { get; set; }
        /// <summary>
        /// Model containing everything required to make metadata portion of snippet
        /// </summary>
        public Metadata Metadata = new Metadata();
        /// <summary>
        /// List containing literal models to be used in the code snippet
        /// </summary>
        public List<Literal> Literals = new List<Literal>();

        /// <summary>
        /// Saves the Code Snippet to the location passed in with the filename being Metadata Title
        /// </summary>
        /// <param name="path">The location the snippet will be saved along with filename</param>
        public void Save(string path)
        {
            snippet_BLL.Save(this, path);
        }

        /// <summary>
        /// Validates snippet platform being selected
        /// </summary>
        /// <param name="parentWithRadioButtons">Groupbox containing the snippet platform options as radio buttons</param>
        /// <param name="errorMessage">error message returned, is out param</param>
        /// <returns>boolean result DidValidate</returns>
        public static bool ValidateSnippetPlatform(GroupBox parentWithRadioButtons, out string errorMessage)
        {
            return Snippet_BLL.ValidateSnippetType(parentWithRadioButtons, out errorMessage);
        }

        /// <summary>
        /// Validates Code being converted to snippet
        /// </summary>
        /// <param name="codeToSnippet">the code being converted to a snippet</param>
        /// <param name="isSurroundsWith">boolean on if the snippet is a SurroundsWith snippet</param>
        /// <param name="errorMessage">error message returned, is out param</param>
        /// <returns>boolean result value DidValidate</returns>
        public static bool ValidateCodeToSnippet(string codeToSnippet, bool isSurroundsWith, out string errorMessage)
        {
            return Snippet_BLL.ValidateCodeToSnippet(codeToSnippet, isSurroundsWith, out errorMessage);
        }
    }
}
