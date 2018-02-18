using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Models
{
    public class Literal
    {
        public Literal(string ID, string ToolTip, string Default)
        {
            _ID = ID;
            _ToolTip = ToolTip;
            _Default = Default;
        }

        public string _ID { get; set; }
        public string _ToolTip { get; set; }
        public string _Default { get; set; }
    }
}
