using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator
{
    public static class Utilities
    {
        public static string ValueOfChecked(Panel container)
        {
            return ValueOfChecked((Control)container);
        }
        public static string ValueOfChecked(GroupBox container)
        {
            return ValueOfChecked((Control)container);
        }
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
        public static SnippetTypeEnums EnumParseToSnippetTypeEnum(Panel pnlWithSnippetType)
        {
            return (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), ValueOfChecked(pnlWithSnippetType));
        }
        public static PlatformEnums EnumParseToSnippetTypeEnum(GroupBox grpBoxWithPlatform)
        {
            return (PlatformEnums)Enum.Parse(typeof(PlatformEnums), ValueOfChecked(grpBoxWithPlatform));
        }
    }
}
