using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.BLLs
{
    /// <summary>
    /// Class for use of logic by Literal model
    /// </summary>
    public class Literal_BLL
    {
        /// <summary>
        /// Formats and returns a Literal object to an XML string
        /// </summary>
        /// <param name="literal">Completed Literal to be formatted</param>
        /// <returns>Formatted XML string</returns>
        public string FormattedLiteralXMLString(Literal literal)
        {
            string XMLToReturn = string.Empty;

            StringBuilder sb = new StringBuilder();

            //Parse Literal to required syntax for XML Snippet
            sb.AppendLine(@"<Literal>");

            sb.AppendLine($@"<ID>{literal._ID}</ID>");
            sb.AppendLine($@"<ToolTip>{literal._ToolTip}</ToolTip>");
            sb.AppendLine($@"<Default>{literal._Default}</Default>");

            sb.AppendLine(@"</Literal>");

            XMLToReturn = sb.ToString();

            return XMLToReturn;
        }
    }
}
