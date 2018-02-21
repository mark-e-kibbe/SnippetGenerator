using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.BLLs
{
    public class Snippet_BLL
    {
        private XDocument GenerateSnippet(Snippet snippet)
        {
            XDocument CompletedXML = new XDocument();

            //start basic no literals
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8"" ?> ");
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

            _stringBuilder.AppendLine(CodeXML(snippet.CodeToSnippet, snippet._Platform));
            _stringBuilder.AppendLine(@"</Snippet>");
            _stringBuilder.AppendLine(@"</CodeSnippet>");
            _stringBuilder.AppendLine(@"</CodeSnippets>");

            CompletedXML = ParseXMLStr(_stringBuilder.ToString());


            return CompletedXML;
        }

        public void Save(Snippet snippetToSave, string path)
        {
            XDocument xdocSnippet = GenerateSnippet(snippetToSave);
            xdocSnippet.Save(path);
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

        private string CodeXML(string code, Snippet_Enumerations.SnippetEnums.PlatformEnums platform)
        {
            string CodeXML = string.Empty;
            //determine which enum, set string to the appropriate required attribute of Language Property
            string CodeLanguageAttribute = platform == PlatformEnums.SSMS ? "SQL" : "csharp";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"<Code Language=""{CodeLanguageAttribute}"">");
            sb.AppendLine(@"<![CDATA[");

            sb.AppendLine(code);

            sb.AppendLine(@"]]>");
            sb.AppendLine(@" </Code>");

            CodeXML = sb.ToString();
            return CodeXML;
        }

        private XDocument ParseXMLStr(string xmlStr)
        {
            try
            {
                XDocument xDoc = XDocument.Parse(xmlStr);

                return xDoc;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
