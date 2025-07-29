using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Control
{
    public partial class Make_Controls : UserControl
    {
        public Make_Controls()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            MessageBox.Show(date, "오늘 날짜");
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH : mm : ss");
            MessageBox.Show(time, "현재 시간");
        }
    }
}
