using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2._1
{
    public partial class Form1 : Form
    {
        
        ICalculator myMath = new Math(); // creating a new instance of the interface to implement its methods in the buttons
        string opr;
        double firstNum;        
        double secondNum;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        private void n1_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 1; // this will assign the number 1 and display it on the text field as text // Same repeated for 2 - 9 and 0
        }

        private void n2_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 2;
        }

        private void n3_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 3;
        }

        private void n4_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 4;
        }

        private void n5_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 5;
        }

        private void n6_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 6;
        }

        private void n7_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 7;
        }

        private void n8_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 8;
        }

        private void n9_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 9;
        }

        private void n0_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + 0;
        }

        private void nDot_Click(object sender, EventArgs e)
        {
            if(txtField.Text.Contains(".")) // checks if . is already present
            {
                txtField.Text = txtField.Text;
            }
            else
            {
                txtField.Text = txtField.Text + "."; // if not then writes it on the text field
            }
        }

        private void nPlus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtField.Text);
            opr = "+"; // adding the ooperation sign after firstnumber input. // same applies to - , /and *
            txtField.Clear();
            
        }
        private void nMinus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtField.Text);
            opr = "-";
            txtField.Clear();
        }

        private void nMultiply_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtField.Text);
            opr = "*";
            txtField.Clear();
        }

        private void nDivision_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtField.Text);
            opr = "/";
            txtField.Clear();
        }

        private void nEquals_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtField.Text);
            switch (opr)  // switch case uses methods implemented in the interface.
            {
                case "+":
                    result = myMath.Add(firstNum, secondNum);
                    txtField.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = myMath.Subtract(firstNum, secondNum);
                    txtField.Text = Convert.ToString(result);
                    break;
                case "*":
                    result = myMath.Multiply(firstNum, secondNum);
                    txtField.Text = Convert.ToString(result);
                    break;
                case "/":
                    if(secondNum == 0)
                    {
                        txtField.Text = "0.0";
                        break;
                    }
                    else
                    {
                        result = myMath.Divide(firstNum,secondNum);
                        txtField.Text = Convert.ToString(result);
                        break;
                    }
            }
        }

        private void nClear_Click(object sender, EventArgs e)
        {
            txtField.Text = "";
        }
    }
}
