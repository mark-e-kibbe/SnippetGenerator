using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Models
{
    public class Metadata
    {
        public Metadata(string Title, string Shortcut, string Description, string Author)
        {
            _Title = Title;
            _Shortcut = Shortcut;
            _Description = Description;
            _Author = Author;
        }

        public string _Title {get;set;}
        public string _Shortcut {get;set;}
        public string _Description {get;set;}
        public string _Author {get;set;}
    }
}
