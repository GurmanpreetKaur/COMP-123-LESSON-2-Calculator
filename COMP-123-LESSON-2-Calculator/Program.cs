using System;
using System.Windows.Forms;
/*
 * Name- Gurmanpreet Kaur
 * student number - 300933392
 * date - 3 august , 2017
 * description - this is calculator demo project 
 * version 0.3- created an instance of the calculotor object 
 * */
namespace COMP_123_LESSON_2_Calculator
{
    public   static class Program
    {
        //create references to forms
      public static  Calculator calculator ;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public  static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //instantiate a new object of type calculator
            calculator = new Calculator();
            Application.Run(new SplashForm());
        }
    }
}
