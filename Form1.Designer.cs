namespace WindowsFormsApp1
{
    partial class FFmpegotron
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFmpegotron));
            this.ffmpegChooseFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ffmpegMediaFormatBox = new System.Windows.Forms.ComboBox();
            this.convetFileButton = new System.Windows.Forms.Button();
            this.yourFileWillBeInLabel = new System.Windows.Forms.Label();
            this.ffmpegTextBox = new System.Windows.Forms.TextBox();
            this.ffmpegChooseFormatLabel = new System.Windows.Forms.Label();
            this.defaultText = new System.Windows.Forms.Label();
            this.switchToYoutubeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.defaultResLbl = new System.Windows.Forms.Label();
            this.folderChooseButton = new System.Windows.Forms.Button();
            this.nameUrFile2 = new System.Windows.Forms.Label();
            this.fileNameBox2 = new System.Windows.Forms.TextBox();
            this.videoFormatLabel2 = new System.Windows.Forms.Label();
            this.ytDownloaderFormatBox = new System.Windows.Forms.ComboBox();
            this.videoLinkLabel = new System.Windows.Forms.Label();
            this.videoLinkBox = new System.Windows.Forms.TextBox();
            this.downloadVidButton = new System.Windows.Forms.Button();
            this.switchToFFmpegButton = new System.Windows.Forms.Button();
            this.ytVideoResLabel = new System.Windows.Forms.Label();
            this.ytVideoResBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.moreStatsToggle = new System.Windows.Forms.CheckBox();
            this.defaultText2 = new System.Windows.Forms.Label();
            this.ffmpegGoToFileButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.fileChosenLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ffmpegChooseFileButton
            // 
            this.ffmpegChooseFileButton.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.ffmpegChooseFileButton, "ffmpegChooseFileButton");
            this.ffmpegChooseFileButton.Name = "ffmpegChooseFileButton";
            this.ffmpegChooseFileButton.UseVisualStyleBackColor = false;
            this.ffmpegChooseFileButton.Click += new System.EventHandler(this.ffmpegChooseFileClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ffmpegMediaFormatBox
            // 
            this.ffmpegMediaFormatBox.BackColor = System.Drawing.SystemColors.Window;
            this.ffmpegMediaFormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ffmpegMediaFormatBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ffmpegMediaFormatBox.FormattingEnabled = true;
            this.ffmpegMediaFormatBox.Items.AddRange(new object[] {
            resources.GetString("ffmpegMediaFormatBox.Items"),
            resources.GetString("ffmpegMediaFormatBox.Items1"),
            resources.GetString("ffmpegMediaFormatBox.Items2"),
            resources.GetString("ffmpegMediaFormatBox.Items3"),
            resources.GetString("ffmpegMediaFormatBox.Items4")});
            resources.ApplyResources(this.ffmpegMediaFormatBox, "ffmpegMediaFormatBox");
            this.ffmpegMediaFormatBox.Name = "ffmpegMediaFormatBox";
            this.ffmpegMediaFormatBox.SelectedIndexChanged += new System.EventHandler(this.ffmpegChooseFormatBoxChanged);
            // 
            // convetFileButton
            // 
            this.convetFileButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.convetFileButton, "convetFileButton");
            this.convetFileButton.Name = "convetFileButton";
            this.convetFileButton.UseVisualStyleBackColor = false;
            this.convetFileButton.Click += new System.EventHandler(this.convertFileFFmpegClick);
            // 
            // yourFileWillBeInLabel
            // 
            resources.ApplyResources(this.yourFileWillBeInLabel, "yourFileWillBeInLabel");
            this.yourFileWillBeInLabel.Name = "yourFileWillBeInLabel";
            // 
            // ffmpegTextBox
            // 
            resources.ApplyResources(this.ffmpegTextBox, "ffmpegTextBox");
            this.ffmpegTextBox.Name = "ffmpegTextBox";
            // 
            // ffmpegChooseFormatLabel
            // 
            resources.ApplyResources(this.ffmpegChooseFormatLabel, "ffmpegChooseFormatLabel");
            this.ffmpegChooseFormatLabel.Name = "ffmpegChooseFormatLabel";
            // 
            // defaultText
            // 
            resources.ApplyResources(this.defaultText, "defaultText");
            this.defaultText.Name = "defaultText";
            // 
            // switchToYoutubeButton
            // 
            this.switchToYoutubeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.switchToYoutubeButton, "switchToYoutubeButton");
            this.switchToYoutubeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.switchToYoutubeButton.Name = "switchToYoutubeButton";
            this.switchToYoutubeButton.UseVisualStyleBackColor = false;
            this.switchToYoutubeButton.Click += new System.EventHandler(this.changeToYTDownloaderClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.defaultResLbl);
            this.panel1.Controls.Add(this.folderChooseButton);
            this.panel1.Controls.Add(this.nameUrFile2);
            this.panel1.Controls.Add(this.fileNameBox2);
            this.panel1.Controls.Add(this.videoFormatLabel2);
            this.panel1.Controls.Add(this.ytDownloaderFormatBox);
            this.panel1.Controls.Add(this.videoLinkLabel);
            this.panel1.Controls.Add(this.videoLinkBox);
            this.panel1.Controls.Add(this.downloadVidButton);
            this.panel1.Controls.Add(this.switchToFFmpegButton);
            this.panel1.Controls.Add(this.ytVideoResLabel);
            this.panel1.Controls.Add(this.ytVideoResBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.moreStatsToggle);
            this.panel1.Controls.Add(this.defaultText2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // defaultResLbl
            // 
            resources.ApplyResources(this.defaultResLbl, "defaultResLbl");
            this.defaultResLbl.Name = "defaultResLbl";
            // 
            // folderChooseButton
            // 
            resources.ApplyResources(this.folderChooseButton, "folderChooseButton");
            this.folderChooseButton.Name = "folderChooseButton";
            this.folderChooseButton.UseVisualStyleBackColor = true;
            this.folderChooseButton.Click += new System.EventHandler(this.ytChooseDownloadDirButtonClick);
            // 
            // nameUrFile2
            // 
            resources.ApplyResources(this.nameUrFile2, "nameUrFile2");
            this.nameUrFile2.Name = "nameUrFile2";
            // 
            // fileNameBox2
            // 
            resources.ApplyResources(this.fileNameBox2, "fileNameBox2");
            this.fileNameBox2.Name = "fileNameBox2";
            // 
            // videoFormatLabel2
            // 
            resources.ApplyResources(this.videoFormatLabel2, "videoFormatLabel2");
            this.videoFormatLabel2.Name = "videoFormatLabel2";
            // 
            // ytDownloaderFormatBox
            // 
            this.ytDownloaderFormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ytDownloaderFormatBox.FormattingEnabled = true;
            this.ytDownloaderFormatBox.Items.AddRange(new object[] {
            resources.GetString("ytDownloaderFormatBox.Items"),
            resources.GetString("ytDownloaderFormatBox.Items1"),
            resources.GetString("ytDownloaderFormatBox.Items2"),
            resources.GetString("ytDownloaderFormatBox.Items3"),
            resources.GetString("ytDownloaderFormatBox.Items4"),
            resources.GetString("ytDownloaderFormatBox.Items5")});
            resources.ApplyResources(this.ytDownloaderFormatBox, "ytDownloaderFormatBox");
            this.ytDownloaderFormatBox.Name = "ytDownloaderFormatBox";
            this.ytDownloaderFormatBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // videoLinkLabel
            // 
            resources.ApplyResources(this.videoLinkLabel, "videoLinkLabel");
            this.videoLinkLabel.Name = "videoLinkLabel";
            // 
            // videoLinkBox
            // 
            resources.ApplyResources(this.videoLinkBox, "videoLinkBox");
            this.videoLinkBox.Name = "videoLinkBox";
            // 
            // downloadVidButton
            // 
            this.downloadVidButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.downloadVidButton, "downloadVidButton");
            this.downloadVidButton.Name = "downloadVidButton";
            this.downloadVidButton.UseVisualStyleBackColor = false;
            this.downloadVidButton.Click += new System.EventHandler(this.ytDownloadVideoButton);
            // 
            // switchToFFmpegButton
            // 
            this.switchToFFmpegButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.switchToFFmpegButton, "switchToFFmpegButton");
            this.switchToFFmpegButton.ForeColor = System.Drawing.SystemColors.Window;
            this.switchToFFmpegButton.Name = "switchToFFmpegButton";
            this.switchToFFmpegButton.UseVisualStyleBackColor = false;
            this.switchToFFmpegButton.Click += new System.EventHandler(this.switchToFFmpegClick);
            // 
            // ytVideoResLabel
            // 
            resources.ApplyResources(this.ytVideoResLabel, "ytVideoResLabel");
            this.ytVideoResLabel.Name = "ytVideoResLabel";
            // 
            // ytVideoResBox
            // 
            this.ytVideoResBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ytVideoResBox, "ytVideoResBox");
            this.ytVideoResBox.FormattingEnabled = true;
            this.ytVideoResBox.Items.AddRange(new object[] {
            resources.GetString("ytVideoResBox.Items"),
            resources.GetString("ytVideoResBox.Items1"),
            resources.GetString("ytVideoResBox.Items2"),
            resources.GetString("ytVideoResBox.Items3"),
            resources.GetString("ytVideoResBox.Items4"),
            resources.GetString("ytVideoResBox.Items5"),
            resources.GetString("ytVideoResBox.Items6")});
            this.ytVideoResBox.Name = "ytVideoResBox";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // moreStatsToggle
            // 
            resources.ApplyResources(this.moreStatsToggle, "moreStatsToggle");
            this.moreStatsToggle.Name = "moreStatsToggle";
            this.moreStatsToggle.UseVisualStyleBackColor = true;
            this.moreStatsToggle.CheckedChanged += new System.EventHandler(this.moreStatsTickChanged);
            // 
            // defaultText2
            // 
            resources.ApplyResources(this.defaultText2, "defaultText2");
            this.defaultText2.Name = "defaultText2";
            // 
            // ffmpegGoToFileButton
            // 
            resources.ApplyResources(this.ffmpegGoToFileButton, "ffmpegGoToFileButton");
            this.ffmpegGoToFileButton.Name = "ffmpegGoToFileButton";
            this.ffmpegGoToFileButton.UseVisualStyleBackColor = true;
            this.ffmpegGoToFileButton.Click += new System.EventHandler(this.goToFileClick);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // fileChosenLabel
            // 
            resources.ApplyResources(this.fileChosenLabel, "fileChosenLabel");
            this.fileChosenLabel.Name = "fileChosenLabel";
            // 
            // FFmpegotron
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.switchToYoutubeButton);
            this.Controls.Add(this.ffmpegGoToFileButton);
            this.Controls.Add(this.defaultText);
            this.Controls.Add(this.ffmpegChooseFormatLabel);
            this.Controls.Add(this.ffmpegTextBox);
            this.Controls.Add(this.yourFileWillBeInLabel);
            this.Controls.Add(this.convetFileButton);
            this.Controls.Add(this.ffmpegMediaFormatBox);
            this.Controls.Add(this.ffmpegChooseFileButton);
            this.Controls.Add(this.fileChosenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FFmpegotron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ffmpegChooseFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox ffmpegMediaFormatBox;
        private System.Windows.Forms.Button convetFileButton;
        private System.Windows.Forms.Label yourFileWillBeInLabel;
        private System.Windows.Forms.TextBox ffmpegTextBox;
        private System.Windows.Forms.Label ffmpegChooseFormatLabel;
        private System.Windows.Forms.Label defaultText;
        private System.Windows.Forms.Button switchToYoutubeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ffmpegGoToFileButton;
        private System.Windows.Forms.Button switchToFFmpegButton;
        private System.Windows.Forms.Button downloadVidButton;
        private System.Windows.Forms.Label videoLinkLabel;
        private System.Windows.Forms.TextBox videoLinkBox;
        private System.Windows.Forms.Label ytVideoResLabel;
        private System.Windows.Forms.ComboBox ytVideoResBox;
        private System.Windows.Forms.Label videoFormatLabel2;
        private System.Windows.Forms.ComboBox ytDownloaderFormatBox;
        private System.Windows.Forms.Label nameUrFile2;
        private System.Windows.Forms.TextBox fileNameBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label defaultText2;
        private System.Windows.Forms.Button folderChooseButton;
        private System.Windows.Forms.Label fileChosenLabel;
        private System.Windows.Forms.Label defaultResLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox moreStatsToggle;
        //private Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog folderDialog;
    }
}

