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
        /*
         * VSOutputFilePath: Default filepath for saving a Visual Studio Code Snippet
         * SSMS OutputFilePath: Default filepath for saving a SQl Server Management Studio Code Snippet
         * Author: Default Author
         * IsFirstTimeRun: Bool for checking if application is ran for first time
         * Platform: The default platform to target
         * SnippetType: The default type of snippet to use
        */
        public string VStudioOutputFilePath { get; set; }
        public string SSMSOutputFilePath { get; set; }
        public string Author { get; set; }
        public bool IsFirstTimeRun { get; set; }
        public PlatformEnums Platform { get; set; }
        public  SnippetTypeEnums SnippetType { get; set; }

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

        public static bool ValidateFilePath(string outputDirectory, out string errorMessage)
        {
            return Configuration_BLL.ValidateFilePath(outputDirectory, out errorMessage);
        }
    }
    
}
