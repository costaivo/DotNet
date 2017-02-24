using System;
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
    }
}
