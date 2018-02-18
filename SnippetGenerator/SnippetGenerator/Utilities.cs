using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
