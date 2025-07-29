using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            PlayBackgroundMusic(@"바비 킴-02-일년을 하루같이.mp3");
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;

            trackBar1.Value = 50;
        }
        private void PlayBackgroundMusic(string filePath)
        {
            axWindowsMediaPlayer1.URL = filePath;

            axWindowsMediaPlayer1.settings.autoStart = true;

            axWindowsMediaPlayer1.settings.setMode("loop", true);

            axWindowsMediaPlayer1.uiMode = "none";

            axWindowsMediaPlayer1.settings.volume = 50;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }
    }
}
