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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics, 0, 0, 0); //x축0, y축 0, 인덱스 0번 이미지
            imageList1.Draw(e.Graphics, 280, 400, 1); //x축70, y축 0, 인덱스 1번 이미지
            imageList1.Draw(e.Graphics, 280, 0, 2); //x축140, y축 0, 인덱스 2번 이미지
        }
    }
}
