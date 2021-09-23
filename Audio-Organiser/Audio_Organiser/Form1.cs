using BrightIdeasSoftware;
//player
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
        bool playing = false; //czy odtwarzane
        bool muted = false; //czy wyciszone
        bool paused = false; //czy spauzowane
        bool stopped = true; //czy zastopowane
        bool autoplay = false; //czy autoodtwarzanie
        bool loopsong = false; //czy zapetlenienie piosenki
        bool looplist = false; //czy zapetlenie listy
        int list_id = -1; //id pliku na liście
        string db_id; //id pliku w bazie

        songsInf toSearch = new songsInf("", "", "", "", "", "", "", "");

        public MainWindow()
        {
            InitializeComponent();
            timer.Start();
            outputDevice = new WaveOutEvent();
            outputDevice.Volume = 1f;
            outputDevice?.Stop();
            LoadMusic();
            objectListViewPlaylist.FormatRow += delegate (object sender, FormatRowEventArgs args)
            {
                args.Item.SubItems[2].Text = (args.RowIndex + 1).ToString();
            };
            string s;
            if (!File.Exists("playlist.txt")) return;
            using (StreamReader sr = new StreamReader("playlist.txt"))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    foreach (ListViewItem item in objectListViewSongs.Items)
                    {
                        if (s == item.SubItems[0].Text)
                        {
                            objectListViewPlaylist.AddObject(objectListViewSongs.GetModelObject(item.Index));
                            break;
                        }
                    }
                }
            }
        }

        //Rafał
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter file =
                new StreamWriter("playlist.txt"))
            {
                foreach (ListViewItem item in objectListViewPlaylist.Items)
                {
                    file.WriteLine(item.SubItems[0].Text);
                }
            }
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

        private void addF(string s2)
        {
            string s = Path.GetExtension(s2);
            if (s == ".mp3" || s == ".wav" || s == ".wma")
            {
                foreach (ListViewItem item in objectListViewSongs.Items)
                    if (s2 == item.SubItems[1].Text) return;
                try
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
                }
                catch
                {
                    return;
                }
                DatabaseDC.SubmitChanges();
                DatabaseDC = null;
                DatabaseDC = new DatabaseMusicDataContext();
                LoadMusic();
            }
            else MessageBox.Show(badFormat);
        }

        private void button2_Click(object sender, EventArgs e)                          //Add1
        {
            openFileDialog1.Filter = "Music Files(*.mp3; *.wav; *.wma)|*.mp3; *.wav; *.wma";
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
                var ext = new List<string> { ".mp3", ".wav", ".wma" };
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
            else
            {
                textBoxFile.Text = "";
                textBoxArtist.Text = "";
                textBoxTitle.Text = "";
                textBoxAlbum.Text = "";
                textBoxYear.Text = "";
                textBoxGenre.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                Refresh();
                int index = objectListViewSongs.SelectedIndices[0];
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
                            MessageBox.Show(fileIsOpenOr);
                            return;
                        }
                        if (pathh != path2) File.Move(pathh, path2);
                    }
                    else MessageBox.Show(fileWithGivenPath + ".");
                    DatabaseDC.ExecuteCommand("UPDATE Song SET [file]=N'" + textBoxFile.Text + "', artist=N'" + textBoxArtist.Text + "', title=N'" + textBoxTitle.Text + "', album=N'" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre=N'" + textBoxGenre.Text + "', path=N'" + path2 + "' WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                else
                {
                    if (File.Exists(pathh)) MessageBox.Show(fileWithGivenName);
                    else MessageBox.Show(fWGPAWGN);
                    DatabaseDC.ExecuteCommand("UPDATE Song SET artist=N'" + textBoxArtist.Text + "', title=N'" + textBoxTitle.Text + "', album=N'" + textBoxAlbum.Text + "', year='" + textBoxYear.Text + "', genre=N'" + textBoxGenre.Text + "' WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                }
                updateClear();
                objectListViewSongs.SelectObject(objectListViewSongs.GetModelObject(index));
                playlistCheck2(objectListViewSongs.Items[index]);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                if (playingNow(objectListViewSongs.SelectedItem.SubItems[1].Text)) return;
                if (MessageBox.Show(areYouSureDel, warning,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    dbDel();
                }

            }
        }

        private void buttonDel2_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count > 0)
            {
                if (playingNow(objectListViewSongs.SelectedItem.SubItems[1].Text)) return;
                if (File.Exists(objectListViewSongs.SelectedItems[0].SubItems[1].Text))
                {
                    if (MessageBox.Show(areYouSureDel1, warning,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        File.Delete(objectListViewSongs.SelectedItems[0].SubItems[1].Text);
                        if (MessageBox.Show(doYouWant, question,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            dbDel();
                        }
                    }
                }
                else MessageBox.Show(fileDontExist);
            }
        }

        private void dbDel()
        {
            DatabaseDC.ExecuteCommand("DELETE FROM Song WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
            int index = objectListViewSongs.SelectedIndices[0];
            playlistCheck3(objectListViewSongs.Items[index]);
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
            if (MessageBox.Show(wantDelItems, warning,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (object item in objectListViewSongs.FilteredObjects)
                {
                    DatabaseDC.ExecuteCommand("DELETE FROM Song WHERE id = '" + objectListViewSongs.Items[objectListViewSongs.IndexOf(item)].SubItems[0].Text + "';");
                }
                updateClear();
                playlistCheck();
            }
        }

        private void buttonEditClear_Click(object sender, EventArgs e)
        {
            textBoxFile.Text = "";
            textBoxArtist.Text = "";
            textBoxTitle.Text = "";
            textBoxAlbum.Text = "";
            textBoxYear.Text = "";
            textBoxGenre.Text = "";
            objectListViewSongs.DeselectAll();
        }

        private void buttonEditSearch_Click(object sender, EventArgs e)
        {
            TextMatchFilter filter1 = TextMatchFilter.Contains(objectListViewSongs, textBoxFile.Text);
            filter1.Columns = new[] { this.file };
            TextMatchFilter filter2 = TextMatchFilter.Contains(objectListViewSongs, textBoxArtist.Text);
            filter2.Columns = new[] { this.artist };
            TextMatchFilter filter3 = TextMatchFilter.Contains(objectListViewSongs, textBoxTitle.Text);
            filter3.Columns = new[] { this.title };
            TextMatchFilter filter4 = TextMatchFilter.Contains(objectListViewSongs, textBoxAlbum.Text);
            filter4.Columns = new[] { this.album };
            TextMatchFilter filter5 = TextMatchFilter.Contains(objectListViewSongs, textBoxYear.Text);
            filter5.Columns = new[] { this.year };
            TextMatchFilter filter6 = TextMatchFilter.Contains(objectListViewSongs, textBoxGenre.Text);
            filter6.Columns = new[] { this.genre };

            this.objectListViewSongs.ModelFilter = new CompositeAllFilter(new List<IModelFilter> { filter1, filter2, filter3, filter4, filter5, filter6 });
        }

        private void buttonSearchCancel_Click(object sender, EventArgs e)
        {
            this.objectListViewSongs.ModelFilter = null;
        }

        private void objectListViewSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            objectListViewPlaylist.AddObject(objectListViewSongs.GetModelObject(objectListViewSongs.SelectedIndices[0]));
        }

        private void buttonPlDel_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (objectListViewPlaylist.SelectedItems.Count > 0)
            {
                index = objectListViewPlaylist.SelectedIndices[0];
                objectListViewPlaylist.RemoveObject(objectListViewPlaylist.GetModelObject(objectListViewPlaylist.SelectedIndices[0]));
                RefreshPlaylistID(index);
            }
            if (objectListViewPlaylist.GetItemCount() > 0)
            {
                if (index == objectListViewPlaylist.GetItemCount()) index--;
                objectListViewPlaylist.SelectObject(objectListViewPlaylist.GetModelObject(index));
            }
        }

        private void buttonPlClear_Click(object sender, EventArgs e)
        {
            objectListViewPlaylist.Objects = null;
            RefreshPlaylistID(0);
        }

        private void buttonPlAdd_Click(object sender, EventArgs e)
        {
            foreach (object item in objectListViewSongs.FilteredObjects)
            {
                objectListViewPlaylist.AddObject(item);
            }
        }

        private void buttonPlUp_Click(object sender, EventArgs e)
        {
            if (objectListViewPlaylist.SelectedItems.Count == 0) return;
            int index = objectListViewPlaylist.SelectedIndices[0];
            if (index == 0) return;
            int index2 = index - 1;
            ListViewItem item = objectListViewPlaylist.Items[index];
            ListViewItem item2 = objectListViewPlaylist.Items[index2];
            objectListViewPlaylist.Items.Remove(item);
            objectListViewPlaylist.Items.Remove(item2);
            objectListViewPlaylist.Items.Insert(index2, item);
            objectListViewPlaylist.Items[index2].SubItems[2].Text = (index2 + 1).ToString();
            objectListViewPlaylist.Items.Insert(index, item2);
            objectListViewPlaylist.Items[index].SubItems[2].Text = (index + 1).ToString();
            if (index == list_id) list_id--;
            else if (index == list_id + 1) list_id++;
        }

        private void buttonPlDown_Click(object sender, EventArgs e)
        {

            if (objectListViewPlaylist.SelectedItems.Count == 0) return;
            int index = objectListViewPlaylist.SelectedIndices[0];
            if (index == objectListViewPlaylist.Items.Count - 1) return;
            int index2 = index + 1;
            ListViewItem item = objectListViewPlaylist.Items[index];
            ListViewItem item2 = objectListViewPlaylist.Items[index2];
            objectListViewPlaylist.Items.Remove(item);
            objectListViewPlaylist.Items.Remove(item2);
            objectListViewPlaylist.Items.Insert(index, item2);
            objectListViewPlaylist.Items[index].SubItems[2].Text = (index + 1).ToString();
            objectListViewPlaylist.Items.Insert(index2, item);
            objectListViewPlaylist.Items[index2].SubItems[2].Text = (index2 + 1).ToString();
            if (index == list_id) list_id++;
            else if (index == list_id - 1) list_id--;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count == 0) return;
            int index = objectListViewSongs.SelectedIndices[0];
            string path = objectListViewSongs.Items[index].SubItems[1].Text;
            if (playingNow(path)) return;
            if (!File.Exists(path))
            {
                MessageBox.Show(fileDontExist);
                return;
            }
            string filename = objectListViewSongs.Items[index].SubItems[2].Text;
            saveFileDialog1.FileName = Path.GetFileName(path);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path2 = saveFileDialog1.FileName;
                File.Move(path, path2);
                DatabaseDC.ExecuteCommand("UPDATE Song SET [file]=N'" + Path.GetFileNameWithoutExtension(path2) + "', path=N'" + path2 + "' WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                DatabaseDC.SubmitChanges();
                DatabaseDC = null;
                DatabaseDC = new DatabaseMusicDataContext();
                LoadMusic();
            }
            playlistCheck2(objectListViewSongs.Items[index]);
        }

        private bool playingNow(string path)
        {
            if (audioFile != null && path == audioFile.FileName)
            {
                MessageBox.Show(fileIsPlayed);
                return true;
            }
            return false;
        }

        private void playlistCheck()
        {
            int exist = 0, count = 0;
            IModelFilter tmp = this.objectListViewSongs.ModelFilter;
            this.objectListViewSongs.ModelFilter = null;
            foreach (ListViewItem item in objectListViewPlaylist.Items)
            {
                item.SubItems[2].Text = (Int32.Parse(item.SubItems[2].Text) - count).ToString();
                exist = 0;
                foreach (ListViewItem item2 in objectListViewSongs.Items)
                {
                    if (item.SubItems[0].Text == item2.SubItems[0].Text)
                    {
                        exist = 1;
                        item.SubItems[1].Text = item2.SubItems[1].Text;
                        item.SubItems[3].Text = item2.SubItems[2].Text;
                        item.SubItems[4].Text = item2.SubItems[3].Text;
                        item.SubItems[5].Text = item2.SubItems[4].Text;
                        break;
                    }
                }
                if (exist != 1)
                {
                    if (item.Index < list_id)
                    {
                        list_id--;
                    }
                    item.Remove();
                    count++;
                }
            }
            this.objectListViewSongs.ModelFilter = tmp;
        }

        private void playlistCheck2(ListViewItem item2)
        {
            foreach (ListViewItem item in objectListViewPlaylist.Items)
            {
                if (item.SubItems[0].Text != item2.SubItems[0].Text) continue;
                else
                {
                    item.SubItems[1].Text = item2.SubItems[1].Text;
                    item.SubItems[3].Text = item2.SubItems[2].Text;
                    item.SubItems[4].Text = item2.SubItems[3].Text;
                    item.SubItems[5].Text = item2.SubItems[4].Text;
                }
            }
        }

        private void playlistCheck3(ListViewItem item2)
        {
            int exist = 0, count = 0;
            foreach (ListViewItem item in objectListViewPlaylist.Items)
            {
                item.SubItems[2].Text = (Int32.Parse(item.SubItems[2].Text) - count).ToString();
                exist = 0;
                if (item.SubItems[0].Text != item2.SubItems[0].Text) continue;
                else
                {
                    count++;
                    exist = 1;
                    item.Remove();
                    continue;
                }
            }
        }

        private void buttonDbCheck_Click(object sender, EventArgs e)
        {
            bool ok = true;
            List<IModelFilter> filter = new List<IModelFilter>();
            foreach (ListViewItem item in objectListViewSongs.Items)
            {
                if (!File.Exists(item.SubItems[1].Text))
                {
                    TextMatchFilter filter1 = TextMatchFilter.Contains(objectListViewSongs, item.SubItems[0].Text);
                    filter1.Columns = new[] { this.id };
                    filter.Add(filter1);
                    ok = false;
                }
            }
            if (ok) return;
            this.objectListViewSongs.ModelFilter = new CompositeAnyFilter(filter);
            if (MessageBox.Show(showedEntryWithWrongPathes, info,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                this.objectListViewSongs.ModelFilter = null;
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            if (objectListViewSongs.SelectedItems.Count == 0) return;
            openFileDialog2.Filter = "Music Files(*.mp3; *.wav; *.wma)|*.mp3; *.wav; *.wma";
            int index = objectListViewSongs.SelectedIndices[0];
            string path = objectListViewSongs.Items[index].SubItems[1].Text;
            if (playingNow(path)) return;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string path2 = openFileDialog2.FileName;
                DatabaseDC.ExecuteCommand("UPDATE Song SET [file]=N'" + Path.GetFileNameWithoutExtension(path2) + "', path=N'" + path2 + "' WHERE id='" + objectListViewSongs.SelectedItems[0].SubItems[0].Text + "';");
                DatabaseDC.SubmitChanges();
                DatabaseDC = null;
                DatabaseDC = new DatabaseMusicDataContext();
                LoadMusic();
                playlistCheck2(objectListViewSongs.Items[index]);
            }
        }

        //Dominik
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (list_id == -1) list_id = 0;
            if (objectListViewPlaylist.GetItemCount() == 0)
            {
                if (audioFile != null)
                {
                    if (playing == true)
                    {
                        audioFile.Position = 0;
                        progressBar_Init();
                        prog.Value = 0;
                        return;
                    }
                    ResumeSong();
                }
                return;
            }
            if (playing == true)
            {
                audioFile.Position = 0;
                progressBar_Init();
                prog.Value = 0;
                return;
            }
            if (paused == true)
            {
                ResumeSong();
                return;
            }
            if (audioFile == null)
            {
                if (File.Exists(objectListViewPlaylist.Items[list_id].SubItems[1].Text))
                {
                    audioFile = new AudioFileReader(objectListViewPlaylist.Items[list_id].SubItems[1].Text);
                }
                else
                {
                    MessageBox.Show(cannotFindFile + objectListViewPlaylist.Items[list_id].SubItems[1].Text + delFromListAndTryAgain);
                    return;
                }
            }
            db_id = objectListViewPlaylist.Items[list_id].SubItems[0].Text;
            outputDevice.Init(audioFile);
            UpdatePlayerInfo(list_id);
            LoadCoverArt(audioFile.FileName);
            outputDevice.Play();
            progressBar_Init();
            playing = true;
            paused = false;
            stopped = false;
            currentLength.Text = (audioFile.TotalTime).ToString().Substring(0, 8);
            //

            //color
            objectListViewPlaylist.Items[list_id].ForeColor = Color.Red;
            objectListViewPlaylist.Refresh();
        }
        private void ResumeSong()
        {
            outputDevice.Play();
            playing = true;
            paused = false;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (stopped == false && outputDevice != null && paused == false)
            {
                outputDevice?.Pause();
                playing = false;
                paused = true;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            playing = false;
            paused = false;
            stopped = true;
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
            if (list_id == -1) list_id = 0;
            if (objectListViewPlaylist.GetItemCount() == 0)
            {
                return;
            }
            //color
            objectListViewPlaylist.Items[list_id].ForeColor = Color.Black;
            int last = objectListViewPlaylist.GetItemCount() - 1;
            if (looplist == false && list_id == last)
            {
                return;
            }
            //
            if (stopped == false)
            {
                outputDevice?.Stop();
                if (audioFile != null)
                {
                    audioFile.Dispose();
                    audioFile = null;
                }
                playing = false;
                paused = false;
            }
            //
            if (looplist == true && list_id == last)
            {
                list_id = 0;
            }
            else
            {
                list_id++;
            }
            if (File.Exists(objectListViewPlaylist.Items[list_id].SubItems[1].Text))
            {
                audioFile = new AudioFileReader(objectListViewPlaylist.Items[list_id].SubItems[1].Text);

                db_id = objectListViewPlaylist.Items[list_id].SubItems[0].Text;
                outputDevice.Init(audioFile);
                UpdatePlayerInfo(list_id);
                LoadCoverArt(audioFile.FileName);
                if (stopped == false)
                {
                    outputDevice.Play();
                    playing = true;
                    paused = false;
                }
                else
                {
                    currentTime.Text = (audioFile.CurrentTime).ToString().Substring(0, 8);
                }
                currentLength.Text = (audioFile.TotalTime).ToString().Substring(0, 8);
                //
                progressBar_Init();
                //color
                objectListViewPlaylist.Items[list_id].ForeColor = Color.Red;
                objectListViewPlaylist.Refresh();
            }
            else
            {
                MessageBox.Show(cannotFindFile + objectListViewPlaylist.Items[list_id].SubItems[1].Text + delFromListAndTryAgain);
                return;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (list_id == -1) list_id = 0;
            if (objectListViewPlaylist.GetItemCount() == 0)
            {
                return;
            }
            //color
            objectListViewPlaylist.Items[list_id].ForeColor = Color.Black;
            if (looplist == false && list_id == 0)
            {
                return;
            }
            //
            if (stopped == false)
            {
                outputDevice?.Stop();
                if (audioFile != null)
                {
                    audioFile.Dispose();
                    audioFile = null;
                }
                playing = false;
                paused = false;
            }
            //
            if (looplist == true && list_id == 0)
            {
                list_id = objectListViewPlaylist.GetItemCount() - 1;
            }
            else
            {
                list_id--;
            }
            if (File.Exists(objectListViewPlaylist.Items[list_id].SubItems[1].Text))
            {
                audioFile = new AudioFileReader(objectListViewPlaylist.Items[list_id].SubItems[1].Text);

                db_id = objectListViewPlaylist.Items[list_id].SubItems[0].Text;
                outputDevice.Init(audioFile);
                UpdatePlayerInfo(list_id);
                LoadCoverArt(audioFile.FileName);
                if (stopped == false)
                {
                    outputDevice.Play();
                    playing = true;
                    paused = false;
                }
                else
                {
                    currentTime.Text = (audioFile.CurrentTime).ToString().Substring(0, 8);
                }
                currentLength.Text = (audioFile.TotalTime).ToString().Substring(0, 8);
                //
                progressBar_Init();
                //color
                objectListViewPlaylist.Items[list_id].ForeColor = Color.Red;
                objectListViewPlaylist.Refresh();

            }
            else
            {
                MessageBox.Show(cannotFindFile + objectListViewPlaylist.Items[list_id].SubItems[1].Text + delFromListAndTryAgain);
                return;
            }

        }

        private void UpdatePlayerInfo(int id)
        {
            currentArtist.Text = objectListViewPlaylist.Items[id].SubItems[4].Text;
            if (objectListViewPlaylist.Items[id].SubItems[5].Text == "")
            {
                currentSong.Text = objectListViewPlaylist.Items[id].SubItems[3].Text;
            }
            else
            {
                currentSong.Text = objectListViewPlaylist.Items[id].SubItems[5].Text;
            }
        }

        private void LoadCoverArt(string pf) //pf = playing file 
        {
            TagLib.File file = TagLib.File.Create(pf);
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
                buttonMute.Image = Properties.Resources.mute_on;
                outputDevice.Volume = 0;
                muted = true;
            }
            else
            {
                buttonMute.Image = Properties.Resources.mute_off;
                outputDevice.Volume = volumeBar.Value / 100f; //Volume to float od 0.0 do 1.0, więc dzielimy przez 100
                muted = false;
            }
        }

        private void buttonAutoplay_Click(object sender, EventArgs e)
        {
            autoplay = !autoplay;
            loopsong = false;
            buttonLoopSong.BackColor = Color.DarkGray;

            if (autoplay == true)
            {
                buttonAutoplay.BackColor = Color.LightGray;
            }
            else
            {
                buttonAutoplay.BackColor = Color.DarkGray;
            }
        }

        private void buttonLoopList_Click(object sender, EventArgs e)
        {
            looplist = !looplist;
            loopsong = false;
            buttonLoopSong.BackColor = Color.DarkGray;

            if (looplist == true)
            {
                buttonLoopList.BackColor = Color.LightGray;
            }
            else
            {
                buttonLoopList.BackColor = Color.DarkGray;
            }
        }

        private void buttonLoopSong_Click(object sender, EventArgs e)
        {
            loopsong = !loopsong;
            autoplay = false;
            looplist = false;
            buttonAutoplay.BackColor = Color.DarkGray;
            buttonLoopList.BackColor = Color.DarkGray;

            if (loopsong == true)
            {
                buttonLoopSong.BackColor = Color.LightGray;
            }
            else
            {
                buttonLoopSong.BackColor = Color.DarkGray;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //testbar.Text = prog.Value.ToString();
            if (autoplay == true)
            {
                if (outputDevice.PlaybackState == PlaybackState.Stopped && playing == true && paused == false && stopped == false)
                {
                    //color
                    if (objectListViewPlaylist.GetItemCount() == 0)
                    {
                        return;
                    }
                    objectListViewPlaylist.Items[list_id].ForeColor = Color.Black;

                    int last = objectListViewPlaylist.GetItemCount() - 1;
                    if (looplist == false && list_id == last)
                    {
                        return;
                    }
                    //
                    if (stopped == false)
                    {
                        outputDevice?.Stop();
                        if (audioFile != null)
                        {
                            audioFile.Dispose();
                            audioFile = null;
                        }
                        playing = false;
                        paused = false;
                    }
                    //
                    if (looplist == true && list_id == last)
                    {
                        list_id = 0;
                    }
                    else
                    {
                        list_id++;
                    }
                    if (File.Exists(objectListViewPlaylist.Items[list_id].SubItems[1].Text))
                    {
                        audioFile = new AudioFileReader(objectListViewPlaylist.Items[list_id].SubItems[1].Text);

                        db_id = objectListViewPlaylist.Items[list_id].SubItems[0].Text;
                        outputDevice.Init(audioFile);
                        UpdatePlayerInfo(list_id);
                        LoadCoverArt(audioFile.FileName);
                        if (stopped == false)
                        {
                            outputDevice.Play();
                            playing = true;
                            paused = false;
                        }
                        else
                        {
                            currentTime.Text = (audioFile.CurrentTime).ToString().Substring(0, 8);
                        }
                        currentLength.Text = (audioFile.TotalTime).ToString().Substring(0, 8);
                        //
                        progressBar_Init();
                        //color
                        objectListViewPlaylist.Items[list_id].ForeColor = Color.Red;
                        objectListViewPlaylist.Refresh();
                    }
                    else
                    {
                        MessageBox.Show(cannotFindFile + objectListViewPlaylist.Items[list_id].SubItems[1].Text + delFromListAndTryAgain);
                        return;
                    }
                }
            }
            if (loopsong == true)
            {
                if (outputDevice.PlaybackState == PlaybackState.Stopped && playing == true && paused == false && stopped == false)
                {
                    if (stopped == false)
                    {
                        outputDevice?.Stop();
                        if (audioFile != null)
                        {
                            audioFile.Dispose();
                            audioFile = null;
                        }
                        playing = false;
                        paused = false;
                    }
                    //
                    if (objectListViewPlaylist.GetItemCount() == 0)
                    {
                        return;
                    }
                    if (File.Exists(objectListViewPlaylist.Items[list_id].SubItems[1].Text))
                    {
                        audioFile = new AudioFileReader(objectListViewPlaylist.Items[list_id].SubItems[1].Text);

                        db_id = objectListViewPlaylist.Items[list_id].SubItems[0].Text;
                        outputDevice.Init(audioFile);
                        UpdatePlayerInfo(list_id);
                        LoadCoverArt(audioFile.FileName);
                        objectListViewPlaylist.Items[list_id].ForeColor = Color.Red;
                        objectListViewPlaylist.Refresh();
                        if (stopped == false)
                        {
                            outputDevice.Play();
                            playing = true;
                            paused = false;
                        }
                        else
                        {
                            currentTime.Text = (audioFile.CurrentTime).ToString().Substring(0, 8);
                        }
                        currentLength.Text = (audioFile.TotalTime).ToString().Substring(0, 8);
                        //
                        progressBar_Init();
                    }
                    else
                    {
                        MessageBox.Show(cannotFindFile + objectListViewPlaylist.Items[list_id].SubItems[1].Text + delFromListAndTryAgain);
                        return;
                    }
                }
            }

            if (playing == true)
            {
                if (currentTime.Text != (audioFile.CurrentTime).ToString().Substring(0, 8))
                {
                    currentTime.Text = (audioFile.CurrentTime).ToString().Substring(0, 8);
                    if (prog.Value != prog.Maximum) prog.Value += 1;
                }
            }
        }

        private void objectListViewPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //color
            if (list_id == -1) list_id = 0;
            objectListViewPlaylist.Items[list_id].ForeColor = Color.Black;

            outputDevice?.Stop();
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            playing = false;
            paused = false;
            stopped = true;

            list_id = objectListViewPlaylist.SelectedIndices[0];
            if (File.Exists(objectListViewPlaylist.Items[list_id].SubItems[1].Text))
            {
                audioFile = new AudioFileReader(objectListViewPlaylist.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                MessageBox.Show(cannotFindFile + objectListViewPlaylist.Items[list_id].SubItems[1].Text + delFromListAndTryAgain);
                return;
            }

            db_id = objectListViewPlaylist.Items[list_id].SubItems[0].Text;
            outputDevice.Init(audioFile);
            UpdatePlayerInfo(list_id);
            LoadCoverArt(audioFile.FileName);
            outputDevice.Play();
            playing = true;
            paused = false;
            stopped = false;
            currentLength.Text = (audioFile.TotalTime).ToString().Substring(0, 8);
            //
            progressBar_Init();
            //color
            objectListViewPlaylist.Items[list_id].ForeColor = Color.Red;
            objectListViewPlaylist.Refresh();
        }

        private void RefreshPlaylistID(int index)
        {
            if (index <= list_id && list_id != 0)
            {
                list_id--;
            }
            if (objectListViewPlaylist.GetItemCount() == 0)
            {
                list_id = 0;
            }
        }

        //prog
        private void progressBar_Init()
        {
            prog.Value = 0;
            //oblicz wartosc dla maximum
            string h = (audioFile.TotalTime).ToString().Substring(0, 2);
            string m = (audioFile.TotalTime).ToString().Substring(3, 2);
            string s = (audioFile.TotalTime).ToString().Substring(6, 2);

            int result = Int16.Parse(h) * 3600 + Int16.Parse(m) * 60 + Int16.Parse(s) * 1;

            prog.Maximum = result;
        }

        //player info
        private void buttonPrevious_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonPrevious, "Previous");
        }

        private void buttonPlay_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonPlay, "Play");
        }

        private void buttonPause_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonPause, "Pause");
        }

        private void buttonStop_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonStop, "Stop");
        }

        private void buttonNext_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonNext, "Next");
        }

        private void buttonAutoplay_MouseHover(object sender, EventArgs e)
        {
            if (autoplay == false)
            {
                toolTip1.SetToolTip(buttonAutoplay, "Enable autoplay");
            }
            else
            {
                toolTip1.SetToolTip(buttonAutoplay, "Disable autoplay");
            }
        }

        private void buttonLoopList_MouseHover(object sender, EventArgs e)
        {
            if (looplist == false)
            {
                toolTip1.SetToolTip(buttonLoopList, "Enable playlist loop");
            }
            else
            {
                toolTip1.SetToolTip(buttonLoopList, "Disable playlist loop");
            }
        }

        private void buttonLoopSong_MouseHover(object sender, EventArgs e)
        {
            if (loopsong == false)
            {
                toolTip1.SetToolTip(buttonLoopSong, "Repeat track");
            }
            else
            {
                toolTip1.SetToolTip(buttonLoopSong, "Disable repeat");
            }
        }

        private void buttonMute_MouseHover(object sender, EventArgs e)
        {
            if (muted == false)
            {
                toolTip1.SetToolTip(buttonMute, "Mute audio");
            }
            else
            {
                toolTip1.SetToolTip(buttonMute, "Unmute audio");
            }
        }

        private void buttonPlUp_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonPlUp, "Move selected item upwards");
        }

        private void buttonPlDown_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonPlDown, "Move selected item downwards");
        }

        //Wojtek
        private void checkDefaultOrSolidColor(bool c0, bool c1, bool c2, bool c3, bool c4, bool c5, bool c6, bool c7, bool c8)
        {
            defaultToolStripMenuItem.Checked = c0;
            solidColorToolStripMenuItem.Checked = c1;
            whiteToolStripMenuItem.Checked = c2;
            steelToolStripMenuItem.Checked = c3;
            lightSkyBlueToolStripMenuItem.Checked = c4;
            lightSteelBlueToolStripMenuItem.Checked = c5;
            paoloVeronesesGreenToolStripMenuItem.Checked = c6;
            lightSalmonToolStripMenuItem.Checked = c7;
            mistyRoseToolStripMenuItem.Checked = c8;
        }
        public void uncheckSolidColors()
        {
            checkDefaultOrSolidColor(false, false, false, false, false, false, false, false, false);
        }

        private void checkTextures(bool c0, bool c1, bool c2, bool c3)
        {
            textureToolStripMenuItem.Checked = c0;
            freeDGreenToolStripMenuItem.Checked = c1;
            blueWebToolStripMenuItem.Checked = c2;
            leatherToolStripMenuItem.Checked = c3;
        }
        private void uncheckTextures()
        {
            BackgroundImage = null;
            checkTextures(false, false, false, false);
        }
        private void checkGradients(bool c0, bool c1, bool c2, bool c3)
        {
            gradientToolStripMenuItem.Checked = c0;
            gradient0ToolStripMenuItem.Checked = c1;
            gradient1ToolStripMenuItem.Checked = c2;
            gradient2ToolStripMenuItem.Checked = c3;
        }
        private void uncheckGradient()
        {
            logo.Visible = true;
            kontrolka1.Visible = false;
            checkGradients(false, false, false, false);
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            checkDefaultOrSolidColor(true, false, false, false, false, false, false, false, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            checkDefaultOrSolidColor(false, true, true, false, false, false, false, false, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void steelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 122, 125, 128);
            checkDefaultOrSolidColor(false, true, false, true, false, false, false, false, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void lightSkyBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightSkyBlue;
            checkDefaultOrSolidColor(false, true, false, false, true, false, false, false, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void lightSteelBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 176, 196, 222);
            checkDefaultOrSolidColor(false, true, false, false, false, true, false, false, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void paoloVeronesesGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 51, 204, 102);
            checkDefaultOrSolidColor(false, true, false, false, false, false, true, false, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void lightSalmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 160, 122);
            checkDefaultOrSolidColor(false, true, false, false, false, false, false, true, false);
            uncheckTextures();
            uncheckGradient();
        }

        private void mistyRoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 228, 225);
            checkDefaultOrSolidColor(false, true, false, false, false, false, false, false, true);
            uncheckTextures();
            uncheckGradient();
        }

        private void freeDGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources._3D_Green;
            checkTextures(true, true, false, false);
            uncheckSolidColors();
            uncheckGradient();
        }

        private void blueWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources.Blue_Web;
            checkTextures(true, false, true, false);
            uncheckSolidColors();
            uncheckGradient();
        }

        private void leatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources.Leather;
            checkTextures(true, false, false, true);
            uncheckSolidColors();
            uncheckGradient();
        }

        private void gradient0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            kontrolka1.Visible = false;
            kontrolka1.Visible = true;
            kontrolka1.Color1 = Color.White;
            kontrolka1.Color2 = Color.Red;
            logo.Visible = false;
            checkGradients(true, true, false, false);
            uncheckSolidColors();
            uncheckTextures();
        }

        private void gradient1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            kontrolka1.Visible = false;
            kontrolka1.Visible = true;
            kontrolka1.Color1 = Color.LightSkyBlue;
            kontrolka1.Color2 = Color.DarkViolet;
            logo.Visible = false;
            checkGradients(true, false, true, false);
            uncheckSolidColors();
            uncheckTextures();
        }

        private void gradient2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            kontrolka1.Visible = false;
            kontrolka1.Visible = true;
            kontrolka1.Color1 = Color.Green;
            kontrolka1.Color2 = Color.Pink;
            logo.Visible = false;
            checkGradients(true, false, false, true);
            uncheckSolidColors();
            uncheckTextures();
        }

        public void moveButtonsEtc(int x, int y)
        {
            buttonPlAdd.Location = new System.Drawing.Point(995 + x, 554 + y);
            buttonSearchCancel.Location = new System.Drawing.Point(1148 + x, 554 + y);
            buttonDbCheck.Location = new System.Drawing.Point(1148 + x, 581 + y);
            logo.Location = new System.Drawing.Point(1126 + x, 606 + y);
            objectListViewSongs.Size = new System.Drawing.Size(974 + x, 506);
            logo.Visible = true;
        }

        public void moveButtonsEtc(int x, int y, int z, int z1)
        {
            int a = x - 135;
            buttonPlAdd.Location = new System.Drawing.Point(995 + x - 24, 554 + y);
            buttonSearchCancel.Location = new System.Drawing.Point(1148 + z + 20, 554 + z1);
            buttonDbCheck.Location = new System.Drawing.Point(1148 + z + 20, 581 + z1);
            objectListViewSongs.Size = new System.Drawing.Size(974 + a, 506);
            logo.Visible = false;
        }

        private void resolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        public void resizeColumns(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
        {
            id.Width = x0;
            path.Width = x1;
            file.Width = x2;
            artist.Width = x3;
            title.Width = x4;
            album.Width = x5;
            year.Width = x6;
            genre.Width = x7;
        }
    }
}