using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string data)
        {
            InitializeComponent();
            textBox1.Text = data;
        }
        public string TextBox1
        {
            set { textBox1.Text = value; }
        }

        //public void UpdateData (string data)
        //{
        //    textBox1.Text = data;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }
    }
}
