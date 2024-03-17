using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaneInternet.unit;

namespace VaneInternet {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            string a = "test.ojb";
            var i = a.LastIndexOf('.');
            Console.WriteLine(a.Substring(0, i));
            if (args.Length == 0) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            } else {
                
            }
        }
    }
}