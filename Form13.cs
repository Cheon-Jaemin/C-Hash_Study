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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }
    }
}
