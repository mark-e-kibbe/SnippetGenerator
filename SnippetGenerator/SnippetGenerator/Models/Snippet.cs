using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Models
{
    public class Snippet
    {
        Metadata _Metadata = new Metadata();
        List<Literal> _Literals = new List<Literal>();
    }
}
