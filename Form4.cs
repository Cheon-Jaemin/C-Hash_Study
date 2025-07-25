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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(text_Num1.Text);
            double num2 = double.Parse(text_Num2.Text);

            double result = num1 + num2;
            text_Result.Text = result.ToString();
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(text_Num1.Text);
            double num2 = double.Parse(text_Num2.Text);

            double result = num1 - num2;
            text_Result.Text = result.ToString();
        }

        private void bt_Multi_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(text_Num1.Text);
            double num2 = double.Parse(text_Num2.Text);

            double result = num1 * num2;
            text_Result.Text = result.ToString();
        }

        private void bt_Division_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(text_Num1.Text);
            double num2 = double.Parse(text_Num2.Text);

            double result = num1 / num2;
            text_Result.Text = result.ToString();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            text_Num1.Text = "";
            text_Num2.Text = "";
            text_Result.Text = "";
        }
    }
}
