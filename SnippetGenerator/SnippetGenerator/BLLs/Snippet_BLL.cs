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
            StringWriter stringWriter = new StringWriter();
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
    }
}
