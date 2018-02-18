using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Models
{
    public class Literal
    {
        private Literal_BLL literal_BLL = new Literal_BLL();

        public string _ID { get; set; }
        public string _ToolTip { get; set; }
        public string _Default { get; set; }

        public Literal(string ID, string ToolTip, string Default)
        {
            _ID = ID;
            _ToolTip = ToolTip;
            _Default = Default;
        }

        public string GetLiteralXMLStr()
        {
            return literal_BLL.FormattedLiteralXMLString(this);
        }
    }
}
