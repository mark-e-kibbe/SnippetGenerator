using SnippetGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Properties.Settings;
using static SnippetGenerator.Snippet_Enumerations.SnippetEnums;

namespace SnippetGenerator.BLLs
{
    /// <summary>
    /// Handles Configuration model logic
    /// </summary>
    public class Configuration_BLL
    {
        /// <summary>
        /// Loads the configuration settings from the Settings.settings file and sets them to the model properties
        /// </summary>
        /// <param name="config">Configuration model to load defaults into</param>
        public void Load(Configuration config)
        {
            config.VStudioOutputFilePath = Default.VisualStudioSnippetFilePath;
            config.SSMSOutputFilePath = Default.SSMSSnippetFilePath;
            config.Author = Default.Author;
            config.IsFirstTimeRun = Default.IsFirstRun;
            config.Platform = (PlatformEnums)Enum.Parse(typeof(PlatformEnums), Default.Platform);
            config.SnippetType = (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), Default.SnippetType);
        }

        /// <summary>
        /// Saves any settings to the Properties.Settings.settings configuration file
        /// </summary>
        /// <param name="config">Configuration model to set defaults to</param>
        public void UpdateConfiguration(Configuration config)
        {
            Default.VisualStudioSnippetFilePath = config.VStudioOutputFilePath;
            Default.SSMSSnippetFilePath = config.SSMSOutputFilePath;
            Default.Author = config.Author;
            Default.IsFirstRun = false;
            Default.Platform = config.Platform.ToString();
            Default.SnippetType = config.SnippetType.ToString();
            Default.Save();
        }

        public static bool ValidateFilePath(string outputDirectory, out string errorMessage)
        {
            string ErrorMessage = string.Empty;
            bool DidValidate = true;

            DidValidate = Directory.Exists(outputDirectory);

            if (!DidValidate)
            {
                ErrorMessage = "Directory does not exist, please ensure the chosen directory exists";
            }

            errorMessage = ErrorMessage;

            return DidValidate;
        }
    }
}
