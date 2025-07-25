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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bt_For_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string str = "";

            for (int i = 2; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    str += string.Format("{0} x {1} = {2}\n", i, j, i * j);
                }
            }
            richTextBox1.Text = str.ToString();
        }

        private void bt_Foreach_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            string[] strArr = { "김된모", "이수피아", "박준수", "최강창민", "유노윤호", "영웅재중", "흐예나", };

            foreach (var value in strArr) 
            {
                int i = random.Next(1, 10);
                sb.AppendLine(string.Format("{0} 학생은 {1}반 입니다.", value, i));
            }
            richTextBox1.Text = sb.ToString();
        }

        private void bt_While_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 10;

            while(i > 0)
            {
                sb.Append(string.Format("i : {0}\n", i--));
            }
            richTextBox1.Text = sb.ToString();
        }

        private void bt_DoWhile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 20;

            do
            {
                sb.AppendLine(string.Format("i : {0}", i--));
            } while(i > 0);

            richTextBox1.Text = sb.ToString();
        }
    }
}
