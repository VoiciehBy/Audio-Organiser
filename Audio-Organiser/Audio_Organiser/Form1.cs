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
        DatabaseMusicDataContext DatabaseDC = new DatabaseMusicDataContext();
        System.Media.SoundPlayer playa;
        public MainWindow()
        {
            InitializeComponent();
            LoadMusic();
        }

        private void LoadMusic()
        {
            listBoxUtwory.Items.Clear();
            foreach(Song s in DatabaseDC.Song)
            {
                listBoxUtwory.Items.Add(s);
            }
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

        private void listBoxUtwory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var f = TagLib.File.Create(openFileDialog1.FileName);
                Song newSong = new Song();
                newSong.Artist = f.Tag.FirstAlbumArtist;
                newSong.Title = f.Tag.Title;
                newSong.Path = openFileDialog1.FileName;

                DatabaseDC.Song.InsertOnSubmit(newSong);
                DatabaseDC.SubmitChanges();

                LoadMusic();
            }
        }
    }
}