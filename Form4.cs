using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            PlayBackgroundMusic(@"바비 킴-02-일년을 하루같이.mp3");
        }
        private void PlayBackgroundMusic(string filePath) 
        {
            axWindowsMediaPlayer1.URL = filePath;

            axWindowsMediaPlayer1.settings.autoStart = true;

            axWindowsMediaPlayer1.settings.setMode("loop", true);

            axWindowsMediaPlayer1.uiMode = "none";

            axWindowsMediaPlayer1.settings.volume = 50;
        }
    }
}
