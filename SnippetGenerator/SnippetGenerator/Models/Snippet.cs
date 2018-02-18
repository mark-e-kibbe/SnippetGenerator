using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.Models
{
    public class Snippet
    {
        public PlatformEnums _Platform { get; set; }
        public SnippetTypeEnums _SnippetType { get; set; }

        public Metadata _Metadata = new Metadata();
        public List<Literal> _Literals = new List<Literal>();

        //TODO Class this property out
        public string CodeToSnippet = string.Empty;
    }
}
