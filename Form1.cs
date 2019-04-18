using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double FirstNumber;
        string operation;

        private void ButtonSound()
        {
            var url = Properties.Resources.ButtonSound;
            var sound = new SoundPlayer(url);
            sound.Play();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "1";
            }

            else
            {
                ButtonSound();
                textBox1.Text = textBox1.Text + "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "2";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "3";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "4";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "5";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "6";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "7";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "8";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                ButtonSound();
                textBox1.Text = "9";
            }

            else
            {
                ButtonSound();
                textBox1.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ButtonSound();

            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }

            else
            {
                textBox1.Text += "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonSound();
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonSound();
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonSound();
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonSound();
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            ButtonSound();
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            ButtonSound();
            double SecondNumber = Convert.ToDouble(textBox1.Text);
            double result;

            if (operation == "+")
            {
                result = FirstNumber + SecondNumber;
                textBox1.Text = Convert.ToString(result);
            }

            if (operation == "-")
            {
                result = FirstNumber - SecondNumber;
                textBox1.Text = Convert.ToString(result);
            }

            if (operation == "*")
            {
                result = FirstNumber * SecondNumber;
                textBox1.Text = Convert.ToString(result);
            }

            if (operation == "/")
            {
                result = FirstNumber / SecondNumber;
                textBox1.Text = Convert.ToString(result);

                if (SecondNumber == 0)
                {
                    textBox1.Text = "Asshole";
                    MessageBox.Show("Are you stupid right?");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonSound();
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ButtonSound();
            textBox1.Text = "0";
        }
    }
}
