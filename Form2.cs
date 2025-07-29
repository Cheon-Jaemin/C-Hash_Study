using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "C언어 공부를 열심히 합시다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "C++ 공부를 열심히 합시다.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "C# 공부를 열심히 합시다.";
        }
    }
}
