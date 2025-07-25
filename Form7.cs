using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApplication
{
    public partial class Form7 : Form
    {
        int num1 = 0;
        string operation = "";

        public Form7()
        {
            InitializeComponent();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
            operation = "";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            operation = "+";
            textBox1.Text = "";
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            operation = "-";
            textBox1.Text = "";
        }

        private void bt_Multi_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            operation = "*";
            textBox1.Text = "";
        }

        private void bt_Div_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            operation = "/";
            textBox1.Text = "";
        }

        private void bt_Equal_Click(object sender, EventArgs e)
        {
            int num2 = int.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    {
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    }
                case "-":
                    {
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    }
                case "*":
                    {
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    }
                case "/":
                    {
                        if (num2 != 0)
                        {
                            textBox1.Text = (num1 / num2).ToString();
                        }
                        else
                        {
                            textBox1.Text = "0으로 나눌 수 없음.";
                        }
                        break;
                    }
            }
        }

        private void bt_BS_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1).ToString();
        }
    }
}
