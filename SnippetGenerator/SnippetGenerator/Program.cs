﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippetGenerator
{
    /// <summary>
    /// Main Entry Class and exterior logic related to the Application as a whole
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(Properties.Settings.Default.IsFirstRun == true)
            {
                Application.Run(new ConfigurationForm());
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new MainForm());
            }

        }
    }
}
