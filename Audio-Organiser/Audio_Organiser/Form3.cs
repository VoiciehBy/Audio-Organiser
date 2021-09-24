﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Audio_Organiser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string projectRootPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
            string songNameOrUrl = linkTextBox.Text;
            string output = projectRootPath + "\\songs\\" + "%(title)s.%(ext)s";
            string arguments = "-o " + output + " \"ytsearch:" + songNameOrUrl + "\" -x --audio-format \"mp3\" --embed-thumbnail --add-metadata";
            Process downloading = new Process();
            downloading.StartInfo.FileName = projectRootPath + "youtube-dl.exe";
            downloading.StartInfo.Arguments = arguments;
            downloading.Start();
            MainWindow mW = FormManager.mW;
            this.Close();
            mW.Show();
        }
    }
}