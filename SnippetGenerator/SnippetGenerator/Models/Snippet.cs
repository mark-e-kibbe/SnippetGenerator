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
    public class Snippet
    {
        private Snippet_BLL snippet_BLL = new Snippet_BLL();

        public string CodeToSnippet { get; set;}

        public PlatformEnums _Platform { get; set; }
        public Metadata _Metadata = new Metadata();
        public List<Literal> _Literals = new List<Literal>();

        public void Save(string path)
        {
            snippet_BLL.Save(this, path);
        }
    }
}
