using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnippetGenerator.BLLs
{
    public class Snippet_BLL
    {
        public string GenerateSnippet(Snippet snippet)
        {
            string CompletedXMLStr = string.Empty;

            //start basic no literals
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine(@"<CodeSnippets xmlns=""http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet"">");
            _stringBuilder.AppendLine(LocDefinitionXML());
            _stringBuilder.AppendLine(@"<CodeSnippet Format =""1.0.0"">");
            _stringBuilder.AppendLine(HeaderXML(snippet._Metadata));
            _stringBuilder.AppendLine(@"<Snippet>");
            _stringBuilder.AppendLine(@"<Declarations>");

            //for each loop to get do each literal in the list
            if (snippet._Literals != null && snippet._Literals.Count > 0)
            {
                foreach (Literal literal in snippet._Literals)
                {
                    _stringBuilder.AppendLine(literal.GetLiteralXMLStr());
                }
            }

            _stringBuilder.AppendLine(@"</Declarations>");

            _stringBuilder.AppendLine(CodeXML(snippet.CodeToSnippet));

            _stringBuilder.AppendLine(@"</CodeSnippet>");
            _stringBuilder.AppendLine(@"</CodeSnippets>");

            CompletedXMLStr = _stringBuilder.ToString();
            return CompletedXMLStr;
        }

        private void Save(string snippetToSave, string path)
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    //sw.WriteLine("Hello");
                    //sw.WriteLine("And");
                    //sw.WriteLine("Welcome");
                }
            }
        }

        private string LocDefinitionXML()
        {
            string LocDef = string.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"<_locDefinition xmlns=""urn:locstudio"">");
            sb.AppendLine(@"<_locDefault _loc=""locNone"" />");
            sb.AppendLine(@"<_locTag _loc=""locData"">Title</_locTag>");
            sb.AppendLine(@"<_locTag _loc=""locData"">Description</_locTag>");
            sb.AppendLine(@"<_locTag _loc=""locData"">Author</_locTag>");
            sb.AppendLine(@"<_locTag _loc=""locData"">ToolTip</_locTag>");
            sb.AppendLine(@"<_locTag _loc=""locData"">Default</_locTag>");
            sb.AppendLine(@"</_locDefinition>");

            LocDef = sb.ToString();

            return LocDef;
        }

        private string HeaderXML(Metadata metadata)
        {
            string HeaderXML = string.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(metadata.GetMetadataXMLStr());

            HeaderXML = sb.ToString();
            return HeaderXML;
        }

        private string LiteralXML(Literal literal)
        {
            string LiteralXML = string.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(literal.GetLiteralXMLStr());

            LiteralXML = sb.ToString();
            return LiteralXML;
        }

        private string CodeXML(string code)
        {
            string CodeXML = string.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"<Code Language=""SQL"">");
            sb.AppendLine(@"< ![CDATA[");

            sb.AppendLine(code);

            sb.AppendLine(@"]] >");
            sb.AppendLine(@" </Code>");

            CodeXML = sb.ToString();
            return CodeXML;
        }

        public void Save(string path)
        {

        }

        private string FormatXML(string xmlStr)
        {
            string FormattedXML = string.Empty;

            try
            {
                XDocument xDoc = XDocument.Parse(xmlStr);
                FormattedXML = xDoc.ToString();

                return FormattedXML;
            }
            catch (Exception)
            {
                return xmlStr;
            }
        }
    }
}
