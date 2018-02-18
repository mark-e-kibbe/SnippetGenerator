using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.Models
{
    public class Metadata
    {
        public Metadata() { }

        public Metadata(string Title, string Shortcut, string Description, string Author, SnippetTypeEnums SnippetType)
        {
            _Title = Title;
            _Shortcut = Shortcut;
            _Description = Description;
            _Author = Author;
            _SnippetType = SnippetType;
        }

        public string _Title {get;set;}
        public string _Shortcut {get;set;}
        public string _Description {get;set;}
        public string _Author {get;set;}
        public SnippetTypeEnums _SnippetType { get; set; }
    }
}
