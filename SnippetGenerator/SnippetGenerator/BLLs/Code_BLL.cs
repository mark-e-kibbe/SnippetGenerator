using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnippetGenerator.Models;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;
namespace SnippetGenerator.BLLs
{
    /// <summary>
    /// Class is for use of logic by Code Model
    /// </summary>
    public class Code_BLL
    {
        /// <summary>
        /// Converts the code to turn into a Code Snippet to XML string
        /// </summary>
        /// <param name="code">Code object containing code to snippet and language</param>
        /// <returns>Generated XML string for code to snippet</returns>
        public string FormattedCodeXMLString(Code code)
        {
            string CodeXML = string.Empty;
            string CodeLanguageAttribute = string.Empty;

            //determine which enum, set string to the appropriate required attribute of Language Property
            switch(code.SnippetLanguage)
            {
                case SnippetLanguage.csharp:
                    CodeLanguageAttribute = SnippetLanguage.csharp.ToString();
                    break;
                case SnippetLanguage.SQL:
                    CodeLanguageAttribute = SnippetLanguage.SQL.ToString();
                    break;
                case SnippetLanguage.vb:
                    CodeLanguageAttribute = SnippetLanguage.vb.ToString();
                    break;
                default:
                    throw new NotImplementedException();
            }
            CodeXML = code.CodeToSnippet;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"<Code Language=""{CodeLanguageAttribute}"">");
            sb.AppendLine(@"<![CDATA[");

            sb.AppendLine(CodeXML);

            sb.AppendLine(@"]]>");
            sb.AppendLine(@" </Code>");

            CodeXML = sb.ToString();
            return CodeXML;
        }
    }
}
