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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WindowsFormsApp1
{
    public partial class FFmpegotron : Form
    {
        private Process ytDlpProcess;
        private Process ffmpegProcess;

        public CommonOpenFileDialog folderDialog = new CommonOpenFileDialog();
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

            string videoLink = videoLinkBox.Text;
            string formatChosen = ytDownloaderFormatBox.Text;
            string vidResolution = Regex.Replace(ytVideoResBox.Text, "p", string.Empty);
            bool isDialogDone = false;
            try
            {
                var test = folderDialog.FileName;
                isDialogDone = true;
            }
            catch (System.InvalidOperationException)
            {
                isDialogDone = false;
                MessageBox.Show("Please fill all the required fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (formatChosen != "" && Uri.IsWellFormedUriString(videoLink, UriKind.Absolute) && isDialogDone == true)
            {
                string folderPath = folderDialog.FileName;
                string chosenNameValidation = fileNameBox2.Text;
                string fileNameValidation = folderPath + chosenNameValidation;
                string fileNameTest = folderDialog.FileName +@"\" + chosenName + "." + formatChosen;
                if (File.Exists(fileNameTest))
                {
                    MessageBox.Show("File with the same name exists in chosen folder, rename and try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (vidResolution.Length < 3)
                {
                    vidResolution = "1080";
                }
                if (chosenName == "")
                {
                    chosenName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                }

                ytDlpProcess = new Process();

                ytDlpProcess.StartInfo.UseShellExecute = true;
                ytDlpProcess.StartInfo.WorkingDirectory = "./";
                ytDlpProcess.StartInfo.FileName = "cmd.exe";
                if (formatChosen != "mp3" || formatChosen != "wav")
                {
                    ytDlpProcess.StartInfo.Arguments = "/c " + $@"yt-dlp -o ""{chosenName}"" ""{videoLink}"" --recode-video {formatChosen} -S res:{vidResolution} -P ""{folderPath}"" ";
                }
                else
                {
                    ytDlpProcess.StartInfo.Arguments = "/c " + $@"yt-dlp -o ""{chosenName}"" ""{videoLink}"" --recode-video {formatChosen} -P ""{folderPath}"" ";
                }
                ytDlpProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                ytDlpProcess.EnableRaisingEvents = true;
                ytDlpProcess.Exited += new EventHandler(ytDlpExited);
                ytDlpProcess.Start();
                ytDlpProgressBar.Value = 50;
            }
            else
            {
                MessageBox.Show("Please fill out the required fields or recheck your entries!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ytDlpExited(object sender, EventArgs e)
        {
            if (ytDlpProcess.ExitCode == 0)
            {
                // success
                ytDlpProgressBar.Value = 100;
            }
            else
            {
                // failure
                ytDlpProgressBar.Value = 0;
                MessageBox.Show("Error when downloading video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ytDlpProcess.Dispose();
        }

        private void switchToFFmpegClick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        public void ytChooseDownloadDirButtonClick(object sender, EventArgs e)
        {
            folderDialog.InitialDirectory = "./";
            folderDialog.IsFolderPicker = true;
            folderDialog.Title = "Pick a folder!";
            folderDialog.ShowDialog();
            try
            {
                if (folderDialog.FileName.Length > 2)
                {
                    goToFolderButtonYT.Enabled = true;
                }
            }
            catch (System.InvalidOperationException) { }

        }

        private void convertFileFFmpegClick(object sender, EventArgs e)
        {
            string chosenFormat = ffmpegMediaFormatBox.GetItemText(ffmpegMediaFormatBox.SelectedItem);
            string filename = openFileDialog1.FileName;
            string chosenName = ffmpegTextBox.Text;
            string path = Path.GetDirectoryName(filename);
            string convertedFileName = Regex.Replace(openFileDialog1.FileName , openFileDialog1.SafeFileName, string.Empty) + chosenName + "." + chosenFormat;
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
                    ffmpegProcess = new Process();
                    ffmpegProcess.StartInfo.UseShellExecute = true;
                    ffmpegProcess.StartInfo.WorkingDirectory = "./";
                    ffmpegProcess.StartInfo.FileName = "cmd.exe";

                    ffmpegProcess.StartInfo.Arguments = "/c " + $@"ffmpeg -i ""{path}\{openFileDialog1.SafeFileName}"" {path}/""{chosenName}"".{chosenFormat}";
                    ffmpegProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    ffmpegProcess.EnableRaisingEvents = true;
                    ffmpegProcess.Exited += new EventHandler(ffmpegExited);
                    ffmpegProcess.Start();
                    ytDlpProgressBar.Value = 50;
                }
                else
                {
                    MessageBox.Show("Please fill out the required fields!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ffmpegExited(object sender, EventArgs e)
        {
            if (ffmpegProcess.ExitCode == 0)
            {
                // success
                ffmpegProgressBar.Value = 100;
            }
            else
            {
                // failure
                ffmpegProgressBar.Value = 0;
                MessageBox.Show("Error when converting media.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ffmpegProcess.Dispose();
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
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                string file_path = $"File: {openFileDialog1.FileName}";
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

        private void goToFolderClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe ", folderDialog.FileName);
        }
    }
}

