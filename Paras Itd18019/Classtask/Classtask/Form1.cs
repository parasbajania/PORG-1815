using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classtask
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string opertion = "";
        bool pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text =="0" )||(pressed))
                    textBox1.Clear();
             pressed = false;
            Button bp = (Button)sender;
            textBox1.Text = textBox1.Text + bp.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button bp = (Button)sender;
            opertion= bp.Text;
            value = Double.Parse(textBox1.Text);
            pressed = true;
            label1.Text = value + " " + opertion;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text ="";
            switch (opertion)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }
    }
}
