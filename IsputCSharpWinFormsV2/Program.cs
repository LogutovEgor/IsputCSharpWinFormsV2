using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IsputCSharpWinFormsV2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static public List<string> arg;
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            arg = new List<string>();
            for (int i = 0; i < args.Length; i++)
            {
                arg.Add(args[i]);
            }
            MainForm main = new MainForm();
            Application.Run(main);
            
        }
    }
}
