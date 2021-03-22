using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace разветвляющийся_алгоритм
{
    public partial class Form1 : Form
    {
        double x;
        int rb;
        double y;
        int caseSwitch;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            x = int.Parse(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                if (x > 2)
                {
                    y = Math.Sinh(x * x);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };
                if ((x > -1) && (x <= 2))
                {
                    y = 0.5 * Math.Sinh(x);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };
                if (x <= -1)
                {
                    y = Math.Abs(Math.Sinh(x) - 1);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };
            }
            else if (radioButton2.Checked == true)

            {
                if (x > 2)
                {
                    y = Math.Cosh(x * x);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                }
                    if ((x > -1) && (x <= 2))
                {
                    y = 0.5 * Math.Cosh(x);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };
                if (x <= -1)
                {
                    y = Math.Abs(Math.Cosh(x) - 1);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };

            }
            else if (radioButton3.Checked == true)
            {

                if (x > 2)
                {
                    y = Math.Exp(x * x);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };
                if ((x > -1) && (x <= 2))
                {
                    y = 0.5 * Math.Exp(x);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;
                };
                if (x <= -1)
                {
                    y = Math.Abs(Math.Exp(x) - 1);
                    y = Math.Round(y, 2);
                    textBox4.Text = "При X = " + x + Environment.NewLine + "Y = " + y;

                };

            }
            else textBox4.Text = "Ошибка";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
