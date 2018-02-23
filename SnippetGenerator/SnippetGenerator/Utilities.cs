using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator
{
    /// <summary>
    /// Static utilities helper class for functionality possibly useful elsewhere
    /// </summary>
    public static class Utilities
    {
        #region ValueOfChecked
        /// <summary>
        /// Retrieves the value of a checked radiobutton in a Panel
        /// </summary>
        /// <param name="container">The Panel with the Radio Buttons</param>
        /// <returns>string of checked controls text</returns>
        public static string ValueOfChecked(Panel container)
        {
            return ValueOfChecked((Control)container);
        }

        /// <summary>
        /// Retrieves the value of a checked radiobutton in a GroupBox
        /// </summary>
        /// <param name="container">The Groupbox with the Radio Buttons</param>
        /// <returns>string of checked controls text</returns>
        public static string ValueOfChecked(GroupBox container)
        {
            return ValueOfChecked((Control)container);
        }

        /// <summary>
        /// Actual method for ValueOfChecked, the others are simply overloads that as of currently trickle in through casting as generic Control type
        /// </summary>
        /// <param name="container">A control that contains groupings of radio buttons</param>
        /// <returns></returns>
        private static string ValueOfChecked(Control container)
        {
            foreach (Control control in container.Controls)
            {
                RadioButton rb = (RadioButton)control;
                if (rb.Checked == true)
                {
                    return rb.Text;
                }
                else
                {
                    continue;
                }
            }

            //TODO Hardcoded strings I feel should not be used, change if possible
            return "None";
        }
        #endregion

        #region EnumerationParsing
        /// <summary>
        /// Parses a panels selected radio button text value for SnippetType to the SnippetType enumeration
        /// </summary>
        /// <param name="pnlWithSnippetType">The panel used to sellect a Snippet Type radio button</param>
        /// <returns></returns>
        public static SnippetTypeEnums EnumParseToSnippetTypeEnum(Panel pnlWithSnippetType)
        {
            return (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), ValueOfChecked(pnlWithSnippetType));
        }

        /// <summary>
        /// Parses a  GroupBoxes selected radio button text value for Platform to the Platform enumeration
        /// </summary>
        /// <param name="grpBoxWithPlatform"></param>
        /// <returns></returns>
        public static PlatformEnums EnumParseToSnippetTypeEnum(GroupBox grpBoxWithPlatform)
        {
            return (PlatformEnums)Enum.Parse(typeof(PlatformEnums), ValueOfChecked(grpBoxWithPlatform));
        } 
        #endregion
    }
}
