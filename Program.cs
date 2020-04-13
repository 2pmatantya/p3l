using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kouvee_Pet_Shop.Boundary;
using Kouvee_Pet_Shop.Control;


namespace Kouvee_Pet_Shop
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
            Application.Run(new FormLayanan());
        }
    }
}
