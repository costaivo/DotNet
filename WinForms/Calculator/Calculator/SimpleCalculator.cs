using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
 

    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private double _runningValue = 0;
        private string _selectedOperator = "";

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Reset display and local store variables
            txtDisplay.Text = "0";
            _selectedOperator = string.Empty;
            _runningValue = 0;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            //check if any operator was clicked previously
            if (txtDisplay.Text == "+" || txtDisplay.Text == "-" || txtDisplay.Text == "*"
                || txtDisplay.Text == "/" || txtDisplay.Text == "0")
            {
                //Reset display text and show blank
                txtDisplay.Text = "";
            }

            string currentNumber = ((Button)sender).Text;

            txtDisplay.Text += currentNumber;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            var currentOperator = ((Button)sender).Text;
            ProcessOperator(currentOperator);
        }

        private void ProcessOperator(string currentOperator)
        {
            if (currentOperator == "=")
                PerformCalculation();
            else
            {
                _selectedOperator = currentOperator;
                _runningValue = double.Parse(txtDisplay.Text);
                txtDisplay.Text = _selectedOperator;
            }
        }

        private void PerformCalculation()
        {
            double result = 0;
            double secondNumber = double.Parse(txtDisplay.Text);
            switch (_selectedOperator)
            {
                case "+":
                    result = _runningValue + secondNumber;
                    break;
                case "-":
                    result = _runningValue - secondNumber;
                    break;
                case "x":
                    result = _runningValue * secondNumber;
                    break;
                case "/":
                    result = _runningValue / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();

        }

        #region Alternate Solution using Delegates
        public delegate T CalculationHandler<T>(T firstNumber, T secondNumber);

        public double OperationAdd(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double OperationMultiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double OperationSubtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double OperationDivide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private void ProcessOperator1(string currentOperator)
        {
            if (currentOperator == "=")
                PerformCalculation1(GetOperationByOperator(currentOperator));
            else
            {
                _selectedOperator = currentOperator;
                _runningValue = double.Parse(txtDisplay.Text);
                txtDisplay.Text = _selectedOperator;
            }
        }

        [Flags]
        public enum ABC
        {
            [Description("This is my Enum")]
            ast,
            test
        }


        private CalculationHandler<double> GetOperationByOperator(string currentOperator)
        {
            CalculationHandler<double> calc=null;
            switch (currentOperator)
            {
                case "+":
                    calc = (double x, double y) => { return x + y; };
                    //calc = OperationAdd;
                    break;
                case "-":
                    calc = OperationSubtract;
                    break;
                case "x":
                    calc = OperationMultiply;
                    break;
                case "/":
                    calc = OperationDivide;
                    break;
            }
            return calc;
        }

        private void PerformCalculation1(CalculationHandler<double> calc)
        {
            double result = 0;

            //Get the second number
            double secondNumber = double.Parse(txtDisplay.Text);

            //Perform the calculation on the operands
            result = calc(_runningValue, secondNumber);

            //Display the result. 
            txtDisplay.Text = result.ToString();
           

        }


        private void PerformCalculation2(Func<double,double,double> calc)
        {
            double result = 0;
         
            //Get the second number
            double secondNumber = double.Parse(txtDisplay.Text);

            //Perform the calculation on the operands
            result = calc(_runningValue, secondNumber);

            //Display the result. 
            txtDisplay.Text = result.ToString();

        }

        #endregion
    }
}
