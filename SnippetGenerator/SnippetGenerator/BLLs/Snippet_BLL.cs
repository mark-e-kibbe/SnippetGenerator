﻿using SnippetGenerator.Models;
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
    /// <summary>
    /// Class for use of logic by Snippet Model
    /// </summary>
    public class Snippet_BLL
    {
        /// <summary>
        /// Creates validated and formatted Code Snippet XDocument object
        /// </summary>
        /// <param name="snippet">The snippet model to convert into a XML Code Snippet</param>
        /// <returns>XDocument containing Validated XML Code Snippet</returns>
        private XDocument GenerateSnippet(Snippet snippet)
        {
            //Used to convert the xml string into validated and pretty printed XML
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

            //for each loop to create each literals XML in the list of Literals
            if (snippet._Literals != null && snippet._Literals.Count > 0)
            {
                foreach (Literal literal in snippet._Literals)
                {
                    _stringBuilder.AppendLine(literal.GetLiteralXMLStr());
                }
            }

            _stringBuilder.AppendLine(@"</Declarations>");

            //Appends the code the user would like to turn into a code snippet to the xml string being built
            _stringBuilder.AppendLine(CodeXML(snippet.CodeToSnippet, snippet._Platform));

            _stringBuilder.AppendLine(@"</Snippet>");
            _stringBuilder.AppendLine(@"</CodeSnippet>");
            _stringBuilder.AppendLine(@"</CodeSnippets>");

            //Parse and set the completed XML Code Snippet string to XDocument
            CompletedXML = ParseXMLStr(_stringBuilder.ToString());

            return CompletedXML;
        }

        /// <summary>
        /// Saves the code snippet to path provided - path includes filename
        /// </summary>
        /// <param name="snippetToSave">The Snippet to turn into an XML Code Snippet file</param>
        /// <param name="path">Path and filename the snippet will be stored at</param>
        public void Save(Snippet snippetToSave, string path)
        {
            XDocument xdocSnippet = GenerateSnippet(snippetToSave);
            xdocSnippet.Save(path);
        }

        /// <summary>
        /// Generates XML string of standard metadata xml definitions - not the Metadata itself
        /// </summary>
        /// <returns>XML string for Metadata definitions</returns>
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

        /// <summary>
        /// Generates XML string of metadata xml
        /// </summary>
        /// <param name="metadata">The metadata to convert to xml string</param>
        /// <returns>XML string of Metadata</returns>
        private string HeaderXML(Metadata metadata)
        {
            string HeaderXML = string.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(metadata.GetMetadataXMLStr());

            HeaderXML = sb.ToString();
            return HeaderXML;
        }

        /// <summary>
        /// Generates XML String of a Literal Model
        /// </summary>
        /// <param name="literal">The literal to convert to a XML string</param>
        /// <returns>XML string of Literal</returns>
        private string LiteralXML(Literal literal)
        {
            string LiteralXML = string.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(literal.GetLiteralXMLStr());

            LiteralXML = sb.ToString();
            return LiteralXML;
        }

        /// <summary>
        /// Converts the code to turn into a Code Snippet to XML string
        /// </summary>
        /// <param name="code">Code to convert to snippet</param>
        /// <param name="platform">Target platform for Code Snippet - SSMS or VS</param>
        /// <returns>Generated XML string for code to snippet</returns>
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

        /// <summary>
        /// Converts a complete xml code snippet string to a validated XML XDocument
        /// </summary>
        /// <param name="xmlStr">the xml to parse into a validated XML Xdocument object</param>
        /// <returns></returns>
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
