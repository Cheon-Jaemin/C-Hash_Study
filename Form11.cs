using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        public string password = "486";
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input == password)
            {
                MessageBox.Show("열렸습니다.");
                this.Close();
            }
            else
            {
                cnt++;
                if(cnt < 4)
                {
                    MessageBox.Show(string.Format("다시 입력하세요. ({0}번 남았습니다.)", (5 - cnt).ToString()));
                    textBox1.Text = "";
                }
                else if (cnt == 4)
                {
                    MessageBox.Show("마지막 시도 입니다.");
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("입력을 초과하였습니다.");
                    this.Close();
                }
            }
        }
    }
}
