using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text.RegularExpressions;
//using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class FFmpegotron : Form
    {
        public FFmpegotron()
        {
            InitializeComponent();
            this.Text = "FFmpegotron";
            downloadDependancies();


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        async void downloadDependancies()
        {
            await YoutubeDLSharp.Utils.DownloadFFmpeg();
            await YoutubeDLSharp.Utils.DownloadYtDlp();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string format = ytDownloaderFormatBox.GetItemText(ytDownloaderFormatBox.SelectedItem);
            var formats = new List<string> { "mkv", "mov", "mp4", "avi" };
            if (format != "mp3" && format != "wav")
            {
                ytVideoResBox.Enabled = true;
                ytVideoResLabel.Enabled = true;
            }
            else
            {
                ytVideoResBox.Enabled = false;
                ytVideoResLabel.Enabled = false;
            }
        }

        private void ytDownloadVideoButton(object sender, EventArgs e)
        {
            string chosenName = fileNameBox2.Text;
            if (chosenName == "")
            {
                chosenName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            }
            string formatChosen = ytDownloaderFormatBox.Text;
            string folderPath = folderDialog.FileName;
            
            string vidResolution = Regex.Replace(ytVideoResBox.Text, "p", string.Empty);
            //if (formatChosen != "" && filename.Length > 1)
            {
                if (chosenName == "")
                {
                    chosenName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                }
                var proc2 = new ProcessStartInfo();
                proc2.UseShellExecute = true;
                proc2.WorkingDirectory = "./";
                proc2.FileName = "cmd.exe";
                proc2.Arguments = "/c " + $@"yt-dlp -o ""{chosenName}"" --recode-video {formatChosen} -S res:{vidResolution} -P ""{folderPath}"" " ;
                proc2.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(proc2);
            }
            /*else
            {
                MessageBox.Show("Please fill out the required fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void moreStatsTickChanged(object sender, EventArgs e)
        {
            if (moreStatsToggle.Checked == false)
            {
                panel2.Enabled = false;
                panel2.Visible = false;
            }
            else
            {
                panel2.Enabled = true;
                panel2.Visible = true;
            }
            ytVideoResLabel.Text = folderDialog.FileName;
        }

        private void switchToFFmpegClick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        public void ytChooseDownloadDirButtonClick(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog();
            folderDialog.InitialDirectory = "./";
            folderDialog.IsFolderPicker = true;
            folderDialog.Title = "Pick a folder!";
            folderDialog.ShowDialog();

        }

        private void convertFileFFmpegClick(object sender, EventArgs e)
        {
            string chosenFormat = ffmpegMediaFormatBox.GetItemText(ffmpegMediaFormatBox.SelectedItem);
            string filename = openFileDialog1.FileName;
            string chosenName = ffmpegTextBox.Text;
            string path = Path.GetDirectoryName(filename);
            string convertedFileName = Regex.Replace(openFileDialog1.FileName + chosenName + "." + chosenFormat, openFileDialog1.SafeFileName, string.Empty);
            if (File.Exists(convertedFileName)) 
            {
                MessageBox.Show("File with the same name exists in chosen folder, rename and try again.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (chosenFormat != "" && filename.Length > 1)
                {
                    if (chosenName == "")
                    {
                        chosenName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    }
                    var proc1 = new ProcessStartInfo();
                    proc1.UseShellExecute = true;
                    proc1.WorkingDirectory = "./";
                    proc1.FileName = "cmd.exe";
                    proc1.Arguments = "/c " + $@"ffmpeg -i ""{path}\{openFileDialog1.SafeFileName}"" {path}/""{chosenName}"".{chosenFormat}";
                    proc1.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(proc1);
                }
                else
                {
                    MessageBox.Show("Please fill out the required fields!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goToFileClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe ", "/select, " + openFileDialog1.FileName);
        }

        private void ffmpegChooseFileClick(object sender, EventArgs e)
        {
            fileChosenLabel.Visible = false;
            openFileDialog1.Filter = "Media Files|*.mp4;*.mp3;*.wav;*.mkv;*.mov";
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Choose a media file!";
            openFileDialog1.ShowDialog();
            string filename = string.Empty;
            string file_path = string.Empty;
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                file_path = $"File: {openFileDialog1.FileName}";
                ffmpegGoToFileButton.Enabled = true;
                fileChosenLabel.Text = file_path;
                fileChosenLabel.Visible = true;
            }
        }

        private void ffmpegChooseFormatBoxChanged(object sender, EventArgs e)
        {
            string format = ffmpegMediaFormatBox.GetItemText(ffmpegMediaFormatBox.SelectedItem);
        }

        private void changeToYTDownloaderClick(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
        }
    }
}

