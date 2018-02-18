using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.BLLs
{
    public class Snippet_BLL
    {
        public void GenerateSnippet(Snippet snippet)
        {
            //start basic no literals
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine(@"<CodeSnippets xmlns=""http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet"">");
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

        private string LocDefinition()
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

            return LocDef;
        }
    }
}
