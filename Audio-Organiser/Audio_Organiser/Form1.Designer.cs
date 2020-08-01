
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
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.resolutionPanel = new System.Windows.Forms.Panel();
            this.resolutionsBox = new System.Windows.Forms.ListBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.kontrolka1 = new Audio_Organiser.Kontrolka();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewPlaylist)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.resolutionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.resolutionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = menuStripText;
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button2,
            this.buttonAdd2});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = dodajToolStripMenuItemText;
            // 
            // button2
            // 
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 22);
            this.button2.Text = button2Text;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(217, 22);
            this.buttonAdd2.Text = buttonAdd2Text;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonDel,
            this.buttonDel2,
            this.buttonClear});
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.usuńToolStripMenuItem.Text = usuńToolStripMenuItemText;
            // 
            // buttonDel
            // 
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(189, 22);
            this.buttonDel.Text = buttonDelText;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonDel2
            // 
            this.buttonDel2.Name = "buttonDel2";
            this.buttonDel2.Size = new System.Drawing.Size(189, 22);
            this.buttonDel2.Text = buttonDel2Text;
            this.buttonDel2.Click += new System.EventHandler(this.buttonDel2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(189, 22);
            this.buttonClear.Text = buttonClearText;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.solidColorToolStripMenuItem,
            this.textureToolStripMenuItem,
            this.gradientToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.themesToolStripMenuItem.Text = themesToolStripMenuItemText;
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Checked = true;
            this.defaultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = defaultToolStripMenuItemText;
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // solidColorToolStripMenuItem
            // 
            this.solidColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.steelToolStripMenuItem,
            this.lightSkyBlueToolStripMenuItem,
            this.lightSteelBlueToolStripMenuItem,
            this.paoloVeronesesGreenToolStripMenuItem,
            this.lightSalmonToolStripMenuItem,
            this.mistyRoseToolStripMenuItem});
            this.solidColorToolStripMenuItem.Name = "solidColorToolStripMenuItem";
            this.solidColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.solidColorToolStripMenuItem.Text = solidColorToolStripMenuItemText;
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.whiteToolStripMenuItem.Text = whiteToolStripMenuItemText;
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // steelToolStripMenuItem
            // 
            this.steelToolStripMenuItem.Name = "steelToolStripMenuItem";
            this.steelToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.steelToolStripMenuItem.Text = steelToolStripMenuItemText;
            this.steelToolStripMenuItem.Click += new System.EventHandler(this.steelToolStripMenuItem_Click);
            // 
            // lightSkyBlueToolStripMenuItem
            // 
            this.lightSkyBlueToolStripMenuItem.Name = "lightSkyBlueToolStripMenuItem";
            this.lightSkyBlueToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.lightSkyBlueToolStripMenuItem.Text = lightSkyBlueToolStripMenuItemText;
            this.lightSkyBlueToolStripMenuItem.Click += new System.EventHandler(this.lightSkyBlueToolStripMenuItem_Click);
            // 
            // lightSteelBlueToolStripMenuItem
            // 
            this.lightSteelBlueToolStripMenuItem.Name = "lightSteelBlueToolStripMenuItem";
            this.lightSteelBlueToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.lightSteelBlueToolStripMenuItem.Text = lightSteelBlueToolStripMenuItemText;
            this.lightSteelBlueToolStripMenuItem.Click += new System.EventHandler(this.lightSteelBlueToolStripMenuItem_Click);
            // 
            // paoloVeronesesGreenToolStripMenuItem
            // 
            this.paoloVeronesesGreenToolStripMenuItem.Name = "paoloVeronesesGreenToolStripMenuItem";
            this.paoloVeronesesGreenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.paoloVeronesesGreenToolStripMenuItem.Text = paoloVeronesesGreenToolStripMenuItemText;
            this.paoloVeronesesGreenToolStripMenuItem.Click += new System.EventHandler(this.paoloVeronesesGreenToolStripMenuItem_Click);
            // 
            // lightSalmonToolStripMenuItem
            // 
            this.lightSalmonToolStripMenuItem.Name = "lightSalmonToolStripMenuItem";
            this.lightSalmonToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.lightSalmonToolStripMenuItem.Text = lightSalmonToolStripMenuItemText;
            this.lightSalmonToolStripMenuItem.Click += new System.EventHandler(this.lightSalmonToolStripMenuItem_Click);
            // 
            // mistyRoseToolStripMenuItem
            // 
            this.mistyRoseToolStripMenuItem.Name = "mistyRoseToolStripMenuItem";
            this.mistyRoseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.mistyRoseToolStripMenuItem.Text = mistyRoseToolStripMenuItemText;
            this.mistyRoseToolStripMenuItem.Click += new System.EventHandler(this.mistyRoseToolStripMenuItem_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeDGreenToolStripMenuItem,
            this.blueWebToolStripMenuItem,
            this.leatherToolStripMenuItem});
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textureToolStripMenuItem.Text = textureToolStripMenuItemText;
            // 
            // freeDGreenToolStripMenuItem
            // 
            this.freeDGreenToolStripMenuItem.Name = "freeDGreenToolStripMenuItem";
            this.freeDGreenToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.freeDGreenToolStripMenuItem.Text = freeDGreenToolStripMenuItemText;
            this.freeDGreenToolStripMenuItem.Click += new System.EventHandler(this.freeDGreenToolStripMenuItem_Click);
            // 
            // blueWebToolStripMenuItem
            // 
            this.blueWebToolStripMenuItem.Name = "blueWebToolStripMenuItem";
            this.blueWebToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.blueWebToolStripMenuItem.Text = blueWebToolStripMenuItemText;
            this.blueWebToolStripMenuItem.Click += new System.EventHandler(this.blueWebToolStripMenuItem_Click);
            // 
            // leatherToolStripMenuItem
            // 
            this.leatherToolStripMenuItem.Name = "leatherToolStripMenuItem";
            this.leatherToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.leatherToolStripMenuItem.Text = leatherToolStripMenuItemText;
            this.leatherToolStripMenuItem.Click += new System.EventHandler(this.leatherToolStripMenuItem_Click);
            // 
            // gradientToolStripMenuItem
            // 
            this.gradientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradient0ToolStripMenuItem,
            this.gradient1ToolStripMenuItem,
            this.gradient2ToolStripMenuItem});
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            this.gradientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradientToolStripMenuItem.Text = gradientToolStripMenuItemText;
            // 
            // gradient0ToolStripMenuItem
            // 
            this.gradient0ToolStripMenuItem.Name = "gradient0ToolStripMenuItem";
            this.gradient0ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradient0ToolStripMenuItem.Text = gradient0ToolStripMenuItemText;
            this.gradient0ToolStripMenuItem.Click += new System.EventHandler(this.gradient0ToolStripMenuItem_Click);
            // 
            // gradient1ToolStripMenuItem
            // 
            this.gradient1ToolStripMenuItem.Name = "gradient1ToolStripMenuItem";
            this.gradient1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradient1ToolStripMenuItem.Text = gradient1ToolStripMenuItemText;
            this.gradient1ToolStripMenuItem.Click += new System.EventHandler(this.gradient1ToolStripMenuItem_Click);
            // 
            // gradient2ToolStripMenuItem
            // 
            this.gradient2ToolStripMenuItem.Name = "gradient2ToolStripMenuItem";
            this.gradient2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradient2ToolStripMenuItem.Text = gradient2ToolStripMenuItemText;
            this.gradient2ToolStripMenuItem.Click += new System.EventHandler(this.gradient2ToolStripMenuItem_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.resolutionToolStripMenuItem.Text = resolutionToolStripMenuItemText;
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTime.Location = new System.Drawing.Point(3, 150);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(56, 17);
            this.currentTime.TabIndex = 25;
            this.currentTime.Text = currentTimeText;
            // 
            // currentLength
            // 
            this.currentLength.AutoSize = true;
            this.currentLength.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentLength.Location = new System.Drawing.Point(200, 150);
            this.currentLength.Name = "currentLength";
            this.currentLength.Size = new System.Drawing.Size(56, 17);
            this.currentLength.TabIndex = 26;
            this.currentLength.Text = currentLengthText;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // currentArtist
            // 
            this.currentArtist.AutoEllipsis = true;
            this.currentArtist.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentArtist.Location = new System.Drawing.Point(102, 6);
            this.currentArtist.Name = "currentArtist";
            this.currentArtist.Size = new System.Drawing.Size(150, 20);
            this.currentArtist.TabIndex = 27;
            // 
            // currentSong
            // 
            this.currentSong.AutoEllipsis = true;
            this.currentSong.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentSong.Location = new System.Drawing.Point(103, 26);
            this.currentSong.Name = "currentSong";
            this.currentSong.Size = new System.Drawing.Size(150, 18);
            this.currentSong.TabIndex = 28;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(11, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 179);
            this.panel1.TabIndex = 33;
            // 
            // prog
            // 
            this.prog.BackColor = System.Drawing.Color.DarkGray;
            this.prog.Enabled = false;
            this.prog.Location = new System.Drawing.Point(57, 148);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(144, 45);
            this.prog.TabIndex = 33;
            this.prog.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // buttonLoopList
            // 
            this.buttonLoopList.FlatAppearance.BorderSize = 0;
            this.buttonLoopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoopList.Image = global::Audio_Organiser.Properties.Resources.loop_pl;
            this.buttonLoopList.Location = new System.Drawing.Point(197, 106);
            this.buttonLoopList.Name = "buttonLoopList";
            this.buttonLoopList.Size = new System.Drawing.Size(26, 26);
            this.buttonLoopList.TabIndex = 31;
            this.buttonLoopList.UseVisualStyleBackColor = true;
            this.buttonLoopList.Click += new System.EventHandler(this.buttonLoopList_Click);
            this.buttonLoopList.MouseHover += new System.EventHandler(this.buttonLoopList_MouseHover);
            // 
            // buttonLoopSong
            // 
            this.buttonLoopSong.FlatAppearance.BorderSize = 0;
            this.buttonLoopSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoopSong.Image = global::Audio_Organiser.Properties.Resources.loop_s;
            this.buttonLoopSong.Location = new System.Drawing.Point(225, 106);
            this.buttonLoopSong.Name = "buttonLoopSong";
            this.buttonLoopSong.Size = new System.Drawing.Size(26, 26);
            this.buttonLoopSong.TabIndex = 32;
            this.buttonLoopSong.UseVisualStyleBackColor = true;
            this.buttonLoopSong.Click += new System.EventHandler(this.buttonLoopSong_Click);
            this.buttonLoopSong.MouseHover += new System.EventHandler(this.buttonLoopSong_MouseHover);
            // 
            // buttonAutoplay
            // 
            this.buttonAutoplay.FlatAppearance.BorderSize = 0;
            this.buttonAutoplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoplay.Image = global::Audio_Organiser.Properties.Resources.auto;
            this.buttonAutoplay.Location = new System.Drawing.Point(169, 106);
            this.buttonAutoplay.Name = "buttonAutoplay";
            this.buttonAutoplay.Size = new System.Drawing.Size(26, 26);
            this.buttonAutoplay.TabIndex = 30;
            this.buttonAutoplay.UseVisualStyleBackColor = true;
            this.buttonAutoplay.Click += new System.EventHandler(this.buttonAutoplay_Click);
            this.buttonAutoplay.MouseHover += new System.EventHandler(this.buttonAutoplay_MouseHover);
            // 
            // buttonMute
            // 
            this.buttonMute.FlatAppearance.BorderSize = 0;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.Image = global::Audio_Organiser.Properties.Resources.mute_off;
            this.buttonMute.Location = new System.Drawing.Point(216, 56);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(26, 26);
            this.buttonMute.TabIndex = 29;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            this.buttonMute.MouseHover += new System.EventHandler(this.buttonMute_MouseHover);
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
            this.buttonStop.MouseHover += new System.EventHandler(this.buttonStop_MouseHover);
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
            this.buttonPrevious.MouseHover += new System.EventHandler(this.buttonPrevious_MouseHover);
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
            this.buttonNext.MouseHover += new System.EventHandler(this.buttonNext_MouseHover);
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
            this.buttonPause.MouseHover += new System.EventHandler(this.buttonPause_MouseHover);
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
            this.buttonPlay.MouseHover += new System.EventHandler(this.buttonPlay_MouseHover);
            // 
            // objectListViewSongs
            // 
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
            this.objectListViewSongs.Location = new System.Drawing.Point(278, 39);
            this.objectListViewSongs.MultiSelect = false;
            this.objectListViewSongs.Name = "objectListViewSongs";
            this.objectListViewSongs.SelectAllOnControlA = false;
            this.objectListViewSongs.ShowGroups = false;
            this.objectListViewSongs.Size = new System.Drawing.Size(974, 506);
            this.objectListViewSongs.TabIndex = 25;
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
            this.id.Text = idText;
            this.id.Width = 0;
            // 
            // path
            // 
            this.path.AspectName = "path";
            this.path.Text = pathText;
            this.path.Width = 0;
            // 
            // file
            // 
            this.file.AspectName = "file";
            this.file.Text = fileText;
            this.file.Width = 272;
            // 
            // artist
            // 
            this.artist.AspectName = "artist";
            this.artist.Text = artistText;
            this.artist.Width = 189;
            // 
            // title
            // 
            this.title.AspectName = "title";
            this.title.Text = titleText;
            this.title.Width = 164;
            // 
            // album
            // 
            this.album.AspectName = "album";
            this.album.Text = albumText;
            this.album.Width = 137;
            // 
            // year
            // 
            this.year.AspectName = "year";
            this.year.Text = yearText;
            this.year.Width = 59;
            // 
            // genre
            // 
            this.genre.AspectName = "genre";
            this.genre.Text = genreText;
            this.genre.Width = 149;
            // 
            // buttonPlClear
            // 
            this.buttonPlClear.Location = new System.Drawing.Point(197, 700);
            this.buttonPlClear.Name = "buttonPlClear";
            this.buttonPlClear.Size = new System.Drawing.Size(75, 23);
            this.buttonPlClear.TabIndex = 50;
            this.buttonPlClear.Text = buttonPlClearText;
            this.buttonPlClear.UseVisualStyleBackColor = true;
            this.buttonPlClear.Click += new System.EventHandler(this.buttonPlClear_Click);
            // 
            // buttonPlDel
            // 
            this.buttonPlDel.Location = new System.Drawing.Point(11, 700);
            this.buttonPlDel.Name = "buttonPlDel";
            this.buttonPlDel.Size = new System.Drawing.Size(75, 23);
            this.buttonPlDel.TabIndex = 49;
            this.buttonPlDel.Text = buttonPlDelText;
            this.buttonPlDel.UseVisualStyleBackColor = true;
            this.buttonPlDel.Click += new System.EventHandler(this.buttonPlDel_Click);
            // 
            // objectListViewPlaylist
            // 
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
            this.objectListViewPlaylist.Location = new System.Drawing.Point(11, 224);
            this.objectListViewPlaylist.Name = "objectListViewPlaylist";
            this.objectListViewPlaylist.ShowGroups = false;
            this.objectListViewPlaylist.Size = new System.Drawing.Size(261, 470);
            this.objectListViewPlaylist.TabIndex = 48;
            this.objectListViewPlaylist.UseCompatibleStateImageBehavior = false;
            this.objectListViewPlaylist.UseHotControls = false;
            this.objectListViewPlaylist.View = System.Windows.Forms.View.Details;
            this.objectListViewPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListViewPlaylist_MouseDoubleClick);
            // 
            // Id_p
            // 
            this.Id_p.AspectName = "id";
            this.Id_p.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Id_p.Searchable = false;
            this.Id_p.Sortable = false;
            this.Id_p.Text = Id_pText;
            this.Id_p.UseFiltering = false;
            this.Id_p.Width = 0;
            // 
            // Path_p
            // 
            this.Path_p.AspectName = "path";
            this.Path_p.Searchable = false;
            this.Path_p.Sortable = false;
            this.Path_p.Text = Path_pText;
            this.Path_p.UseFiltering = false;
            this.Path_p.Width = 0;
            // 
            // Id_auto
            // 
            this.Id_auto.AspectName = "id_auto";
            this.Id_auto.IsTileViewColumn = true;
            this.Id_auto.Searchable = false;
            this.Id_auto.Sortable = false;
            this.Id_auto.Text = Id_autoText;
            this.Id_auto.UseFiltering = false;
            this.Id_auto.Width = 22;
            // 
            // File_p
            // 
            this.File_p.AspectName = "file";
            this.File_p.Searchable = false;
            this.File_p.Sortable = false;
            this.File_p.Text = File_pText;
            this.File_p.UseFiltering = false;
            this.File_p.Width = 77;
            // 
            // Artist_p
            // 
            this.Artist_p.AspectName = "artist";
            this.Artist_p.Searchable = false;
            this.Artist_p.Sortable = false;
            this.Artist_p.Text = Artist_pText;
            this.Artist_p.UseFiltering = false;
            this.Artist_p.Width = 84;
            // 
            // Title_p
            // 
            this.Title_p.AspectName = "title";
            this.Title_p.Searchable = false;
            this.Title_p.Sortable = false;
            this.Title_p.Text = Title_pText;
            this.Title_p.UseFiltering = false;
            this.Title_p.Width = 74;
            // 
            // buttonSearchCancel
            // 
            this.buttonSearchCancel.Location = new System.Drawing.Point(1148, 554);
            this.buttonSearchCancel.Name = "buttonSearchCancel";
            this.buttonSearchCancel.Size = new System.Drawing.Size(104, 23);
            this.buttonSearchCancel.TabIndex = 55;
            this.buttonSearchCancel.Text = buttonSearchCancelText;
            this.buttonSearchCancel.UseVisualStyleBackColor = true;
            this.buttonSearchCancel.Click += new System.EventHandler(this.buttonSearchCancel_Click);
            // 
            // buttonEditSearch
            // 
            this.buttonEditSearch.Location = new System.Drawing.Point(543, 581);
            this.buttonEditSearch.Name = "buttonEditSearch";
            this.buttonEditSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonEditSearch.TabIndex = 54;
            this.buttonEditSearch.Text = buttonEditSearchText;
            this.buttonEditSearch.UseVisualStyleBackColor = true;
            this.buttonEditSearch.Click += new System.EventHandler(this.buttonEditSearch_Click);
            // 
            // buttonEditClear
            // 
            this.buttonEditClear.Location = new System.Drawing.Point(543, 554);
            this.buttonEditClear.Name = "buttonEditClear";
            this.buttonEditClear.Size = new System.Drawing.Size(75, 23);
            this.buttonEditClear.TabIndex = 53;
            this.buttonEditClear.Text = buttonEditClearText;
            this.buttonEditClear.UseVisualStyleBackColor = true;
            this.buttonEditClear.Click += new System.EventHandler(this.buttonEditClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = button1Text;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(278, 551);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 182);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(3, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(65, 13);
            this.labelFile.TabIndex = 8;
            this.labelFile.Text = labelFileText;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 13);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = labelTitleText;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(3, 30);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(70, 26);
            this.labelArtist.TabIndex = 9;
            this.labelArtist.Text = labelArtistText;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(102, 63);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(154, 20);
            this.textBoxTitle.TabIndex = 13;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(102, 3);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(154, 20);
            this.textBoxFile.TabIndex = 11;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(3, 90);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(36, 13);
            this.labelAlbum.TabIndex = 14;
            this.labelAlbum.Text = labelAlbumText;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(3, 120);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(27, 13);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = labelYearText;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(3, 150);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 13);
            this.labelGenre.TabIndex = 16;
            this.labelGenre.Text = labelGenreText;
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(102, 93);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(154, 20);
            this.textBoxAlbum.TabIndex = 17;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(102, 33);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(154, 20);
            this.textBoxArtist.TabIndex = 12;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(102, 153);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(154, 20);
            this.textBoxGenre.TabIndex = 19;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(102, 123);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(154, 20);
            this.textBoxYear.TabIndex = 20;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(1126, 606);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(138, 127);
            this.logo.TabIndex = 59;
            this.logo.TabStop = false;
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
            this.buttonPlAdd.Location = new System.Drawing.Point(995, 554);
            this.buttonPlAdd.Name = "buttonPlAdd";
            this.buttonPlAdd.Size = new System.Drawing.Size(147, 23);
            this.buttonPlAdd.TabIndex = 60;
            this.buttonPlAdd.Text = buttonPlAddText;
            this.buttonPlAdd.UseVisualStyleBackColor = true;
            this.buttonPlAdd.Click += new System.EventHandler(this.buttonPlAdd_Click);
            // 
            // buttonPlUp
            // 
            this.buttonPlUp.FlatAppearance.BorderSize = 0;
            this.buttonPlUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlUp.Image")));
            this.buttonPlUp.Location = new System.Drawing.Point(140, 700);
            this.buttonPlUp.Name = "buttonPlUp";
            this.buttonPlUp.Size = new System.Drawing.Size(26, 26);
            this.buttonPlUp.TabIndex = 61;
            this.buttonPlUp.UseVisualStyleBackColor = true;
            this.buttonPlUp.Click += new System.EventHandler(this.buttonPlUp_Click);
            this.buttonPlUp.MouseHover += new System.EventHandler(this.buttonPlUp_MouseHover);
            // 
            // buttonPlDown
            // 
            this.buttonPlDown.FlatAppearance.BorderSize = 0;
            this.buttonPlDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlDown.Image")));
            this.buttonPlDown.Location = new System.Drawing.Point(108, 700);
            this.buttonPlDown.Name = "buttonPlDown";
            this.buttonPlDown.Size = new System.Drawing.Size(26, 26);
            this.buttonPlDown.TabIndex = 62;
            this.buttonPlDown.UseVisualStyleBackColor = true;
            this.buttonPlDown.Click += new System.EventHandler(this.buttonPlDown_Click);
            this.buttonPlDown.MouseHover += new System.EventHandler(this.buttonPlDown_MouseHover);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(543, 639);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 63;
            this.buttonMove.Text = buttonMoveText;
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDbCheck
            // 
            this.buttonDbCheck.Location = new System.Drawing.Point(1148, 581);
            this.buttonDbCheck.Name = "buttonDbCheck";
            this.buttonDbCheck.Size = new System.Drawing.Size(104, 23);
            this.buttonDbCheck.TabIndex = 64;
            this.buttonDbCheck.Text = buttonDbCheckText;
            this.buttonDbCheck.UseVisualStyleBackColor = true;
            this.buttonDbCheck.Click += new System.EventHandler(this.buttonDbCheck_Click);
            // 
            // resolutionPanel
            // 
            this.resolutionPanel.Controls.Add(this.resolutionsBox);
            this.resolutionPanel.Controls.Add(this.resolutionLabel);
            this.resolutionPanel.Location = new System.Drawing.Point(560, 96);
            this.resolutionPanel.Name = "resolutionPanel";
            this.resolutionPanel.Size = new System.Drawing.Size(181, 177);
            this.resolutionPanel.TabIndex = 65;
            this.resolutionPanel.Visible = false;
            // 
            // resolutionsBox
            // 
            this.resolutionsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resolutionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resolutionsBox.FormattingEnabled = true;
            this.resolutionsBox.ItemHeight = 37;
            this.resolutionsBox.Items.AddRange(new object[] {
            "1280 x 768 " + defaultResolutionText,
            "1024 x 768",
            "800 x 768"});
            this.resolutionsBox.Location = new System.Drawing.Point(3, 50);
            this.resolutionsBox.Name = "resolutionsBox";
            this.resolutionsBox.Size = new System.Drawing.Size(175, 111);
            this.resolutionsBox.TabIndex = 2;
            this.resolutionsBox.Visible = false;
            this.resolutionsBox.SelectedIndexChanged += new System.EventHandler(this.resolutionsBox_SelectedIndexChanged);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resolutionLabel.Location = new System.Drawing.Point(1, 10);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(177, 37);
            this.resolutionLabel.TabIndex = 1;
            this.resolutionLabel.Text = "Rozdzielczość";
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(543, 668);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFile.TabIndex = 66;
            this.buttonAddFile.Text = buttonAddFileText;
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // kontrolka1
            // 
            this.kontrolka1.Color1 = System.Drawing.Color.Empty;
            this.kontrolka1.Color2 = System.Drawing.Color.Empty;
            this.kontrolka1.GradientRadius = 55;
            this.kontrolka1.Location = new System.Drawing.Point(0, 12);
            this.kontrolka1.Name = "kontrolka1";
            this.kontrolka1.Size = new System.Drawing.Size(1264, 721);
            this.kontrolka1.TabIndex = 42;
            this.kontrolka1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.resolutionPanel);
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
            this.Controls.Add(this.kontrolka1);
            this.Controls.Add(this.objectListViewSongs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = nameText;
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
            this.resolutionPanel.ResumeLayout(false);
            this.resolutionPanel.PerformLayout();
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
        private Kontrolka kontrolka1;
        private System.Windows.Forms.ListBox resolutionsBox;
        private System.Windows.Forms.Panel resolutionPanel;
        private System.Windows.Forms.Label resolutionLabel;
        //VRB

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button2;
        private System.Windows.Forms.ToolStripMenuItem buttonAdd2;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
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
    }
}

