using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PocketNotepad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main(string[] argv)
        {
            if (argv != null && argv.Length != 0)
            {
                Application.Run(new formNotepad(argv[0]));
            }
            else
            {
                Application.Run(new formNotepad());
            }
        }
    }
}