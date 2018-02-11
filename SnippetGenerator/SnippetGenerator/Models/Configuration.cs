using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnippetGenerator.Properties.Settings;

namespace SnippetGenerator.Models
{
    public class Configuration
    {
        public string VStudioOutputFilePath { get; set; }
        public string SSMSOutputFilePath { get; set; }
        public string Author { get; set; }
        public bool IsFirstTimeRun { get; set; }

        public Configuration()
        {
            VStudioOutputFilePath = Default.VisualStudioSnippetFilePath;
            SSMSOutputFilePath = Default.SSMSSnippetFilePath;
            Author = Default.Author;
            IsFirstTimeRun = Default.IsFirstRun;
        }

        public void UpdateConfiguration()
        {
            Default.VisualStudioSnippetFilePath =VStudioOutputFilePath;
            Default.SSMSSnippetFilePath = SSMSOutputFilePath;
            Default.Author = Author;
            Default.IsFirstRun = false;
        }
    }
}
