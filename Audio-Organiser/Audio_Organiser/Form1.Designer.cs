﻿namespace Audio_Organiser
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.vScrollBard = new System.Windows.Forms.VScrollBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentLength = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.currentArtist = new System.Windows.Forms.Label();
            this.currentSong = new System.Windows.Forms.Label();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonAutoplay = new System.Windows.Forms.Button();
            this.buttonLoopList = new System.Windows.Forms.Button();
            this.buttonLoopSong = new System.Windows.Forms.Button();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBard
            // 
            this.vScrollBard.Location = new System.Drawing.Point(1151, 23);
            this.vScrollBard.Name = "vScrollBard";
            this.vScrollBard.Size = new System.Drawing.Size(16, 753);
            this.vScrollBard.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1167, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addToolStripMenu
            // 
            this.addToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.addToolStripMenu.Name = "addToolStripMenu";
            this.addToolStripMenu.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenu.Text = "Add";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xdToolStripMenuItem});
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.songToolStripMenuItem.Text = "Song";
            this.songToolStripMenuItem.Click += new System.EventHandler(this.songToolStripMenuItem_Click);
            // 
            // xdToolStripMenuItem
            // 
            this.xdToolStripMenuItem.Name = "xdToolStripMenuItem";
            this.xdToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.xdToolStripMenuItem.Text = "xd";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Edytuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.LargeChange = 10;
            this.volumeBar.Location = new System.Drawing.Point(105, 56);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(104, 45);
            this.volumeBar.SmallChange = 10;
            this.volumeBar.TabIndex = 21;
            this.volumeBar.Value = 100;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // listViewSongs
            // 
            this.listViewSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.path,
            this.file,
            this.artist,
            this.title,
            this.album,
            this.year,
            this.genre});
            this.listViewSongs.FullRowSelect = true;
            this.listViewSongs.GridLines = true;
            this.listViewSongs.HideSelection = false;
            this.listViewSongs.Location = new System.Drawing.Point(278, 39);
            this.listViewSongs.MultiSelect = false;
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(870, 179);
            this.listViewSongs.TabIndex = 22;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            this.listViewSongs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewSongs_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 0;
            // 
            // path
            // 
            this.path.Text = "Scieżka";
            this.path.Width = 0;
            // 
            // file
            // 
            this.file.Text = "Nazwa pliku";
            this.file.Width = 340;
            // 
            // artist
            // 
            this.artist.Text = "Wykonawca albumu";
            this.artist.Width = 138;
            // 
            // title
            // 
            this.title.Text = "Tytuł";
            this.title.Width = 105;
            // 
            // album
            // 
            this.album.Text = "Album";
            this.album.Width = 100;
            // 
            // year
            // 
            this.year.Text = "Rok";
            this.year.Width = 50;
            // 
            // genre
            // 
            this.genre.Text = "Gatunek";
            this.genre.Width = 129;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(149, 33);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(230, 20);
            this.textBoxArtist.TabIndex = 12;
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(149, 93);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(230, 20);
            this.textBoxAlbum.TabIndex = 17;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(3, 150);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 13);
            this.labelGenre.TabIndex = 16;
            this.labelGenre.Text = "Gatunek";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(3, 120);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(27, 13);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "Rok";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(3, 90);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(36, 13);
            this.labelAlbum.TabIndex = 14;
            this.labelAlbum.Text = "Album";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(149, 3);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(230, 20);
            this.textBoxFile.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(149, 63);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(230, 20);
            this.textBoxTitle.TabIndex = 13;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(3, 30);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(104, 13);
            this.labelArtist.TabIndex = 9;
            this.labelArtist.Text = "Wykonawca albumu";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 13);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Tytuł";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(3, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(65, 13);
            this.labelFile.TabIndex = 8;
            this.labelFile.Text = "Nazwa pliku";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.3812F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.6188F));
            this.tableLayoutPanel1.Controls.Add(this.labelFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelArtist, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAlbum, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelYear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelGenre, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlbum, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArtist, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGenre, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxYear, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(346, 406);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 182);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(149, 153);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(230, 20);
            this.textBoxGenre.TabIndex = 19;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(149, 123);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(230, 20);
            this.textBoxYear.TabIndex = 20;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(680, 264);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "Usuń";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(102, 37);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(49, 13);
            this.currentTime.TabIndex = 25;
            this.currentTime.Text = "00:00:00";
            // 
            // currentLength
            // 
            this.currentLength.AutoSize = true;
            this.currentLength.Location = new System.Drawing.Point(147, 37);
            this.currentLength.Name = "currentLength";
            this.currentLength.Size = new System.Drawing.Size(57, 13);
            this.currentLength.TabIndex = 26;
            this.currentLength.Text = "/ 00:00:00";
            this.currentLength.Click += new System.EventHandler(this.currentLength_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // currentArtist
            // 
            this.currentArtist.AutoEllipsis = true;
            this.currentArtist.Location = new System.Drawing.Point(102, 6);
            this.currentArtist.Name = "currentArtist";
            this.currentArtist.Size = new System.Drawing.Size(150, 13);
            this.currentArtist.TabIndex = 27;
            // 
            // currentSong
            // 
            this.currentSong.AutoEllipsis = true;
            this.currentSong.Location = new System.Drawing.Point(102, 20);
            this.currentSong.Name = "currentSong";
            this.currentSong.Size = new System.Drawing.Size(150, 13);
            this.currentSong.TabIndex = 28;
            // 
            // buttonMute
            // 
            this.buttonMute.FlatAppearance.BorderSize = 0;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.Image = global::Audio_Organiser.Properties.Resources.previous;
            this.buttonMute.Location = new System.Drawing.Point(216, 56);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(26, 26);
            this.buttonMute.TabIndex = 29;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonAutoplay
            // 
            this.buttonAutoplay.FlatAppearance.BorderSize = 0;
            this.buttonAutoplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoplay.Image = global::Audio_Organiser.Properties.Resources.previous;
            this.buttonAutoplay.Location = new System.Drawing.Point(169, 106);
            this.buttonAutoplay.Name = "buttonAutoplay";
            this.buttonAutoplay.Size = new System.Drawing.Size(26, 26);
            this.buttonAutoplay.TabIndex = 30;
            this.buttonAutoplay.UseVisualStyleBackColor = true;
            this.buttonAutoplay.Click += new System.EventHandler(this.buttonAutoplay_Click);
            // 
            // buttonLoopList
            // 
            this.buttonLoopList.FlatAppearance.BorderSize = 0;
            this.buttonLoopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoopList.Image = global::Audio_Organiser.Properties.Resources.previous;
            this.buttonLoopList.Location = new System.Drawing.Point(197, 106);
            this.buttonLoopList.Name = "buttonLoopList";
            this.buttonLoopList.Size = new System.Drawing.Size(26, 26);
            this.buttonLoopList.TabIndex = 31;
            this.buttonLoopList.UseVisualStyleBackColor = true;
            this.buttonLoopList.Click += new System.EventHandler(this.buttonLoopList_Click);
            // 
            // buttonLoopSong
            // 
            this.buttonLoopSong.FlatAppearance.BorderSize = 0;
            this.buttonLoopSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoopSong.Image = global::Audio_Organiser.Properties.Resources.previous;
            this.buttonLoopSong.Location = new System.Drawing.Point(225, 106);
            this.buttonLoopSong.Name = "buttonLoopSong";
            this.buttonLoopSong.Size = new System.Drawing.Size(26, 26);
            this.buttonLoopSong.TabIndex = 32;
            this.buttonLoopSong.UseVisualStyleBackColor = true;
            this.buttonLoopSong.Click += new System.EventHandler(this.buttonLoopSong_Click);
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(-1, 0);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(100, 100);
            this.coverPictureBox.TabIndex = 24;
            this.coverPictureBox.TabStop = false;
            // 
            // buttonStop
            // 
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Image = global::Audio_Organiser.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(85, 106);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(26, 26);
            this.buttonStop.TabIndex = 20;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Image = global::Audio_Organiser.Properties.Resources.previous;
            this.buttonPrevious.Location = new System.Drawing.Point(1, 106);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(26, 26);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::Audio_Organiser.Properties.Resources.next;
            this.buttonNext.Location = new System.Drawing.Point(113, 106);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(26, 26);
            this.buttonNext.TabIndex = 18;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Image = global::Audio_Organiser.Properties.Resources.pause;
            this.buttonPause.Location = new System.Drawing.Point(57, 106);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(26, 26);
            this.buttonPause.TabIndex = 17;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(29, 106);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(26, 26);
            this.buttonPlay.TabIndex = 16;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, 649);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(138, 127);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLoopList);
            this.panel1.Controls.Add(this.currentSong);
            this.panel1.Controls.Add(this.buttonLoopSong);
            this.panel1.Controls.Add(this.currentArtist);
            this.panel1.Controls.Add(this.buttonAutoplay);
            this.panel1.Controls.Add(this.buttonMute);
            this.panel1.Controls.Add(this.currentLength);
            this.panel1.Controls.Add(this.currentTime);
            this.panel1.Controls.Add(this.coverPictureBox);
            this.panel1.Controls.Add(this.volumeBar);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPause);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Location = new System.Drawing.Point(11, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 179);
            this.panel1.TabIndex = 33;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1167, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.vScrollBard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Audio Organiser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBard;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem xdToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.ColumnHeader artist;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label currentLength;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label currentArtist;
        private System.Windows.Forms.Label currentSong;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonAutoplay;
        private System.Windows.Forms.Button buttonLoopList;
        private System.Windows.Forms.Button buttonLoopSong;
        private System.Windows.Forms.Panel panel1;
    }
}

