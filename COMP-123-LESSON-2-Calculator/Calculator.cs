using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name- Gurmanpreet Kaur
 * student number - 300933392
 * date - 3 august , 2017
 * description - this is calculator demo project 
 * version 0.6- Added private _clear method
 * */
namespace COMP_123_LESSON_2_Calculator
{
    public partial class Calculator : Form
    {
        //private instance variables 
        private bool _idDecimalClicked;
            //public properties 
            public bool IsDecimalClicked
        {
            get
            {
                return this._idDecimalClicked;
            }
            set
            {
                this._idDecimalClicked = value;
            }
        }
            //constructors
            /// <summary>
            /// this is the main constructor for the Calculator class
            /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is an event handler for the "FromClosing" event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// this is shared event handler for the calculator buttons
        /// not including  the operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButon_Click(object sender, EventArgs e)
        {
            Button calculatorButton = (Button)sender; // or sender as Button (this is called downcasting)
            if((this._idDecimalClicked) && (calculatorButton.Text=="."))
            {
                return; 
            }
            if(calculatorButton.Text == ".")
            {
                this._idDecimalClicked = true;
            }
            Result.Text += calculatorButton.Text;
        // Debug.WriteLine("A Calculator Button was clicked");
        }


        /// <summary>
        /// this is a shared event handler for the Operator Buttons of the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button; //downcasting 
            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
            }
        }


        /// <summary>
        /// this is the private _clear method. It resets / clears the calculator.
        /// </summary>
        private void _clear()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// this is the event handler for the "Load" event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_Load(object sender, EventArgs e)
        {
            this.IsDecimalClicked = false;
        }
    }
}
