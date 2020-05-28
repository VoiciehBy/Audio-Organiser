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
//player
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Audio_Organiser
{
    public partial class MainWindow : Form
    {
        class songsInf
        {
            public string id { get; set; }
            public string path { get; set; }
            public string file { get; set; }
            public string artist { get; set; }
            public string title { get; set; }
            public string album { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public songsInf(string id, string path, string file, string artist, string title, string album, string year, string genre)
            {
                this.id = id;
                this.path = path;
                this.file = file;
                this.artist = artist;
                this.title = title;
                this.album = album;
                this.year = year;
                this.genre = genre;
            }
        }
        DatabaseMusicDataContext DatabaseDC = new DatabaseMusicDataContext();
        //player
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        bool playing = false;
        bool muted = false;

        public MainWindow()
        {
            InitializeComponent();
            timer.Start();
            LoadMusic();
        }

        private void LoadMusic()
        {
            objectListViewSongs.Items.Clear();
            List<songsInf> item = new List<songsInf>();
            foreach (Song s in DatabaseDC.Song)
            {
                item.Add(new songsInf(s.id.ToString(), s.path, s.file, s.artist, s.title, s.album, s.year.ToString(), s.genre));

            }
            objectListViewSongs.SetObjects(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addF(string s2)
        {
            string s = Path.GetExtension(s2);
            if (s == ".mp3" || s == ".wav")
            {
                var f = TagLib.File.Create(s2);
                Song newSong = new Song();
                newSong.file = Path.GetFileNameWithoutExtension(s2);
                if (Array.Exists(f.Tag.Performers, element => element.Length > 0)) newSong.artist = f.Tag.Performers[0];
                newSong.title = f.Tag.Title;
                newSong.album = f.Tag.Album;
                newSong.year = (int?)f.Tag.Year;
                newSong.genre = f.Tag.FirstGenre;
                newSong.path = s2;
                DatabaseDC.Song.InsertOnSubmit(newSong);
                DatabaseDC.SubmitChanges();
                DatabaseDC = null;
                DatabaseDC = new DatabaseMusicDataContext();
                LoadMusic();
            }
            else MessageBox.Show("Zły format pliku. Tylko mp3 i wav.");
        }

        private void button2_Click(object sender, EventArgs e)                          //Add1
        {
            openFileDialog1.Filter = "Music Files(*.mp3; *.wav)|*.mp3; *.wav";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String s2 in openFileDialog1.FileNames)
                {
                    addF(s2);
                }
            }
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var ext = new List<string> { ".mp3", ".wav" };
                var allFiles = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => ext.Contains(Path.GetExtension(s).ToLowerInvariant()));
                foreach (var s2 in allFiles)
                {
                    addF(s2);
                }
            }
        }

        private void objectListViewSongs_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                textBoxFile.Text = objectListViewSongs.SelectedItems[0].SubItems[2].Text;
                textBoxArtist.Text = objectListViewSongs.SelectedItems[0].SubItems[3].Text;
                textBoxTitle.Text = objectListViewSongs.SelectedItems[0].SubItems[4].Text;
                textBoxAlbum.Text = objectListViewSongs.SelectedItems[0].SubItems[5].Text;
                textBoxYear.Text = objectListViewSongs.SelectedItems[0].SubItems[6].Text;
                textBoxGenre.Text = objectListViewSongs.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                Refresh();
                string pathh = objectListViewSongs.SelectedItems[0].SubItems[1].Text;
                string path2 = pathh.Remove(pathh.LastIndexOf("\\") + 1) + textBoxFile.Text + Path.GetExtension(pathh);
                if (!File.Exists(path2) || pathh == path2)
                {
                    if (File.Exists(pathh))
                    {
                        var f = TagLib.File.Create(pathh);
                        f.Tag.Performers = null;
                        f.Tag.Performers = new[] { textBoxArtist.Text };
                        f.Tag.Title = textBoxTitle.Text;
                        f.Tag.Album = textBoxAlbum.Text;
                        f.Tag.Year = (uint)Int32.Parse(textBoxYear.Text);
                        f.Tag.Genres = null;
                        f.Tag.Genres = new[] { textBoxGenre.Text };
                        try
                        {
                            f.Save();
                        }
                        catch
                        {
                            MessageBox.Show("Plik otwarty w innym programie, bądź odtwarzany w playerze.");
                            return;
                        }

                        if (pathh != path2) File.Move(pathh, path2);
                        MessageBox.Show(pathh + path2);
                    }
                    else MessageBox.Show("Plik o ścieżce zapisanej w bazie nie istnieje. " + pathh + path2);
                    DatabaseDC.ExecuteCommand("UPDATE Song SET [file]=N'" + textBoxFile.Text + "', artist=N'" + textBoxArtist.Text + "', title=N'" + textBoxTitle.Text + "', album=N'" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre=N'" + textBoxGenre.Text + "', path=N'" + path2 + "' WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                else
                {
                    if (File.Exists(pathh)) MessageBox.Show("Plik o podanej nazwie docelowej już istnieje.");
                    else MessageBox.Show("Plik o ścieżce zapisanej w bazie nie istnieje oraz plik o podanej nazwie docelowej już istnieje.");
                    DatabaseDC.ExecuteCommand("UPDATE Song SET artist=N'" + textBoxArtist.Text + "', title=N'" + textBoxTitle.Text + "', album=N'" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre=N'" + textBoxGenre.Text + "' WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                updateClear();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć ten wpis z bazy danych?", "Ostrzeżenie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    dbDel();
                }

            }
        }

        private void buttonDel2_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                if (File.Exists(objectListViewSongs.SelectedItems[0].SubItems[1].Text))
                {
                    if (MessageBox.Show("Czy na pewno chcesz usunąć ten plik z dysku?", "Ostrzeżenie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        File.Delete(objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                        if (MessageBox.Show("Czy chcesz usunąć ten wpis z bazy danych?", "Pytanie",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            dbDel();
                        }
                    }
                }
                else MessageBox.Show("Plik nie istnieje");
            }
        }

        private void dbDel()
        {
            DatabaseDC.ExecuteCommand("DELETE FROM Song WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
            int index = objectListViewSongs.SelectedIndices[0];
            updateClear();
            if (objectListViewSongs.GetItemCount() > 0)
            {
                if (index == objectListViewSongs.GetItemCount()) index--;
                objectListViewSongs.SelectObject(objectListViewSongs.GetModelObject(index));
            }
        }

        private void updateClear()
        {
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyczyścić całą bazę danych?", "Ostrzeżenie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                DatabaseDC.ExecuteCommand("DELETE FROM Song;");
                updateClear();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedIndices.Count <= 0) return;

            if (File.Exists(objectListViewSongs.SelectedItems[0].SubItems[1].Text))
            {
                //play
                PlaySong();
                //info
                UpdatePlayerInfo(audioFile.FileName, objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                //okladka
                LoadCoverArt(audioFile.FileName, objectListViewSongs.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                //nie ma pliku w tej sciezce
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            //
            playing = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopSong();
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            if (outputDevice == null) return;
            if (muted == false)
            {
                outputDevice.Volume = volumeBar.Value / 100f; //Volume to float od 0.0 do 1.0, więc dzielimy przez 100
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedIndices.Count != 0) //zwraca 0 jak nic nie zaznaczymy
            {
                int select = objectListViewSongs.SelectedIndices[0];
                select++;
                int last = objectListViewSongs.Items.Count;
                if (select == last) return;

                StopSong();
                objectListViewSongs.Items[select].Selected = true;

                if (File.Exists(objectListViewSongs.SelectedItems[0].SubItems[1].Text))
                {
                    //play
                    PlaySong();
                    //info
                    UpdatePlayerInfo(audioFile.FileName, objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                    //okladka
                    LoadCoverArt(audioFile.FileName, objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                }
                else
                {
                    //nie ma pliku w tej sciezce
                }
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedIndices.Count != 0) //zwraca 0 jak nic nie zaznaczymy
            {
                int select = objectListViewSongs.SelectedIndices[0];
                select--;
                if (select < 0) return;

                StopSong();
                objectListViewSongs.Items[select].Selected = true;

                if (File.Exists(objectListViewSongs.SelectedItems[0].SubItems[1].Text))
                {
                    //play
                    PlaySong();
                    //info
                    UpdatePlayerInfo(audioFile.FileName, objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                    //okladka
                    LoadCoverArt(audioFile.FileName, objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                }
                else
                {
                    //nie ma pliku w tej sciezce
                }
            }
        }

        private void PlaySong()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                outputDevice.Init(audioFile);
            }
            //
            playing = true;
            outputDevice.Play();
            currentLength.Text = "/ " + (audioFile.TotalTime).ToString().Substring(0, 8);
        }

        private void UpdatePlayerInfo(string pf, string hf)
        {
            if (pf == hf)
            {
                currentArtist.Text = objectListViewSongs.SelectedItems[0].SubItems[4].Text;
                currentSong.Text = objectListViewSongs.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void StopSong()
        {
            outputDevice?.Stop();
            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            //
            playing = false;
        }

        private void LoadCoverArt(string pf, string hf) //pf = playing file, hf = highlighted file 
        {
            if (pf == hf)
            {
                TagLib.File file = TagLib.File.Create(hf);
                var mStream = new MemoryStream();
                var firstPicture = file.Tag.Pictures.FirstOrDefault();
                if (firstPicture != null)
                {
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    var temp = new Bitmap(mStream, false);
                    mStream.Dispose();
                    //resize do rozmiaru (...,x_px,y_px)
                    Bitmap bm = ResizeBMP(temp, 100, 100);

                    coverPictureBox.Image = bm;
                }
                else
                {
                    Image img = Properties.Resources.icon;
                    Bitmap bm = ResizeBMP((Bitmap)img, 100, 100);
                    coverPictureBox.Image = bm;
                    //brak okladki w mp3
                }
            }
        }

        private Bitmap ResizeBMP(Bitmap bmp, int width, int height)
        {
            Bitmap res = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return res;
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (outputDevice == null) return;
            if (muted == false)
            {
                outputDevice.Volume = 0;
                muted = true;
            }
            else
            {
                outputDevice.Volume = volumeBar.Value / 100f; //Volume to float od 0.0 do 1.0, więc dzielimy przez 100
                muted = false;
            }
        }

        private void buttonAutoplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoopList_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoopSong_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (playing == true)
            {
                currentTime.Text = (audioFile.CurrentTime).ToString().Substring(0, 8);
            }
        }

        private void currentLength_Click(object sender, EventArgs e)
        {

        }

        //VRB_Events
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            defaultToolStripMenuItem.Checked = true;

            solidColorToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
            lightSalmonToolStripMenuItem.Checked = false; 
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            //
            solidColorToolStripMenuItem.Checked = true;
            whiteToolStripMenuItem.Checked = true;

            defaultToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
            lightSalmonToolStripMenuItem.Checked = false; 
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void steelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 122, 125, 128);
            solidColorToolStripMenuItem.Checked = true;
            steelToolStripMenuItem.Checked = true;

            defaultToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
            lightSalmonToolStripMenuItem.Checked = false; 
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void lightSkyBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightSkyBlue;
            solidColorToolStripMenuItem.Checked = true;
            lightSkyBlueToolStripMenuItem.Checked = true;

            defaultToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
            lightSalmonToolStripMenuItem.Checked = false; 
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void lightSteelBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255,176,196,222);
            solidColorToolStripMenuItem.Checked = true;
            lightSteelBlueToolStripMenuItem.Checked = true;

            defaultToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
            lightSalmonToolStripMenuItem.Checked = false; 
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void paoloVeronesesGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 51, 204, 102);
            solidColorToolStripMenuItem.Checked = true;
            paoloVeronesesGreenToolStripMenuItem.Checked = true;

            defaultToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            lightSalmonToolStripMenuItem.Checked = false;
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void lightSalmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 160, 122);
            solidColorToolStripMenuItem.Checked = true;
            lightSalmonToolStripMenuItem.Checked = true;

            defaultToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
            mistyRoseToolStripMenuItem.Checked = false;
        }

        private void mistyRoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 228, 225);
            solidColorToolStripMenuItem.Checked = true;
            mistyRoseToolStripMenuItem.Checked = true;

            lightSalmonToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            steelToolStripMenuItem.Checked = false;
            lightSkyBlueToolStripMenuItem.Checked = false;
            lightSteelBlueToolStripMenuItem.Checked = false;
            paoloVeronesesGreenToolStripMenuItem.Checked = false;
        }

        private void texture0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void texture1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void texture2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            /*string str = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"..\..\baza\muzyka.mdf");
            MessageBox.Show(str);*/
        }

        //VRB_Events

    }
}