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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        String Option;
        double Result;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Option = "-";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Option = "+";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);

            if (Option==("+"))
                Result = num1 + num2;
            if (Option==("-"))
                Result = num1 - num2;
            if (Option==("*"))
                Result = num1 * num2;
            if (Option==("/"))
                Result = num1 / num2;

            textBox1.Text = Result + "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Option = "*";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Option = "/";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
