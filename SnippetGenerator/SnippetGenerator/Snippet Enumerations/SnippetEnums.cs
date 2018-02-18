using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Snippet_Enumerations
{
    public static class SnippetEnums
    {
        public enum PlatformEnums
        {
            None,
            SSMS,
            VS
        }
        public enum SnippetTypeEnums
        {
            Expansion,
            None,
            SurroundsWith
        }
    }
}
