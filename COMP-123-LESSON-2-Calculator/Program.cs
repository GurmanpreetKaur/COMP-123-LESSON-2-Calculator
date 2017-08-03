using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name- Gurmanpreet Kaur
 * student number - 300933392
 * date - 3 august , 2017
 * description - this is calculator demo project 
 * version 0.1- created the project 
 * */
namespace COMP_123_LESSON_2_Calculator
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
            Application.Run(new Calculator());
        }
    }
}
