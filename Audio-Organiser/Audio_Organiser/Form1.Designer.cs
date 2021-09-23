﻿
namespace Audio_Organiser
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDel = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightSkyBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightSteelBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paoloVeronesesGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightSalmonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mistyRoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeDGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradient0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradient1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradient2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolka1 = new Audio_Organiser.GradientController();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentLength = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.currentArtist = new System.Windows.Forms.Label();
            this.currentSong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prog = new System.Windows.Forms.TrackBar();
            this.buttonLoopList = new System.Windows.Forms.Button();
            this.buttonLoopSong = new System.Windows.Forms.Button();
            this.buttonAutoplay = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.objectListViewSongs = new BrightIdeasSoftware.ObjectListView();
            this.id = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.path = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.file = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.artist = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.title = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.album = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.year = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.genre = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonPlClear = new System.Windows.Forms.Button();
            this.buttonPlDel = new System.Windows.Forms.Button();
            this.objectListViewPlaylist = new BrightIdeasSoftware.ObjectListView();
            this.Id_p = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Path_p = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Id_auto = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.File_p = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Artist_p = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Title_p = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonSearchCancel = new System.Windows.Forms.Button();
            this.buttonEditSearch = new System.Windows.Forms.Button();
            this.buttonEditClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonPlAdd = new System.Windows.Forms.Button();
            this.buttonPlUp = new System.Windows.Forms.Button();
            this.buttonPlDown = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonDbCheck = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.testButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewPlaylist)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usunToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.resolutionToolStripMenuItem,
            this.testButtonToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.toolTip1.SetToolTip(this.menuStrip, resources.GetString("menuStrip.ToolTip"));
            // 
            // dodajToolStripMenuItem
            // 
            resources.ApplyResources(this.dodajToolStripMenuItem, "dodajToolStripMenuItem");
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button2,
            this.buttonAdd2});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd2
            // 
            resources.ApplyResources(this.buttonAdd2, "buttonAdd2");
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // usunToolStripMenuItem
            // 
            resources.ApplyResources(this.usunToolStripMenuItem, "usunToolStripMenuItem");
            this.usunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonDel,
            this.buttonDel2,
            this.buttonClear});
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            // 
            // buttonDel
            // 
            resources.ApplyResources(this.buttonDel, "buttonDel");
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonDel2
            // 
            resources.ApplyResources(this.buttonDel2, "buttonDel2");
            this.buttonDel2.Name = "buttonDel2";
            this.buttonDel2.Click += new System.EventHandler(this.buttonDel2_Click);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // themesToolStripMenuItem
            // 
            resources.ApplyResources(this.themesToolStripMenuItem, "themesToolStripMenuItem");
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.solidColorToolStripMenuItem,
            this.textureToolStripMenuItem,
            this.gradientToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            // 
            // defaultToolStripMenuItem
            // 
            resources.ApplyResources(this.defaultToolStripMenuItem, "defaultToolStripMenuItem");
            this.defaultToolStripMenuItem.Checked = true;
            this.defaultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // solidColorToolStripMenuItem
            // 
            resources.ApplyResources(this.solidColorToolStripMenuItem, "solidColorToolStripMenuItem");
            this.solidColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.steelToolStripMenuItem,
            this.lightSkyBlueToolStripMenuItem,
            this.lightSteelBlueToolStripMenuItem,
            this.paoloVeronesesGreenToolStripMenuItem,
            this.lightSalmonToolStripMenuItem,
            this.mistyRoseToolStripMenuItem});
            this.solidColorToolStripMenuItem.Name = "solidColorToolStripMenuItem";
            // 
            // whiteToolStripMenuItem
            // 
            resources.ApplyResources(this.whiteToolStripMenuItem, "whiteToolStripMenuItem");
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // steelToolStripMenuItem
            // 
            resources.ApplyResources(this.steelToolStripMenuItem, "steelToolStripMenuItem");
            this.steelToolStripMenuItem.Name = "steelToolStripMenuItem";
            this.steelToolStripMenuItem.Click += new System.EventHandler(this.steelToolStripMenuItem_Click);
            // 
            // lightSkyBlueToolStripMenuItem
            // 
            resources.ApplyResources(this.lightSkyBlueToolStripMenuItem, "lightSkyBlueToolStripMenuItem");
            this.lightSkyBlueToolStripMenuItem.Name = "lightSkyBlueToolStripMenuItem";
            this.lightSkyBlueToolStripMenuItem.Click += new System.EventHandler(this.lightSkyBlueToolStripMenuItem_Click);
            // 
            // lightSteelBlueToolStripMenuItem
            // 
            resources.ApplyResources(this.lightSteelBlueToolStripMenuItem, "lightSteelBlueToolStripMenuItem");
            this.lightSteelBlueToolStripMenuItem.Name = "lightSteelBlueToolStripMenuItem";
            this.lightSteelBlueToolStripMenuItem.Click += new System.EventHandler(this.lightSteelBlueToolStripMenuItem_Click);
            // 
            // paoloVeronesesGreenToolStripMenuItem
            // 
            resources.ApplyResources(this.paoloVeronesesGreenToolStripMenuItem, "paoloVeronesesGreenToolStripMenuItem");
            this.paoloVeronesesGreenToolStripMenuItem.Name = "paoloVeronesesGreenToolStripMenuItem";
            this.paoloVeronesesGreenToolStripMenuItem.Click += new System.EventHandler(this.paoloVeronesesGreenToolStripMenuItem_Click);
            // 
            // lightSalmonToolStripMenuItem
            // 
            resources.ApplyResources(this.lightSalmonToolStripMenuItem, "lightSalmonToolStripMenuItem");
            this.lightSalmonToolStripMenuItem.Name = "lightSalmonToolStripMenuItem";
            this.lightSalmonToolStripMenuItem.Click += new System.EventHandler(this.lightSalmonToolStripMenuItem_Click);
            // 
            // mistyRoseToolStripMenuItem
            // 
            resources.ApplyResources(this.mistyRoseToolStripMenuItem, "mistyRoseToolStripMenuItem");
            this.mistyRoseToolStripMenuItem.Name = "mistyRoseToolStripMenuItem";
            this.mistyRoseToolStripMenuItem.Click += new System.EventHandler(this.mistyRoseToolStripMenuItem_Click);
            // 
            // textureToolStripMenuItem
            // 
            resources.ApplyResources(this.textureToolStripMenuItem, "textureToolStripMenuItem");
            this.textureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeDGreenToolStripMenuItem,
            this.blueWebToolStripMenuItem,
            this.leatherToolStripMenuItem});
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            // 
            // freeDGreenToolStripMenuItem
            // 
            resources.ApplyResources(this.freeDGreenToolStripMenuItem, "freeDGreenToolStripMenuItem");
            this.freeDGreenToolStripMenuItem.Name = "freeDGreenToolStripMenuItem";
            this.freeDGreenToolStripMenuItem.Click += new System.EventHandler(this.freeDGreenToolStripMenuItem_Click);
            // 
            // blueWebToolStripMenuItem
            // 
            resources.ApplyResources(this.blueWebToolStripMenuItem, "blueWebToolStripMenuItem");
            this.blueWebToolStripMenuItem.Name = "blueWebToolStripMenuItem";
            this.blueWebToolStripMenuItem.Click += new System.EventHandler(this.blueWebToolStripMenuItem_Click);
            // 
            // leatherToolStripMenuItem
            // 
            resources.ApplyResources(this.leatherToolStripMenuItem, "leatherToolStripMenuItem");
            this.leatherToolStripMenuItem.Name = "leatherToolStripMenuItem";
            this.leatherToolStripMenuItem.Click += new System.EventHandler(this.leatherToolStripMenuItem_Click);
            // 
            // gradientToolStripMenuItem
            // 
            resources.ApplyResources(this.gradientToolStripMenuItem, "gradientToolStripMenuItem");
            this.gradientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradient0ToolStripMenuItem,
            this.gradient1ToolStripMenuItem,
            this.gradient2ToolStripMenuItem});
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            // 
            // gradient0ToolStripMenuItem
            // 
            resources.ApplyResources(this.gradient0ToolStripMenuItem, "gradient0ToolStripMenuItem");
            this.gradient0ToolStripMenuItem.Name = "gradient0ToolStripMenuItem";
            this.gradient0ToolStripMenuItem.Click += new System.EventHandler(this.gradient0ToolStripMenuItem_Click);
            // 
            // gradient1ToolStripMenuItem
            // 
            resources.ApplyResources(this.gradient1ToolStripMenuItem, "gradient1ToolStripMenuItem");
            this.gradient1ToolStripMenuItem.Name = "gradient1ToolStripMenuItem";
            this.gradient1ToolStripMenuItem.Click += new System.EventHandler(this.gradient1ToolStripMenuItem_Click);
            // 
            // gradient2ToolStripMenuItem
            // 
            resources.ApplyResources(this.gradient2ToolStripMenuItem, "gradient2ToolStripMenuItem");
            this.gradient2ToolStripMenuItem.Name = "gradient2ToolStripMenuItem";
            this.gradient2ToolStripMenuItem.Click += new System.EventHandler(this.gradient2ToolStripMenuItem_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            resources.ApplyResources(this.resolutionToolStripMenuItem, "resolutionToolStripMenuItem");
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // kontrolka1
            // 
            resources.ApplyResources(this.kontrolka1, "kontrolka1");
            this.kontrolka1.Color1 = System.Drawing.Color.Empty;
            this.kontrolka1.Color2 = System.Drawing.Color.Empty;
            this.kontrolka1.GradientRadius = 0;
            this.kontrolka1.Name = "kontrolka1";
            this.toolTip1.SetToolTip(this.kontrolka1, resources.GetString("kontrolka1.ToolTip"));
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // volumeBar
            // 
            resources.ApplyResources(this.volumeBar, "volumeBar");
            this.volumeBar.LargeChange = 10;
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.SmallChange = 10;
            this.toolTip1.SetToolTip(this.volumeBar, resources.GetString("volumeBar.ToolTip"));
            this.volumeBar.Value = 100;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // currentTime
            // 
            resources.ApplyResources(this.currentTime, "currentTime");
            this.currentTime.Name = "currentTime";
            this.toolTip1.SetToolTip(this.currentTime, resources.GetString("currentTime.ToolTip"));
            // 
            // currentLength
            // 
            resources.ApplyResources(this.currentLength, "currentLength");
            this.currentLength.Name = "currentLength";
            this.toolTip1.SetToolTip(this.currentLength, resources.GetString("currentLength.ToolTip"));
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // currentArtist
            // 
            resources.ApplyResources(this.currentArtist, "currentArtist");
            this.currentArtist.AutoEllipsis = true;
            this.currentArtist.Name = "currentArtist";
            this.toolTip1.SetToolTip(this.currentArtist, resources.GetString("currentArtist.ToolTip"));
            // 
            // currentSong
            // 
            resources.ApplyResources(this.currentSong, "currentSong");
            this.currentSong.AutoEllipsis = true;
            this.currentSong.Name = "currentSong";
            this.toolTip1.SetToolTip(this.currentSong, resources.GetString("currentSong.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.prog);
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
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // prog
            // 
            resources.ApplyResources(this.prog, "prog");
            this.prog.BackColor = System.Drawing.Color.DarkGray;
            this.prog.Name = "prog";
            this.prog.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.prog, resources.GetString("prog.ToolTip"));
            // 
            // buttonLoopList
            // 
            resources.ApplyResources(this.buttonLoopList, "buttonLoopList");
            this.buttonLoopList.FlatAppearance.BorderSize = 0;
            this.buttonLoopList.Image = global::Audio_Organiser.Properties.Resources.loop_pl;
            this.buttonLoopList.Name = "buttonLoopList";
            this.toolTip1.SetToolTip(this.buttonLoopList, resources.GetString("buttonLoopList.ToolTip"));
            this.buttonLoopList.UseVisualStyleBackColor = true;
            this.buttonLoopList.Click += new System.EventHandler(this.buttonLoopList_Click);
            this.buttonLoopList.MouseHover += new System.EventHandler(this.buttonLoopList_MouseHover);
            // 
            // buttonLoopSong
            // 
            resources.ApplyResources(this.buttonLoopSong, "buttonLoopSong");
            this.buttonLoopSong.FlatAppearance.BorderSize = 0;
            this.buttonLoopSong.Image = global::Audio_Organiser.Properties.Resources.loop_s;
            this.buttonLoopSong.Name = "buttonLoopSong";
            this.toolTip1.SetToolTip(this.buttonLoopSong, resources.GetString("buttonLoopSong.ToolTip"));
            this.buttonLoopSong.UseVisualStyleBackColor = true;
            this.buttonLoopSong.Click += new System.EventHandler(this.buttonLoopSong_Click);
            this.buttonLoopSong.MouseHover += new System.EventHandler(this.buttonLoopSong_MouseHover);
            // 
            // buttonAutoplay
            // 
            resources.ApplyResources(this.buttonAutoplay, "buttonAutoplay");
            this.buttonAutoplay.FlatAppearance.BorderSize = 0;
            this.buttonAutoplay.Image = global::Audio_Organiser.Properties.Resources.auto;
            this.buttonAutoplay.Name = "buttonAutoplay";
            this.toolTip1.SetToolTip(this.buttonAutoplay, resources.GetString("buttonAutoplay.ToolTip"));
            this.buttonAutoplay.UseVisualStyleBackColor = true;
            this.buttonAutoplay.Click += new System.EventHandler(this.buttonAutoplay_Click);
            this.buttonAutoplay.MouseHover += new System.EventHandler(this.buttonAutoplay_MouseHover);
            // 
            // buttonMute
            // 
            resources.ApplyResources(this.buttonMute, "buttonMute");
            this.buttonMute.FlatAppearance.BorderSize = 0;
            this.buttonMute.Image = global::Audio_Organiser.Properties.Resources.mute_off;
            this.buttonMute.Name = "buttonMute";
            this.toolTip1.SetToolTip(this.buttonMute, resources.GetString("buttonMute.ToolTip"));
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            this.buttonMute.MouseHover += new System.EventHandler(this.buttonMute_MouseHover);
            // 
            // coverPictureBox
            // 
            resources.ApplyResources(this.coverPictureBox, "coverPictureBox");
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.coverPictureBox, resources.GetString("coverPictureBox.ToolTip"));
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.Image = global::Audio_Organiser.Properties.Resources.stop;
            this.buttonStop.Name = "buttonStop";
            this.toolTip1.SetToolTip(this.buttonStop, resources.GetString("buttonStop.ToolTip"));
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            this.buttonStop.MouseHover += new System.EventHandler(this.buttonStop_MouseHover);
            // 
            // buttonPrevious
            // 
            resources.ApplyResources(this.buttonPrevious, "buttonPrevious");
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.Image = global::Audio_Organiser.Properties.Resources.previous;
            this.buttonPrevious.Name = "buttonPrevious";
            this.toolTip1.SetToolTip(this.buttonPrevious, resources.GetString("buttonPrevious.ToolTip"));
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            this.buttonPrevious.MouseHover += new System.EventHandler(this.buttonPrevious_MouseHover);
            // 
            // buttonNext
            // 
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.Image = global::Audio_Organiser.Properties.Resources.next;
            this.buttonNext.Name = "buttonNext";
            this.toolTip1.SetToolTip(this.buttonNext, resources.GetString("buttonNext.ToolTip"));
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseHover += new System.EventHandler(this.buttonNext_MouseHover);
            // 
            // buttonPause
            // 
            resources.ApplyResources(this.buttonPause, "buttonPause");
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.Image = global::Audio_Organiser.Properties.Resources.pause;
            this.buttonPause.Name = "buttonPause";
            this.toolTip1.SetToolTip(this.buttonPause, resources.GetString("buttonPause.ToolTip"));
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            this.buttonPause.MouseHover += new System.EventHandler(this.buttonPause_MouseHover);
            // 
            // buttonPlay
            // 
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.Name = "buttonPlay";
            this.toolTip1.SetToolTip(this.buttonPlay, resources.GetString("buttonPlay.ToolTip"));
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseHover += new System.EventHandler(this.buttonPlay_MouseHover);
            // 
            // objectListViewSongs
            // 
            resources.ApplyResources(this.objectListViewSongs, "objectListViewSongs");
            this.objectListViewSongs.AllColumns.Add(this.id);
            this.objectListViewSongs.AllColumns.Add(this.path);
            this.objectListViewSongs.AllColumns.Add(this.file);
            this.objectListViewSongs.AllColumns.Add(this.artist);
            this.objectListViewSongs.AllColumns.Add(this.title);
            this.objectListViewSongs.AllColumns.Add(this.album);
            this.objectListViewSongs.AllColumns.Add(this.year);
            this.objectListViewSongs.AllColumns.Add(this.genre);
            this.objectListViewSongs.CellEditUseWholeCell = false;
            this.objectListViewSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.path,
            this.file,
            this.artist,
            this.title,
            this.album,
            this.year,
            this.genre});
            this.objectListViewSongs.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewSongs.FullRowSelect = true;
            this.objectListViewSongs.HideSelection = false;
            this.objectListViewSongs.MultiSelect = false;
            this.objectListViewSongs.Name = "objectListViewSongs";
            this.objectListViewSongs.OverlayText.Text = resources.GetString("resource.Text");
            this.objectListViewSongs.SelectAllOnControlA = false;
            this.objectListViewSongs.ShowGroups = false;
            this.toolTip1.SetToolTip(this.objectListViewSongs, resources.GetString("objectListViewSongs.ToolTip"));
            this.objectListViewSongs.UseCompatibleStateImageBehavior = false;
            this.objectListViewSongs.UseFiltering = true;
            this.objectListViewSongs.UseHotControls = false;
            this.objectListViewSongs.View = System.Windows.Forms.View.Details;
            this.objectListViewSongs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.objectListViewSongs_ItemSelectionChanged);
            this.objectListViewSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListViewSongs_MouseDoubleClick);
            // 
            // id
            // 
            this.id.AspectName = "id";
            resources.ApplyResources(this.id, "id");
            // 
            // path
            // 
            this.path.AspectName = "path";
            resources.ApplyResources(this.path, "path");
            // 
            // file
            // 
            this.file.AspectName = "file";
            resources.ApplyResources(this.file, "file");
            // 
            // artist
            // 
            this.artist.AspectName = "artist";
            resources.ApplyResources(this.artist, "artist");
            // 
            // title
            // 
            this.title.AspectName = "title";
            resources.ApplyResources(this.title, "title");
            // 
            // album
            // 
            this.album.AspectName = "album";
            resources.ApplyResources(this.album, "album");
            // 
            // year
            // 
            this.year.AspectName = "year";
            resources.ApplyResources(this.year, "year");
            // 
            // genre
            // 
            this.genre.AspectName = "genre";
            resources.ApplyResources(this.genre, "genre");
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // buttonPlClear
            // 
            resources.ApplyResources(this.buttonPlClear, "buttonPlClear");
            this.buttonPlClear.Name = "buttonPlClear";
            this.toolTip1.SetToolTip(this.buttonPlClear, resources.GetString("buttonPlClear.ToolTip"));
            this.buttonPlClear.UseVisualStyleBackColor = true;
            this.buttonPlClear.Click += new System.EventHandler(this.buttonPlClear_Click);
            // 
            // buttonPlDel
            // 
            resources.ApplyResources(this.buttonPlDel, "buttonPlDel");
            this.buttonPlDel.Name = "buttonPlDel";
            this.toolTip1.SetToolTip(this.buttonPlDel, resources.GetString("buttonPlDel.ToolTip"));
            this.buttonPlDel.UseVisualStyleBackColor = true;
            this.buttonPlDel.Click += new System.EventHandler(this.buttonPlDel_Click);
            // 
            // objectListViewPlaylist
            // 
            resources.ApplyResources(this.objectListViewPlaylist, "objectListViewPlaylist");
            this.objectListViewPlaylist.AllColumns.Add(this.Id_p);
            this.objectListViewPlaylist.AllColumns.Add(this.Path_p);
            this.objectListViewPlaylist.AllColumns.Add(this.Id_auto);
            this.objectListViewPlaylist.AllColumns.Add(this.File_p);
            this.objectListViewPlaylist.AllColumns.Add(this.Artist_p);
            this.objectListViewPlaylist.AllColumns.Add(this.Title_p);
            this.objectListViewPlaylist.CellEditUseWholeCell = false;
            this.objectListViewPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_p,
            this.Path_p,
            this.Id_auto,
            this.File_p,
            this.Artist_p,
            this.Title_p});
            this.objectListViewPlaylist.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewPlaylist.FullRowSelect = true;
            this.objectListViewPlaylist.HideSelection = false;
            this.objectListViewPlaylist.Name = "objectListViewPlaylist";
            this.objectListViewPlaylist.OverlayText.Text = resources.GetString("resource.Text1");
            this.objectListViewPlaylist.ShowGroups = false;
            this.toolTip1.SetToolTip(this.objectListViewPlaylist, resources.GetString("objectListViewPlaylist.ToolTip"));
            this.objectListViewPlaylist.UseCompatibleStateImageBehavior = false;
            this.objectListViewPlaylist.UseHotControls = false;
            this.objectListViewPlaylist.View = System.Windows.Forms.View.Details;
            this.objectListViewPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListViewPlaylist_MouseDoubleClick);
            // 
            // Id_p
            // 
            this.Id_p.AspectName = "id";
            resources.ApplyResources(this.Id_p, "Id_p");
            this.Id_p.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Id_p.Searchable = false;
            this.Id_p.Sortable = false;
            this.Id_p.UseFiltering = false;
            // 
            // Path_p
            // 
            this.Path_p.AspectName = "path";
            resources.ApplyResources(this.Path_p, "Path_p");
            this.Path_p.Searchable = false;
            this.Path_p.Sortable = false;
            this.Path_p.UseFiltering = false;
            // 
            // Id_auto
            // 
            this.Id_auto.AspectName = "id_auto";
            resources.ApplyResources(this.Id_auto, "Id_auto");
            this.Id_auto.IsTileViewColumn = true;
            this.Id_auto.Searchable = false;
            this.Id_auto.Sortable = false;
            this.Id_auto.UseFiltering = false;
            // 
            // File_p
            // 
            this.File_p.AspectName = "file";
            resources.ApplyResources(this.File_p, "File_p");
            this.File_p.Searchable = false;
            this.File_p.Sortable = false;
            this.File_p.UseFiltering = false;
            // 
            // Artist_p
            // 
            this.Artist_p.AspectName = "artist";
            resources.ApplyResources(this.Artist_p, "Artist_p");
            this.Artist_p.Searchable = false;
            this.Artist_p.Sortable = false;
            this.Artist_p.UseFiltering = false;
            // 
            // Title_p
            // 
            this.Title_p.AspectName = "title";
            resources.ApplyResources(this.Title_p, "Title_p");
            this.Title_p.Searchable = false;
            this.Title_p.Sortable = false;
            this.Title_p.UseFiltering = false;
            // 
            // buttonSearchCancel
            // 
            resources.ApplyResources(this.buttonSearchCancel, "buttonSearchCancel");
            this.buttonSearchCancel.Name = "buttonSearchCancel";
            this.toolTip1.SetToolTip(this.buttonSearchCancel, resources.GetString("buttonSearchCancel.ToolTip"));
            this.buttonSearchCancel.UseVisualStyleBackColor = true;
            this.buttonSearchCancel.Click += new System.EventHandler(this.buttonSearchCancel_Click);
            // 
            // buttonEditSearch
            // 
            resources.ApplyResources(this.buttonEditSearch, "buttonEditSearch");
            this.buttonEditSearch.Name = "buttonEditSearch";
            this.toolTip1.SetToolTip(this.buttonEditSearch, resources.GetString("buttonEditSearch.ToolTip"));
            this.buttonEditSearch.UseVisualStyleBackColor = true;
            this.buttonEditSearch.Click += new System.EventHandler(this.buttonEditSearch_Click);
            // 
            // buttonEditClear
            // 
            resources.ApplyResources(this.buttonEditClear, "buttonEditClear");
            this.buttonEditClear.Name = "buttonEditClear";
            this.toolTip1.SetToolTip(this.buttonEditClear, resources.GetString("buttonEditClear.ToolTip"));
            this.buttonEditClear.UseVisualStyleBackColor = true;
            this.buttonEditClear.Click += new System.EventHandler(this.buttonEditClear_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // labelFile
            // 
            resources.ApplyResources(this.labelFile, "labelFile");
            this.labelFile.Name = "labelFile";
            this.toolTip1.SetToolTip(this.labelFile, resources.GetString("labelFile.ToolTip"));
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            this.toolTip1.SetToolTip(this.labelTitle, resources.GetString("labelTitle.ToolTip"));
            // 
            // labelArtist
            // 
            resources.ApplyResources(this.labelArtist, "labelArtist");
            this.labelArtist.Name = "labelArtist";
            this.toolTip1.SetToolTip(this.labelArtist, resources.GetString("labelArtist.ToolTip"));
            // 
            // textBoxTitle
            // 
            resources.ApplyResources(this.textBoxTitle, "textBoxTitle");
            this.textBoxTitle.Name = "textBoxTitle";
            this.toolTip1.SetToolTip(this.textBoxTitle, resources.GetString("textBoxTitle.ToolTip"));
            // 
            // textBoxFile
            // 
            resources.ApplyResources(this.textBoxFile, "textBoxFile");
            this.textBoxFile.Name = "textBoxFile";
            this.toolTip1.SetToolTip(this.textBoxFile, resources.GetString("textBoxFile.ToolTip"));
            // 
            // labelAlbum
            // 
            resources.ApplyResources(this.labelAlbum, "labelAlbum");
            this.labelAlbum.Name = "labelAlbum";
            this.toolTip1.SetToolTip(this.labelAlbum, resources.GetString("labelAlbum.ToolTip"));
            // 
            // labelYear
            // 
            resources.ApplyResources(this.labelYear, "labelYear");
            this.labelYear.Name = "labelYear";
            this.toolTip1.SetToolTip(this.labelYear, resources.GetString("labelYear.ToolTip"));
            // 
            // labelGenre
            // 
            resources.ApplyResources(this.labelGenre, "labelGenre");
            this.labelGenre.Name = "labelGenre";
            this.toolTip1.SetToolTip(this.labelGenre, resources.GetString("labelGenre.ToolTip"));
            // 
            // textBoxAlbum
            // 
            resources.ApplyResources(this.textBoxAlbum, "textBoxAlbum");
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.toolTip1.SetToolTip(this.textBoxAlbum, resources.GetString("textBoxAlbum.ToolTip"));
            // 
            // textBoxArtist
            // 
            resources.ApplyResources(this.textBoxArtist, "textBoxArtist");
            this.textBoxArtist.Name = "textBoxArtist";
            this.toolTip1.SetToolTip(this.textBoxArtist, resources.GetString("textBoxArtist.ToolTip"));
            // 
            // textBoxGenre
            // 
            resources.ApplyResources(this.textBoxGenre, "textBoxGenre");
            this.textBoxGenre.Name = "textBoxGenre";
            this.toolTip1.SetToolTip(this.textBoxGenre, resources.GetString("textBoxGenre.ToolTip"));
            // 
            // textBoxYear
            // 
            resources.ApplyResources(this.textBoxYear, "textBoxYear");
            this.textBoxYear.Name = "textBoxYear";
            this.toolTip1.SetToolTip(this.textBoxYear, resources.GetString("textBoxYear.ToolTip"));
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            this.toolTip1.SetToolTip(this.logo, resources.GetString("logo.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 1000;
            // 
            // buttonPlAdd
            // 
            resources.ApplyResources(this.buttonPlAdd, "buttonPlAdd");
            this.buttonPlAdd.Name = "buttonPlAdd";
            this.toolTip1.SetToolTip(this.buttonPlAdd, resources.GetString("buttonPlAdd.ToolTip"));
            this.buttonPlAdd.UseVisualStyleBackColor = true;
            this.buttonPlAdd.Click += new System.EventHandler(this.buttonPlAdd_Click);
            // 
            // buttonPlUp
            // 
            resources.ApplyResources(this.buttonPlUp, "buttonPlUp");
            this.buttonPlUp.FlatAppearance.BorderSize = 0;
            this.buttonPlUp.Name = "buttonPlUp";
            this.toolTip1.SetToolTip(this.buttonPlUp, resources.GetString("buttonPlUp.ToolTip"));
            this.buttonPlUp.UseVisualStyleBackColor = true;
            this.buttonPlUp.Click += new System.EventHandler(this.buttonPlUp_Click);
            this.buttonPlUp.MouseHover += new System.EventHandler(this.buttonPlUp_MouseHover);
            // 
            // buttonPlDown
            // 
            resources.ApplyResources(this.buttonPlDown, "buttonPlDown");
            this.buttonPlDown.FlatAppearance.BorderSize = 0;
            this.buttonPlDown.Name = "buttonPlDown";
            this.toolTip1.SetToolTip(this.buttonPlDown, resources.GetString("buttonPlDown.ToolTip"));
            this.buttonPlDown.UseVisualStyleBackColor = true;
            this.buttonPlDown.Click += new System.EventHandler(this.buttonPlDown_Click);
            this.buttonPlDown.MouseHover += new System.EventHandler(this.buttonPlDown_MouseHover);
            // 
            // buttonMove
            // 
            resources.ApplyResources(this.buttonMove, "buttonMove");
            this.buttonMove.Name = "buttonMove";
            this.toolTip1.SetToolTip(this.buttonMove, resources.GetString("buttonMove.ToolTip"));
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDbCheck
            // 
            resources.ApplyResources(this.buttonDbCheck, "buttonDbCheck");
            this.buttonDbCheck.Name = "buttonDbCheck";
            this.toolTip1.SetToolTip(this.buttonDbCheck, resources.GetString("buttonDbCheck.ToolTip"));
            this.buttonDbCheck.UseVisualStyleBackColor = true;
            this.buttonDbCheck.Click += new System.EventHandler(this.buttonDbCheck_Click);
            // 
            // buttonAddFile
            // 
            resources.ApplyResources(this.buttonAddFile, "buttonAddFile");
            this.buttonAddFile.Name = "buttonAddFile";
            this.toolTip1.SetToolTip(this.buttonAddFile, resources.GetString("buttonAddFile.ToolTip"));
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            resources.ApplyResources(this.openFileDialog2, "openFileDialog2");
            // 
            // testButtonToolStripMenuItem
            // 
            resources.ApplyResources(this.testButtonToolStripMenuItem, "testButtonToolStripMenuItem");
            this.testButtonToolStripMenuItem.Name = "testButtonToolStripMenuItem";
            this.testButtonToolStripMenuItem.Click += new System.EventHandler(this.testButtonToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonDbCheck);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonPlDown);
            this.Controls.Add(this.buttonPlUp);
            this.Controls.Add(this.buttonPlAdd);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.buttonSearchCancel);
            this.Controls.Add(this.buttonEditSearch);
            this.Controls.Add(this.buttonEditClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonPlClear);
            this.Controls.Add(this.buttonPlDel);
            this.Controls.Add(this.objectListViewPlaylist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.objectListViewSongs);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewPlaylist)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar volumeBar;
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
        private BrightIdeasSoftware.ObjectListView objectListViewSongs;
        private BrightIdeasSoftware.OLVColumn id;
        private BrightIdeasSoftware.OLVColumn path;
        private BrightIdeasSoftware.OLVColumn file;
        private BrightIdeasSoftware.OLVColumn artist;
        private BrightIdeasSoftware.OLVColumn title;
        private BrightIdeasSoftware.OLVColumn album;
        private BrightIdeasSoftware.OLVColumn year;
        private BrightIdeasSoftware.OLVColumn genre;

        //VRB
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightSkyBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightSteelBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paoloVeronesesGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightSalmonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeDGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mistyRoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradient0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradient1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradient2ToolStripMenuItem;
        private GradientController kontrolka1;
        //VRB

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button2;
        private System.Windows.Forms.ToolStripMenuItem buttonAdd2;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonDel;
        private System.Windows.Forms.ToolStripMenuItem buttonDel2;
        private System.Windows.Forms.ToolStripMenuItem buttonClear;
        private System.Windows.Forms.Button buttonPlClear;
        private System.Windows.Forms.Button buttonPlDel;
        private BrightIdeasSoftware.ObjectListView objectListViewPlaylist;
        private BrightIdeasSoftware.OLVColumn Id_p;
        private BrightIdeasSoftware.OLVColumn Path_p;
        private BrightIdeasSoftware.OLVColumn Id_auto;
        private BrightIdeasSoftware.OLVColumn File_p;
        private BrightIdeasSoftware.OLVColumn Artist_p;
        private BrightIdeasSoftware.OLVColumn Title_p;
        private System.Windows.Forms.Button buttonSearchCancel;
        private System.Windows.Forms.Button buttonEditSearch;
        private System.Windows.Forms.Button buttonEditClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TrackBar prog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonPlAdd;
        private System.Windows.Forms.Button buttonPlUp;
        private System.Windows.Forms.Button buttonPlDown;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonDbCheck;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem testButtonToolStripMenuItem;
    }
}

