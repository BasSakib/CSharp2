using System; //kekw Changes for git
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondTIME
{
    public partial class Form1 : Form
    {
        private double number1 = 0;
        private string sign = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void txt(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sign = "X";
            number1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sign = "/";
            number1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sign = "-";
            number1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            sign = "+";
            number1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double number2 = double.Parse(textBox1.Text);
            double result = 0;

            switch(sign)
            {
                case "+":
                    result = number1 + number2;
                    break;

                    case "-":
                    result = number1 - number2;
                    break;

                case "X":
                    result = number1 * number2;
                    break;

                case "/":
                    result = number1 / number2;
                    break;


            }
            textBox1.Text = result.ToString();
        }
    }
}
