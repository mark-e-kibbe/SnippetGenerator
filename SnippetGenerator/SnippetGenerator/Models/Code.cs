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
    /// Model for Code to be converted into a snippet
    /// </summary>
    public class Code
    {
        private Code_BLL code_BLL = new Code_BLL();

        /// <summary>
        /// The code language the provided snippet is for
        /// </summary>
        public SnippetLanguage SnippetLanguage { get; set; }
        /// <summary>
        /// The code to convert into a snippet
        /// </summary>
        public string CodeToSnippet { get; set; }

        /// <summary>
        /// Creates xml of code object
        /// </summary>
        /// <returns>Complete Metadata XML string</returns>
        public string GetCodeXMLStr()
        {
            return code_BLL.FormattedCodeXMLString(this);
        }
    }
}
