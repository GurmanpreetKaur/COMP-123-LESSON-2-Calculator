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
 * date - 8 august , 2017
 * description - this is calculator demo project 
 * version 0.8- Added the functionality to 'x' , '÷','Del' Buttons
 * */
namespace COMP_123_LESSON_2_Calculator
{
    public partial class Calculator : Form
    {
        //private instance variables 
        private bool _idDecimalClicked;
        private string _currentOperator;
        private List<double> _operandList;
        private double _result;
        private bool _isOperandTwo;


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

        public string CurrentOperator
        {

            get
            {
                return this._currentOperator;
            }

            set
            {
                this._currentOperator = value;
            }

        }

        public List<double> OperandList
        {

            get
            {
                return this._operandList;
            }

            set
            {
                this._operandList = value;
            }

        }
        public double REsult
        {

            get
            {
                return this._result;
            }

            set
            {
                this._result = value;
            }

        }
        public bool IsOperandTwo
        {

            get
            {
                return this._isOperandTwo;
            }

            set
            {
                this._isOperandTwo = value;
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
            Button calculatorButton = sender as Button; //  (this is called downcasting)

            if ((this.IsDecimalClicked) && (calculatorButton.Text == "."))
            {
                return;
            }

            if (calculatorButton.Text == ".")
            {
                this.IsDecimalClicked = true;
            }


            if (Result.Text == "0")
            {
                if (calculatorButton.Text == ".")
                {
                    Result.Text += calculatorButton.Text;
                }
                else
                {
                    Result.Text = calculatorButton.Text;
                }
            }
            else
            {
                if ((OperandList.Count > 0) && (this._isOperandTwo == false))
                {

                    Result.Text = calculatorButton.Text;
                    this._isOperandTwo = true;

                }
                else
                {
                    Result.Text += calculatorButton.Text;
                }
            }


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
            double operand = this._convertOperand(Result.Text); // convert to number
            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
                case "=":
                    this._showResult(operand);
                    break;
                case "Del":
                    Result.Text = Result.Text.Substring(0, (Result.TextLength - 1)); 
                    break;
                case "±":
                    break;
                default:
                    this._calculate(operand, operatorButton.Text);
                    break;
            }
        }

        /// <summary>
        /// This method shows the Result of the last operation in the ResultTextBox
        /// </summary>
        /// <param name="text"></param>
        private void _showResult(double operand)
        {
            this._calculate(operand, this.CurrentOperator);
            Result.Text = this.REsult.ToString();

        }

        /// <summary>
        /// This method calculates the result of all the operands in the OperandList
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        private void _calculate(double operand, string operatorString)
        {

            OperandList.Add(operand);
            if (OperandList.Count > 1)
            {
                switch (operatorString)
                {
                    case "+":
                        this.REsult = this.OperandList[0] + this.OperandList[1];
                        break;
                    case "-":
                        this.REsult = this.OperandList[0] - this.OperandList[1];
                        break;
                    case "x":
                        this.REsult = this.OperandList[0] * this.OperandList[1];
                        break;
                    case "÷":
                        if (this.OperandList[1] != 0)
                        {
                            this.REsult = (this.OperandList[0] / this.OperandList[1]);
                        }
                        else
                        {
                            Result.Text = "Cannot be divided by zero";
                        }
                        
                        break;
                }
                this.OperandList.Clear();
                this.OperandList.Add(this.REsult);
                this.IsOperandTwo = false;
            }
            this.CurrentOperator = operatorString;
        }
        /// <summary>
        /// This method converts the string from the ResultTextBox to a number
        /// </summary>
        /// <param name="operandString"></param>
        /// <returns></returns>
        private double _convertOperand(string operandString)
        {
            try
            {
                return Convert.ToDouble(operandString);
            }
            catch (Exception exception)
            {

                Debug.WriteLine("An Error Occurred");
                Debug.WriteLine(exception.Message);
            }
            return 0;

        }
        /// <summary>
        /// this is the private _clear method. It resets / clears the calculator.
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            Result.Text = "0";
            this.CurrentOperator = "C";
            this.OperandList = new List<double>();
            this.IsOperandTwo = false;
            this.REsult = 0;
        }


        /// <summary>
        /// this is the event handler for the "Load" event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_Load(object sender, EventArgs e)
        {
            this._clear();
        }
    }
}
