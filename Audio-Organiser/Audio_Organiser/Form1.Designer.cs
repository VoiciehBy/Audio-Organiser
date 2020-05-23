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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.vScrollBard = new System.Windows.Forms.VScrollBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBard
            // 
            this.vScrollBard.Location = new System.Drawing.Point(800, 10);
            this.vScrollBard.Name = "vScrollBard";
            this.vScrollBard.Size = new System.Drawing.Size(16, 560);
            this.vScrollBard.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(817, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addToolStripMenu
            // 
            this.addToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.addToolStripMenu.Name = "addToolStripMenu";
            this.addToolStripMenu.Size = new System.Drawing.Size(38, 20);
            this.addToolStripMenu.Text = "Add";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.songToolStripMenuItem.Text = "Song";
            this.songToolStripMenuItem.Click += new System.EventHandler(this.songToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(620, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(170, 20);
            this.searchBox.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 443);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(138, 127);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(301, 146);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(455, 145);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(817, 568);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.vScrollBard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Audio Organiser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBard;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
    }
}

