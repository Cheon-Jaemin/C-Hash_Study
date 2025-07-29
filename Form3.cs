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
    public partial class Form3 : Form
    {
        Form2 f1;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = (comboBox1.Text + " " + comboBox2.Text + " " + textBox1.Text);
            f1.TextBox1 = text;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("강남구");
                comboBox2.Items.Add("강동구");
                comboBox2.Items.Add("강북구");
                comboBox2.Items.Add("강서구");
                comboBox2.Items.Add("관악구");
                comboBox2.Items.Add("광진구");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("가평군");
                comboBox2.Items.Add("고양시 덕양구");
                comboBox2.Items.Add("남양주시");
                comboBox2.Items.Add("광명시");
                comboBox2.Items.Add("과천시");
                comboBox2.Items.Add("고양시 일산동구");
                comboBox2.Items.Add("고양시 일산서구");
            }
            
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("천안시 동남구");
                comboBox2.Items.Add("천안시 서북구");
                comboBox2.Items.Add("아산시");
                comboBox2.Items.Add("서산시");
                comboBox2.Items.Add("태안군");
            }
        }
    }
}
