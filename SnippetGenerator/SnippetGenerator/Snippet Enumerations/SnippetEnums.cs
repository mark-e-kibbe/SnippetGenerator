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
            /// <summary>
            /// Only used when a default platform is not chosen/initialization
            /// </summary>
            None,
            /// <summary>
            /// Snippet is for SSMS
            /// </summary>
            SSMS,
            /// <summary>
            /// Snippet is for Visual Studio
            /// </summary>
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
            /// <summary>
            /// Snippet type Expansion for dropping in preset snippets that "Expand"
            /// </summary>
            Expansion,
            /// <summary>
            /// Only used when a default snippet type is not chosen/initialization
            /// </summary>
            None,
            /// <summary>
            /// Snippet type surrounds with for surrounding highlighted code with a snippet
            /// </summary>
            SurroundsWith
        }

        /// <summary>
        /// List of Snippet Programming Languages Available
        /// </summary>
        public enum SnippetLanguage
        {
            /// <summary>
            /// C#
            /// </summary>
            csharp,
            /// <summary>
            /// Only used when a default snippet language is not chosen or for SSMS code snippets
            /// </summary>
            none,
            /// <summary>
            /// Visual Basic
            /// </summary>
            vb
        }
    }
}
