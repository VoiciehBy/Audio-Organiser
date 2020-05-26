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
            openFileDialog1.Filter = "Music Files(*.mp3; *.wav)|*.mp3; *.wav";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = Path.GetExtension(openFileDialog1.FileName);
                if (s == ".mp3" || s == ".wav")
                {
                    var f = TagLib.File.Create(openFileDialog1.FileName);
                    Song newSong = new Song();
                    newSong.file = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    newSong.artist = f.Tag.Performers[0];
                    newSong.title = f.Tag.Title;
                    newSong.album = f.Tag.Album;
                    newSong.year = (int?)f.Tag.Year;
                    newSong.genre = f.Tag.FirstGenre;
                    newSong.path = openFileDialog1.FileName;
                    DatabaseDC.Song.InsertOnSubmit(newSong);
                    DatabaseDC.SubmitChanges();

                    LoadMusic();
                }
                else MessageBox.Show("Zły format pliku. Tylko mp3 i wav.");
            }
        }

        //do usuniecia?
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
            if (listViewSongs.SelectedIndices.Count <= 0) return;

            if (File.Exists(listViewSongs.SelectedItems[0].SubItems[1].Text))
            {
                player.open(listViewSongs.SelectedItems[0].SubItems[1].Text);
                player.volume(VolumeBar.Value);
                player.play();
            }
            else
            {
                //nie ma pliku w tej sciezce
            }
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int select = listViewSongs.SelectedIndices[0];
            select++;
            int last = listViewSongs.Items.Count;
            if (select == last) return;
            
            player.stop();
            listViewSongs.Items[select].Selected = true;

            if (File.Exists(listViewSongs.SelectedItems[0].SubItems[1].Text))
            {
                player.open(listViewSongs.SelectedItems[0].SubItems[1].Text);
                player.volume(VolumeBar.Value);
                player.play();
            }
            else
            {
                //nie ma pliku w tej sciezce
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int select = listViewSongs.SelectedIndices[0];
            select--;
            if (select < 0) return;

            player.stop();
            listViewSongs.Items[select].Selected = true;
            
            if (File.Exists(listViewSongs.SelectedItems[0].SubItems[1].Text))
            {
               player.open(listViewSongs.SelectedItems[0].SubItems[1].Text);
               player.volume(VolumeBar.Value);
               player.play();
            }
            else
            {
                //nie ma pliku w tej sciezce
            }
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
                Refresh();
                string pathh = listViewSongs.SelectedItems[0].SubItems[1].Text;
                string path2 = pathh.Remove(pathh.LastIndexOf("\\") + 1) + textBoxFile.Text + Path.GetExtension(pathh);
                //var fi = new FileInfo(pathh);
                //var fi2 = new FileInfo(path2);
                if (!File.Exists(path2) || pathh == path2)
                {
                    if (File.Exists(pathh))
                    {
                        var f = TagLib.File.Create(pathh);
                        //f.Tag.Performers[0] = textBoxArtist.Text;
                        f.Tag.Performers = null;
                        f.Tag.Performers = new [] {textBoxArtist.Text};
                        f.Tag.Title = textBoxTitle.Text;
                        f.Tag.Album = textBoxAlbum.Text;
                        f.Tag.Year = (uint)Int32.Parse(textBoxYear.Text);
                        f.Tag.Genres = null;
                        f.Tag.Genres = new[] { textBoxGenre.Text };
                        f.Save();

                        if (pathh != path2) File.Move(pathh, path2);
                        MessageBox.Show(pathh + path2);
                    }
                    else MessageBox.Show("Plik o ścieżce zapisanej w bazie nie istnieje. "+pathh+path2);
                    DatabaseDC.ExecuteCommand("UPDATE Song SET [file]=N'" + textBoxFile.Text + "', artist=N'" + textBoxArtist.Text + "', title=N'" + textBoxTitle.Text + "', album=N'" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre=N'" + textBoxGenre.Text + "', path=N'" + path2 + "' WHERE id='" + listViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                else
                {
                    if(File.Exists(pathh)) MessageBox.Show("Plik o podanej nazwie docelowej już istnieje.");
                    else MessageBox.Show("Plik o ścieżce zapisanej w bazie nie istnieje oraz plik o podanej nazwie docelowej już istnieje.");
                    DatabaseDC.ExecuteCommand("UPDATE Song SET artist=N'" + textBoxArtist.Text + "', title=N'" + textBoxTitle.Text + "', album=N'" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre=N'" + textBoxGenre.Text + "' WHERE id='" + listViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                DatabaseDC.SubmitChanges();
                DatabaseDC = null;
                DatabaseDC = new DatabaseMusicDataContext();
                LoadMusic();
                textBoxFile.Text = "";
                textBoxArtist.Text = "";
                textBoxTitle.Text = "";
                textBoxAlbum.Text = "";
                textBoxYear.Text = "";
                textBoxGenre.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Jesteś pewien?", "Ostrzeżenie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    DatabaseDC.ExecuteCommand("DELETE FROM Song WHERE id='" + listViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                DatabaseDC.SubmitChanges();
                DatabaseDC = null;
                DatabaseDC = new DatabaseMusicDataContext();
                LoadMusic();
                textBoxFile.Text = "";
                textBoxArtist.Text = "";
                textBoxTitle.Text = "";
                textBoxAlbum.Text = "";
                textBoxYear.Text = "";
                textBoxGenre.Text = "";
            }
        }
    }
}