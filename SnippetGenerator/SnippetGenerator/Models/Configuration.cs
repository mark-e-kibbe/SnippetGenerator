using SnippetGenerator.BLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.Models
{
    /// <summary>
    /// Helper for accessing and saving default configuration options easily
    /// </summary>
    public class Configuration
    {
        private Configuration_BLL configuration_BLL= new Configuration_BLL();

        /// <summary>
        /// Default filepath for saving a Visual Studio Code Snippet
        /// </summary>
        public string VStudioOutputFilePath { get; set; }
        /// <summary>
        /// Default filepath for saving a SQl Server Management Studio Code Snippet
        /// </summary>
        public string SSMSOutputFilePath { get; set; }
        /// <summary>
        /// Default Author
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Bool for checking if application is ran for first time
        /// </summary>
        public bool IsFirstTimeRun { get; set; }
        /// <summary>
        /// The default platform to target
        /// </summary>
        public PlatformEnums Platform { get; set; }
        /// <summary>
        /// The default type of snippet to use
        /// </summary>
        public SnippetTypeEnums SnippetType { get; set; }

        /// <summary>
        /// Constructor that populates this model
        /// </summary>
        public Configuration()
        {
            configuration_BLL.Load(this);
        }

        /// <summary>
        /// Updates and Saves configuration settings currently set in model
        /// </summary>
        public void UpdateConfiguration()
        {
            configuration_BLL.UpdateConfiguration(this);
        }

        /// <summary>
        /// Validates the directory for the snippet with Director.Exists
        /// </summary>
        /// <param name="outputDirectory">The directory to check</param>
        /// <param name="errorMessage">Error Message to pass by ref using out</param>
        /// <returns>Boolean result, successful validation = true</returns>
        public static bool ValidateFilePath(string outputDirectory, out string errorMessage)
        {
            return Configuration_BLL.ValidateFilePath(outputDirectory, out errorMessage);
        }
    }
    
}
