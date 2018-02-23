using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Properties.Settings;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.Models
{
    /// <summary>
    /// Helper for accessing and saving default configuration options easily
    /// </summary>
    public class Configuration
    {
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
        /// Constructor that prepopulates configuration settings
        /// </summary>
        public Configuration()
        {
            VStudioOutputFilePath = Default.VisualStudioSnippetFilePath;
            SSMSOutputFilePath = Default.SSMSSnippetFilePath;
            Author = Default.Author;
            IsFirstTimeRun = Default.IsFirstRun;
            Platform = (PlatformEnums)Enum.Parse(typeof(PlatformEnums), Default.Platform);
            SnippetType = (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), Default.SnippetType);
        }

        /// <summary>
        /// Saves any settings to the Properties.Settings.settings configuration file
        /// </summary>
        public void UpdateConfiguration()
        {
            Default.VisualStudioSnippetFilePath = VStudioOutputFilePath;
            Default.SSMSSnippetFilePath = SSMSOutputFilePath;
            Default.Author = Author;
            Default.IsFirstRun = false;
            Default.Platform = Platform.ToString();
            Default.SnippetType = SnippetType.ToString();
            Default.Save();
        }
    }
    
}
