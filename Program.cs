﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10__301044130_
{
    public static class Program
    {

        public static Dictionary<string, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<string, Form>();
            Forms.Add("StartForm", new StartForm());
            Forms.Add("MainForm", new MainForm());
            Forms.Add("EndForm", new EndForm());
            Application.Run(Forms["StartForm"]);
        }
    }
}
