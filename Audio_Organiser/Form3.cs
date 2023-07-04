using System;
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
            string baseDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            string songNameOrUrl = linkTextBox.Text;
            string output = baseDirectory + "\\songs\\" + "%(title)s.%(ext)s";
            string arguments = "-o \"" + output + "\" ytsearch:\"" + songNameOrUrl + "\" -x --audio-format mp3 --embed-thumbnail --add-metadata";
            Process downloading = new Process();

            downloading.StartInfo.FileName = baseDirectory + "yt-dlp.exe";
            downloading.StartInfo.UseShellExecute = false;
            downloading.StartInfo.CreateNoWindow = false;
            downloading.StartInfo.Arguments = arguments;
            downloading.Start();
            downloading.WaitForExit();
            MainWindow mainWindow = FormManager.mW;

            if (!(Directory.Exists(baseDirectory + "\\songs\\")))
                Directory.CreateDirectory(baseDirectory + "\\songs\\");
            
            string[] filePaths = Directory.GetFiles(baseDirectory + "\\songs\\");
            foreach (string filePath in filePaths) mainWindow.addF(filePath);
            this.Close();
            mainWindow.Show();
        }
    }
}
