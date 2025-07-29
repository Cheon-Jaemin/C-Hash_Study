using AxWMPLib;
using NAudio.Wave;
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
    public partial class Form6 : Form
    {
        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            PlayBackgroundMusic("바비 킴-02-일년을 하루같이.mp3");
        }
        private void PlayBackgroundMusic(string path)
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(path);

            outputDevice.PlaybackStopped += (s, e) =>
            {
                audioFile.Position = 0;
                outputDevice.Play();
            };

            outputDevice.Init(audioFile);

            outputDevice.Play();
        }
    }
}
