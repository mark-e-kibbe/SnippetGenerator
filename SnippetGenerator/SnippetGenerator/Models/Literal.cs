﻿using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetGenerator.Models
{
    /// <summary>
    /// Literal Class For Sql and VS Code Snippet Variables
    /// </summary>
    /// <remarks>
    /// A Literal is the tag used to denotate a replacement parameter in a Code Snippet
    /// Literals also will gain focus on snippet population and can be tabbed through
    /// </remarks>
    public class Literal
    {
        private Literal_BLL literal_BLL = new Literal_BLL();

        /*
         *ID: How the Literal is referenced via snippet generation
         *ToolTip: The context window description when literal has focus post snippet population
         *Default: The value initially populated by the literal
        */
        public string _ID { get; set; }
        public string _ToolTip { get; set; }
        public string _Default { get; set; }

        /// <summary>
        /// Can create a Literal in it's entirety
        /// </summary>
        /// <param name="ID">How Literal will be referenced in the snippet</param>
        /// <param name="ToolTip">Context window description for when literal has focus after snippet population</param>
        /// <param name="Default">Value initially populated by the literal</param>
        public Literal(string ID, string ToolTip, string Default)
        {
            _ID = ID;
            _ToolTip = ToolTip;
            _Default = Default;
        }

        /// <summary>
        /// Creates xml of Literal object
        /// </summary>
        /// <returns>Complete Literal XML string</returns>
        public string GetLiteralXMLStr()
        {
            return literal_BLL.FormattedLiteralXMLString(this);
        }
    }
}
