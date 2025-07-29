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
    public partial class Form12 : Form
    {
        private float zoomfactor = 1.0f;
        private float zoomStep = 0.05f;

        public Form12()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(Form12_MouseWheel);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form12_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomfactor += zoomStep;
            }
            else if (e.Delta < 0) 
            {
                zoomfactor = Math.Max(zoomfactor - zoomStep, 0.1f);
            }
            pictureBox1.Width = (int)(pictureBox1.Image.Width * zoomfactor);
            pictureBox1.Height = (int)(pictureBox1.Image.Height * zoomfactor);
        }
    }
}
