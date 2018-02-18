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
        public enum PlatformEnums
        {
            VS,
            SSMS
        }
        public  enum SnippetTypeEnums
        {
            SurroundsWith,
            Expansion
        }

        public string VStudioOutputFilePath { get; set; }
        public string SSMSOutputFilePath { get; set; }
        public string Author { get; set; }
        public bool IsFirstTimeRun { get; set; }
        public PlatformEnums Platform { get; set; }
        public  SnippetTypeEnums SnippetType { get; set; }
        public Configuration()
        {
            VStudioOutputFilePath = Default.VisualStudioSnippetFilePath;
            SSMSOutputFilePath = Default.SSMSSnippetFilePath;
            Author = Default.Author;
            IsFirstTimeRun = Default.IsFirstRun;
            Platform = (PlatformEnums)Enum.Parse(typeof(PlatformEnums), Default.Platform);
            SnippetType = (SnippetTypeEnums)Enum.Parse(typeof(SnippetTypeEnums), Default.SnippetType);
        }

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
