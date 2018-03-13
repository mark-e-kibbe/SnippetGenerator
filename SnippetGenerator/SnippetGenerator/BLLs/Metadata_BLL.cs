using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippetGenerator.BLLs
{
    /// <summary>
    /// Class for use of logic by Metadata model
    /// </summary>
    public class Metadata_BLL
    {
        /// <summary>
        /// Formats and returns a Metadata object to an XML string
        /// </summary>
        /// <param name="metadata">Complete Metadata to be formatted</param>
        /// <returns>Formatted XML string</returns>
        public string FormattedMetadataXMLString(Metadata metadata)
        {
            string XMLToReturn = string.Empty;
            StringBuilder sb = new StringBuilder();

            //Parse Metadata to required syntax for XML Snippet
            sb.AppendLine(@"<Header>");

            sb.AppendLine($@"<Title>{metadata._Title}</Title>");
            sb.AppendLine($@"<Shortcut>{metadata._Shortcut}</Shortcut>");
            sb.AppendLine($@"<Description>{metadata._Description}</Description>");
            sb.AppendLine($@"<Author>{metadata._Author}</Author>");

            sb.AppendLine($@"<SnippetTypes>");
            sb.AppendLine($@"<SnippetType>{metadata._SnippetType.ToString()}</SnippetType>");
            sb.AppendLine($@"</SnippetTypes>");

            sb.AppendLine(@"</Header>");

            XMLToReturn = sb.ToString();

            return XMLToReturn;
        }

        /// <summary>
        /// Validates the title for null, whitespace, and lessthen or greaterthen  invalid xml characters
        /// </summary>
        /// <param name="titleToValidate">The title to validate</param>
        /// <param name="errorMessage">Error Message to pass by ref using out</param>
        /// <returns>Boolean result, successful validation = true</returns>
        public static bool ValidateTitle(string titleToValidate, out string errorMessage)
        {
            //create a list for each error message
            List<string> errorMessageList = new List<string>();

            //Anon or Lambdas cannout interact with out parameters, temp str to set to out param later
            string errorMessageForLinq = string.Empty;

            //result boolean
            bool DidValidate = true;

            //blank title check
            if (string.IsNullOrWhiteSpace(titleToValidate))
            {
                DidValidate = false;
                errorMessageList.Add("A Title is required, please fill out a title");
            }

            //invalid xml characters check
            if (titleToValidate.Contains("<") || titleToValidate.Contains(">"))
            {
                DidValidate = false;
                errorMessageList.Add("Invalid character, please do not include < or > symbols");
            }

            errorMessageList.ForEach(str => errorMessageForLinq += str + Environment.NewLine);

            errorMessage = errorMessageForLinq;

            return DidValidate;
        }

        /// <summary>
        /// Validates and ensures a snippet type is selected in the Panel container with the types being represented by radio buttons
        /// </summary>
        /// <param name="parentWithRadioButtons">Panel container control containing the snippet type radio buttons to validate</param>
        /// <param name="errorMessage">Error Message to pass by ref using out</param>
        /// <returns>Boolean result, successful validation = true</returns>
        public static bool ValidateSnippetType(Panel parentWithRadioButtons, out string errorMessage)
        {
            string ErrorMessage = string.Empty;
            bool DidValidate = true;

            DidValidate = !parentWithRadioButtons.Controls.OfType<RadioButton>().Any(rb => rb.Checked == true);

            if(!DidValidate)
            {
                ErrorMessage = "Please select a snippet type";
            }

            errorMessage = ErrorMessage;

            return DidValidate;
        }
    }
}
