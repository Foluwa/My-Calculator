using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Calculator : Form
    {
        double SQUAREROOT, RESULT;
        double FirstNumber;
        double SecondNumber;
        double result;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "1";
            }
            else
            {
                displayBox.Text = displayBox.Text + "1";
            }  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "2";
            }
            else
            {
                displayBox.Text = displayBox.Text + "2";
            }  
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "3";
            }
            else
            {
                displayBox.Text = displayBox.Text + "3";
            }  
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "4";
            }
            else
            {
                displayBox.Text = displayBox.Text + "4";
            }  
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "5";
            }
            else
            {
                displayBox.Text = displayBox.Text + "5";
            }  
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "6";
            }
            else
            {
                displayBox.Text = displayBox.Text + "6";
            }  
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "7";
            }
            else
            {
                displayBox.Text = displayBox.Text + "7";
            }  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "8";
            }
            else
            {
                displayBox.Text = displayBox.Text + "8";
            }  
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "9";
            }
            else
            {
                displayBox.Text = displayBox.Text + "9";
            }  
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "0";
            }
            else
            {
                displayBox.Text = displayBox.Text + "0";
            }  
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = " - ";
            }
            else
            {
                displayBox.Text = displayBox.Text + " - ";
            }  
        }

        //****************************************************
        //ARITHMETIC OPERATIONS
        private void button12_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = " + ";
            }
            else
            {
                displayBox.Text = displayBox.Text + " + ";
            }  
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = " % ";
            }
            else
            {
                displayBox.Text = displayBox.Text + " % ";
            }  
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = " / ";
            }
            else
            {
                displayBox.Text = displayBox.Text + " / ";
            }  
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = " * ";
            }
            else
            {
                displayBox.Text = displayBox.Text + " * ";
            }  
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FirstNumber = int.Parse(displayBox.Text);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        ////// SQUARE ROOT
        private void button16_Click(object sender, EventArgs e)
        {
           FirstNumber = int.Parse(displayBox.Text);
           result =  Math.Sqrt(FirstNumber);
           displayBox.Text ="Squareroot is " + result.ToString();
        }
    }
}
