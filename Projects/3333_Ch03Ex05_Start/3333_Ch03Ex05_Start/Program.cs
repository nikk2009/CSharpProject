// Revised 9/16/12015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _3333_Ch03Ex05_Start
{
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
            Application.Run(new Form1());
        }
    }
}
