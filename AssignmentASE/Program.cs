using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentASE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Method1()
        {
            Console.WriteLine("Program has just been Executed.");
            MessageBox.Show("Press Ok to proceed");
        }
        static void Method2(string fname)
        {
            Console.WriteLine(fname + " Manjit Hada");
        }
        static void Main()
        {
            Method2("Program made by");
            Method1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }
    }
}
