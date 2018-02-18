using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.BLLs
{
    public class Literal_BLL
    {
        public string FormattedLiteralXMLString(Literal literal)
        {
            string XMLToReturn = string.Empty;
            StringBuilder sb = new StringBuilder();

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
