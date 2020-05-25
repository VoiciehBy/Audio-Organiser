using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audio_Organiser
{
    public partial class MainWindow : Form
    {
        DatabaseMusicDataContext DatabaseDC = new DatabaseMusicDataContext();
        private AudioPlayer player = new AudioPlayer();

        public MainWindow()
        {
            InitializeComponent();
            LoadMusic();
        }

        private void LoadMusic()
        {
            listViewSongs.Items.Clear();
            foreach(Song s in DatabaseDC.Song)
            {
                ListViewItem item = new ListViewItem(s.id.ToString());
                item.SubItems.Add(s.path);
                item.SubItems.Add(s.file);
                item.SubItems.Add(s.artist);
                item.SubItems.Add(s.title);
                item.SubItems.Add(s.album);
                item.SubItems.Add(s.year.ToString());
                item.SubItems.Add(s.genre);
                listViewSongs.Items.Add(item);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var f = TagLib.File.Create(openFileDialog1.FileName);
                Song newSong = new Song();
                newSong.file = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                newSong.artist = f.Tag.FirstAlbumArtist;
                newSong.title = f.Tag.Title;
                newSong.album = f.Tag.Album;
                newSong.year = (int?)f.Tag.Year;
                newSong.genre = f.Tag.FirstGenre;
                newSong.path = openFileDialog1.FileName;

                DatabaseDC.Song.InsertOnSubmit(newSong);
                DatabaseDC.SubmitChanges();

                LoadMusic();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sofd = new OpenFileDialog())
            {
                sofd.Filter = "Pliki .mp3|*.mp3|Pliki .wav|*.wav";
                if (sofd.ShowDialog() == DialogResult.OK)
                {
                    player.open(sofd.FileName);
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //tu potrzebna kolumna ze sciezka i ja wyciac albo inaczej to wykminic
            //player.open(listBoxUtwory.SelectedItem.ToString());
            player.volume(VolumeBar.Value);
            player.play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            player.pause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.stop();
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            player.volume(VolumeBar.Value);
        }

        private void listViewSongs_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                textBoxFile.Text = listViewSongs.SelectedItems[0].SubItems[2].Text;
                textBoxArtist.Text = listViewSongs.SelectedItems[0].SubItems[3].Text;
                textBoxTitle.Text = listViewSongs.SelectedItems[0].SubItems[4].Text;
                textBoxAlbum.Text = listViewSongs.SelectedItems[0].SubItems[5].Text;
                textBoxYear.Text = listViewSongs.SelectedItems[0].SubItems[6].Text;
                textBoxGenre.Text = listViewSongs.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                DatabaseDC.ExecuteCommand("UPDATE Song SET [file]='" + textBoxFile.Text + "', artist='" + textBoxArtist.Text + "', title='" + textBoxTitle.Text + "', album='" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre='" + textBoxGenre.Text + "' WHERE id='" + listViewSongs.SelectedItems[0].SubItems[0].Text + "';");
            }
            DatabaseDC.SubmitChanges();
            DatabaseDC = null;
            DatabaseDC = new DatabaseMusicDataContext();
            LoadMusic();
        }
    }
}