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
            this.Text = "FFmpeg-ilizer";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string formatChosen = comboBox1.GetItemText(comboBox1.SelectedItem);
            string filename = openFileDialog1.FileName;
            string chosenName = textBox1.Text;
            string path = System.IO.Path.GetDirectoryName(filename);
            if (formatChosen != "" && path.Length > 3 && filename.Length > 3)
            {
                if (chosenName == "")
                {
                    chosenName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                }
                var proc1 = new ProcessStartInfo();
                string anyCommand;
                proc1.UseShellExecute = true;

                proc1.WorkingDirectory = path;
                proc1.FileName = "cmd.exe";
                //proc1.Verb = "runas";
                proc1.Arguments = "/c " + $@"ffmpeg -i ""{filename}"" {path}/{chosenName}.{formatChosen}";
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
            openFileDialog1.Filter = "Media File|*.mp4|*.mp3|*.wav|*.mkv|*.mov";
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Choose a media file!";
            openFileDialog1.ShowDialog();
            string filename = $"Chosen File: {openFileDialog1.FileName}";
            label1.Text = filename;
            Console.WriteLine(filename);
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
    }
}
