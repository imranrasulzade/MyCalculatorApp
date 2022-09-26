using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    public partial class Form1 : Form
    {
        char _operation;
        bool _cleanScreen;
        double _firstNumber;
        //List<double> _answerHistory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "0";
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "0";
                _cleanScreen = false;
            }
            textBox1.Text += ".";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _cleanScreen = true;
            _firstNumber = Convert.ToDouble(textBox1.Text);
        }

        private void equalsbutton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(textBox1.Text);
            double answer;

            switch (_operation)
            {
                case '+':
                    answer = _firstNumber + secondNumber;
                   // _answerHistory.Add(answer);
                    break;
                case '-':
                    answer = _firstNumber - secondNumber;
                   // _answerHistory.Add(answer);
                    break;
                case 'x':
                    answer = _firstNumber * secondNumber;
                   // _answerHistory.Add(answer);
                    break;
                case '/':
                    answer = _firstNumber / secondNumber;
                   // _answerHistory.Add(answer);
                    break;
                default:
                    answer = 0;
                    break;
            }

            textBox1.Text = Convert.ToString(answer);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _cleanScreen = true;
            _firstNumber = Convert.ToDouble(textBox1.Text);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _operation = 'x';
            _cleanScreen = true;
            _firstNumber = Convert.ToDouble(textBox1.Text);
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _cleanScreen = true;
            _firstNumber = Convert.ToDouble(textBox1.Text);
        }

        private void allDeleteButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            _firstNumber = 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                int screenTextLength = textBox1.Text.Length;
                if (screenTextLength != 1)
                {
                    textBox1.Text = textBox1.Text.Remove(screenTextLength - 1);
                }
                else
                {
                    textBox1.Text = 0.ToString();
                }
            }
        }

        private void number00Button_Click(object sender, EventArgs e)
        {
            if (_cleanScreen)
            {
                textBox1.Text = "";
                _cleanScreen = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += "00";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach (double item in List)
            {
                textBox1.Text = item.ToString();
            }*/
        }
    }
}
