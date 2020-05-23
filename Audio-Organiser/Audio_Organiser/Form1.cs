using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audio_Organiser
{
    public partial class MainWindow : Form
    {
        System.Media.SoundPlayer playa;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void songToolStripMenuItem_Click(object sender, EventArgs e)
         {
            openFileDialog1.InitialDirectory = @"Biblioteki\Muzyka";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();     
            if (openFileDialog1.FileName != "")
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1.FileName = source;
                saveFileDialog1.ShowDialog();
                string destination = saveFileDialog1.FileName;
                string command = " /C COPY " + "\"" + source + "\"" + " " + "\"" + destination + "\"";
                System.Diagnostics.Process.Start("CMD.exe", command);
            }
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not work yet.");
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();      
            if (openFileDialog1.FileName != "")
            {
                string source = openFileDialog1.FileName;
                playa = new System.Media.SoundPlayer(@source);
                playa.Play();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            playa.Stop();
        }
    }
}