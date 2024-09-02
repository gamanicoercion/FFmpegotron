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
        private void button1_Click(object sender, EventArgs e)
        {
            string formatChosen = comboBox1.GetItemText(comboBox1.SelectedItem);
            string filename = openFileDialog1.FileName;
            string chosenName = textBox1.Text;
            string path = System.IO.Path.GetDirectoryName(filename);

            if (formatChosen != "" && filename.Length > 1) // && path.Length > 1
            {
                if (chosenName == "")
                {
                    chosenName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                }
                var proc1 = new ProcessStartInfo();
                proc1.UseShellExecute = true;

                //proc1.WorkingDirectory = path; 
                proc1.FileName = "cmd.exe";
                proc1.Arguments = "/c " + $@"ffmpeg -i ""{path}\\{openFileDialog1.SafeFileName}"" {path}/{chosenName}.{formatChosen}"; //TODO: make it run in the same folder as the executable
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(proc1);
            }
            else
            {
                MessageBox.Show("Please fill out the required fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media Files|*.mp4;*.mp3;*.wav;*.mkv;*.mov";
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Choose a media file!";
            openFileDialog1.ShowDialog();
            string filename = string.Empty;
            string file_path = string.Empty;
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                filename = $"Chosen File: {openFileDialog1.SafeFileName}";
                file_path = $"Path: {openFileDialog1.FileName}";
                label1.Text = filename;
                label6.Text = file_path;
                button4.Enabled = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string format = comboBox1.GetItemText(comboBox1.SelectedItem);
            label2.Text = $"Chosen format: {format}";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        async void downloadDependancies()
        {
            await YoutubeDLSharp.Utils.DownloadYtDlp();
            await YoutubeDLSharp.Utils.DownloadFFmpeg();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe ", "/select, " + openFileDialog1.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                panel2.Enabled = false;
                panel2.Visible = false;
            }
            else
            {
                panel2.Enabled = true;
                panel2.Visible = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string format = comboBox3.GetItemText(comboBox3.SelectedItem);
            var formats = new List<string> { "mkv", "mov", "mp4", "avi" };
            foreach (var frmt in formats) {
                if (frmt == format)
                {
                    comboBox2.Enabled = true;
                    comboBox2.Visible = true;
                    label8.Visible = true;
                }
                else
                {
                    comboBox2.Visible = false;
                    comboBox2.Enabled = false;
                    label8.Visible = false;
                }
            }

        }
    }
}
