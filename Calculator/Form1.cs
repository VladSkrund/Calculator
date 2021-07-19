using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = string.Empty;
        string oper1 = string.Empty;
        string oper2 = string.Empty;
        char operation;
        double result = 0;
        int k = 0;

        static double sum(double  value1, double value2)
        {

            double rslt = value1 + value2;
            return rslt;
        }
        static double diff(double value1, double value2)
        {
            double rslt = value1 - value2;
            return rslt;
        }
        static double multp(double value1, double value2)
        {

            double rslt = value1 * value2;
            return rslt;
        }
        static double divide(double value1, double value2)
        {
            double rslt = value1 / value2;
            return rslt;
        }
        static double exp(double value1, double value2)
        {
            double rslt = Math.Pow(value1, value2);
            return rslt; 
        }

        private void num1_MouseClick(object sender, MouseEventArgs e)
        {
            input += "1";
            textBox1.Text = input;
        }

        private void num2_MouseClick(object sender, MouseEventArgs e)
        {
            input += "2";
            textBox1.Text = input;
        }

        private void num3_MouseClick(object sender, MouseEventArgs e)
        {
            input += "3";
            textBox1.Text = input;
        }

        private void num4_MouseClick(object sender, MouseEventArgs e)
        {
            input += "4";
            textBox1.Text = input;
        }

        private void num5_MouseClick(object sender, MouseEventArgs e)
        {
            input += "5";
            textBox1.Text = input;
        }

        private void num6_MouseClick(object sender, MouseEventArgs e)
        {
            input += "6";
            textBox1.Text = input;
        }

        private void num7_MouseClick(object sender, MouseEventArgs e)
        {
            input += "7";
            textBox1.Text = input;
        }

        private void num8_MouseClick(object sender, MouseEventArgs e)
        {
            input += "8";
            textBox1.Text = input;
        }

        private void num9_MouseClick(object sender, MouseEventArgs e)
        {
            input += "9";
            textBox1.Text = input;
        }

        private void num0_MouseClick(object sender, MouseEventArgs e)
        {
            input += "0";
            textBox1.Text = input;
        }
        private void butcom_MouseClick(object sender, MouseEventArgs e)
        {
            if (input == string.Empty || k != 0)
            {
                input += "";
            }
            else input += ".";
            k++;
            textBox1.Text += input;
        }


        private void plus_MouseClick(object sender, MouseEventArgs e)
        {
            oper1 = input;
            operation ='+';
            input = string.Empty;
            k = 0;
            

        }

        private void minus_MouseClick(object sender, MouseEventArgs e)
        {
            oper1 = input;
            operation = '-';
            input = string.Empty;
            k = 0;
        }

        private void mult_MouseClick(object sender, MouseEventArgs e)
        {
            oper1 = input;
            operation = '*';
            input = string.Empty;
            k = 0;
        }

        private void div_MouseClick(object sender, MouseEventArgs e)
        {
            oper1 = input;
            operation = '/';
            input = string.Empty;
            k = 0;
        }

        private void exponentiation_MouseClick(object sender, MouseEventArgs e)
        {
            oper1 = input;
            operation = '^';
            input = string.Empty;
            k = 0;

        }

        private void bckspc_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = " ";
            input = string.Empty;
            oper1 = string.Empty;
            oper2 = string.Empty;
        }

        private void eq_MouseClick(object sender, MouseEventArgs e)
        {
            oper2 = input;
            double num1, num2;
            double.TryParse(oper1, out num1);
            double.TryParse(oper2, out num2);
            switch (operation)
            {
                case '+':
                    result = sum(num1, num2);
                    textBox1.Text = result.ToString();
                    input =  result.ToString();
                    break;
                case '-':
                    result = diff(num1, num2);
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                    break;
                case '*':
                    result = multp(num1, num2);
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                    break;
                case '/':
                    if (num2 == 0)
                    {
                    textBox1.Text = "Divide by 0 exception.";
                    }
                else
                {
                    result = divide(num1, num2);
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                }
                    break;
                case '^':
                    result = exp(num1, num2);
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                    break;
            }


        }

    }
}
