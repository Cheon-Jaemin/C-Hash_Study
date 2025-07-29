using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForm4
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            //Form newForm = new Form();
            //newForm.Text = "새로 만들기 폼";
            //newForm.Size = new System.Drawing.Size(500, 500);
            //newForm.Show();
            //this.Controls.Add(textBox1);

            //textBox1.Text = "";

            //string folderPath = @"c:\Temp";
            //string fileName = "NewFile.txt";
            //string filePath = Path.Combine(folderPath, fileName);

            //try 
            //{
            //    if(!Directory.Exists(folderPath))
            //    {
            //        Directory.CreateDirectory(folderPath);
            //    }
            //    if (!File.Exists(filePath)) 
            //    {
            //        File.Create(filePath).Close();
            //        MessageBox.Show($"파일이 생성되었습니다 :\n {filePath}", "성공");
            //    }
            //    else
            //    {
            //        MessageBox.Show("파일이 이미 존재합니다.", "알림");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("오류 발생 : " + ex.Message, "에러");
            //}

            string folderPath = @"C:\Temp";

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"NewFile{timestamp}.txt";
                string filePath = Path.Combine(folderPath, fileName);

                File.Create(filePath).Close();
                MessageBox.Show($"파일이 생성되었습니다 : \n {filePath}", "성공");
            }
            catch(Exception ex)
            {
                MessageBox.Show("오류 발생 : " + ex.Message, "에러");
            }
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            lbResult.Text = "파일을 엽니다.";
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            lbResult.Text = "파일을 저장합니다.";
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuCal_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void toolStripMenuPi_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }
    }
}
