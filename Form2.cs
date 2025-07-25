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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = lb_Test.Text;  //제목 문자열

            //문자열이 안에 해당하는 문자열이 있는지 확인
            lb_Contain.Text = str.Contains("Test").ToString();
            //문자열이 해당 문자열과 동일한지 확인
            lb_Equals.Text = str.Equals("Test").ToString();
            //개체의 문자수를 반환
            lb_Length.Text = str.Length.ToString();
            //지정된 문자열을 다른 문자열로 변환
            lb_Replace.Text = str.Replace("Test", "Good").ToString();

            //문자열에서 조건에 맞는 문자를 기준으로 분할
            string[] strArr = str.Split('_');
            lb_Split.Text = strArr[0].ToString();
            lb_Split2.Text = strArr[1].ToString();

            //3번째부터 5글자를 추출
            lb_Substring.Text = str.Substring(3, 5).ToString();

            //대소문자 변환
            lb_ToLower.Text = str.ToLower().ToString();
            lb_ToUpper.Text = str.ToUpper().ToString();

            //문자열 전, 후 공백을 제거
            lb_Trim.Text = str.Trim().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_Contain.Text = "-";
            lb_Equals.Text = "-";
            lb_Length.Text = "-";
            lb_Replace.Text = "-";
            lb_Split.Text = "-";
            lb_Split2.Text = "-";
            lb_Substring.Text = "-";
            lb_ToLower.Text = "-";
            lb_ToUpper.Text = "-";
            lb_Trim.Text = "-";
        }
    }
}
