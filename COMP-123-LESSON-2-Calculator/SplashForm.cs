using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name- Gurmanpreet Kaur
 * student number - 300933392
 * date - 8 august , 2017
 * description - this is the SplashForm class  
 * version 0.4-  Created a public property as an Alias to Program.Calculator
 * */
namespace COMP_123_LESSON_2_Calculator
{
    public partial class SplashForm : Form
    {
        // private instance variables 
        private Calculator _calculator;

        //public properties
        public Calculator Calculator
        {
            get
            {
                return Program.calculator;
            }
        }
            // constructors ----------------------------
           /// <summary>
           /// /this is the main constructor for the splashform 
           /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            
            this.Calculator.Show();
            this.Hide();

            SplashFormTimer.Enabled = false; //turn timer off
        }
    }
}
