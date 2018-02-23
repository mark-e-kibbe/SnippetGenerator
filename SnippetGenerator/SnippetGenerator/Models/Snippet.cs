using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /*
         * Platform: Targeted Platform for Code Snippet - SSMS or VS
         * Metadata: Model containing everything required to make Metadata portion of snippet
         * Literals: List containing literal models to be used in the Code Snippet
         * CodeToSnippet: The code to be turned into a code snippet
        */
        public string CodeToSnippet { get; set; }

        public PlatformEnums _Platform { get; set; }
        public Metadata _Metadata = new Metadata();
        public List<Literal> _Literals = new List<Literal>();

        /// <summary>
        /// Saves the Code Snippet to the location passed in with the filename being Metadata Title
        /// </summary>
        /// <param name="path">The location the snippet will be saved along with filename</param>
        public void Save(string path)
        {
            snippet_BLL.Save(this, path);
        }
    }
}
