using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.BLLs
{
    /// <summary>
    /// Class for use of logic by Metadata model
    /// </summary>
    public class Metadata_BLL
    {
        /// <summary>
        /// Formats and returns a Metadata object to an XML string
        /// </summary>
        /// <param name="metadata">Complete Metadata to be formatted</param>
        /// <returns>Formatted XML string</returns>
        public string FormattedMetadataXMLString(Metadata metadata)
        {
            string XMLToReturn = string.Empty;
            StringBuilder sb = new StringBuilder();

            //Parse Metadata to required syntax for XML Snippet
            sb.AppendLine(@"<Header>");

            sb.AppendLine($@"<Title>{metadata._Title}</Title>");
            sb.AppendLine($@"<Shortcut>{metadata._Shortcut}</Shortcut>");
            sb.AppendLine($@"<Description>{metadata._Description}</Description>");
            sb.AppendLine($@"<Author>{metadata._Author}</Author>");

            sb.AppendLine($@"<SnippetTypes>");
            sb.AppendLine($@"<SnippetType>{metadata._SnippetType.ToString()}</SnippetType>");
            sb.AppendLine($@"</SnippetTypes>");

            sb.AppendLine(@"</Header>");

            XMLToReturn = sb.ToString();

            return XMLToReturn;
        }
    }
}
