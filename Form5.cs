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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = (int)numericUpDown1.Value;
            int num2 = (int)numericUpDown2.Value;

            if (num1 > num2)
            {
                lb_Result1.Text = "첫 번째 숫자가 두 번째 숫자보다 큽니다.";
            }
            else if (num1 < num2)
            {
                lb_Result1.Text = "두 번째 숫자가 첫 번째 숫자보다 큽니다.";
            }
            else
            {
                lb_Result1.Text = "두 숫자가 서로 같습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = comboBox1.Text;

            switch(str)
            {
                case "일":
                    {
                        lb_Result2.Text = "일요일 입니다.";
                        break;
                    }
                case "월":
                    {
                        lb_Result2.Text = "월요일 입니다.";
                        break;
                    }
                case "화":
                    {
                        lb_Result2.Text = "화요일 입니다.";
                        break;
                    }
                case "수":
                    {
                        lb_Result2.Text = "수요일 입니다.";
                        break;
                    }
                case "목":
                    {
                        lb_Result2.Text = "목요일 입니다.";
                        break;
                    }
                case "금":
                    {
                        lb_Result2.Text = "금요일 입니다.";
                        break;
                    }
                case "토":
                    {
                        lb_Result2.Text = "토요일 입니다.";
                        break;
                    }
                default:
                    {
                        lb_Result2.Text = "올바른 값을 선택하세요.";
                        break;
                    }
            }
        }
    }
}
