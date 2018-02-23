using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Snippet_Enumerations
{
    /// <summary>
    /// Noninstanced reference class for properties that should rarely/never change
    /// </summary>
    public static class SnippetEnums
    {
        /// <summary>
        /// List of possible Target Platforms for the Code Snippet
        /// </summary>
        public enum PlatformEnums
        {
            None,
            SSMS,
            VS
        }

        /// <summary>
        /// List of The type of snippet desired
        /// </summary>
        /// <remarks>
        /// Expansion is used for dropping in preset code
        /// SurroundsWith is used for surrounding selected code with a code snippet such as try catch, if blocks, etc
        /// </remarks>
        public enum SnippetTypeEnums
        {
            Expansion,
            None,
            SurroundsWith
        }
    }
}
