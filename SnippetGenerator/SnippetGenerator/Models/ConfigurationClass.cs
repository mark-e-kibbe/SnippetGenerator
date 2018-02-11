using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Properties.Settings;

namespace SnippetGenerator.Models
{
    public class ConfigurationClass
    {
        string VStudioOutputFilePath = string.Empty;
        string SSMSOutputFilePath = string.Empty;
        string Author = string.Empty;

        public ConfigurationClass()
        {
            VStudioOutputFilePath = Default.VisualStudioSnippetFilePath;
            SSMSOutputFilePath = Default.SSMSSnippetFilePath;
            Author = Default.Author;
        }

        public void UpdateConfiguration()
        {
            Default.VisualStudioSnippetFilePath =VStudioOutputFilePath;
            Default.SSMSSnippetFilePath = SSMSOutputFilePath;
            Default.Author = Author;
        }
    }
}
