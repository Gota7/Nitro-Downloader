namespace NitroDownloader
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.mp3Button = new System.Windows.Forms.Button();
            this.mp4Button = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.artistPropertiesBox = new System.Windows.Forms.CheckBox();
            this.nullifyPropertiesBox = new System.Windows.Forms.CheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.contribArtistsBox = new System.Windows.Forms.TextBox();
            this.contribArtistsLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.NumericUpDown();
            this.genreBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).BeginInit();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urlBox.Location = new System.Drawing.Point(123, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(285, 20);
            this.urlBox.TabIndex = 1;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(40, 15);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(62, 13);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "Video URL:";
            // 
            // mp3Button
            // 
            this.mp3Button.Location = new System.Drawing.Point(12, 38);
            this.mp3Button.Name = "mp3Button";
            this.mp3Button.Size = new System.Drawing.Size(191, 23);
            this.mp3Button.TabIndex = 3;
            this.mp3Button.Text = "Download Mp3";
            this.mp3Button.UseVisualStyleBackColor = true;
            this.mp3Button.Click += new System.EventHandler(this.mp3Button_Click);
            // 
            // mp4Button
            // 
            this.mp4Button.Location = new System.Drawing.Point(209, 38);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(199, 23);
            this.mp4Button.TabIndex = 4;
            this.mp4Button.Text = "Download Mp4";
            this.mp4Button.UseVisualStyleBackColor = true;
            this.mp4Button.Click += new System.EventHandler(this.mp4Button_Click);
            // 
            // setButton
            // 
            this.setButton.Enabled = false;
            this.setButton.Location = new System.Drawing.Point(35, 246);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(145, 23);
            this.setButton.TabIndex = 5;
            this.setButton.Text = "Set Propeties";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Enabled = false;
            this.skipButton.Location = new System.Drawing.Point(240, 246);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(145, 23);
            this.skipButton.TabIndex = 6;
            this.skipButton.Text = "Finalize";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Enabled = false;
            this.fileNameLabel.Location = new System.Drawing.Point(45, 93);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fileNameLabel.TabIndex = 7;
            this.fileNameLabel.Text = "File Name:";
            // 
            // fileNameBox
            // 
            this.fileNameBox.Enabled = false;
            this.fileNameBox.Location = new System.Drawing.Point(123, 90);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(285, 20);
            this.fileNameBox.TabIndex = 8;
            // 
            // artistPropertiesBox
            // 
            this.artistPropertiesBox.AutoSize = true;
            this.artistPropertiesBox.Checked = true;
            this.artistPropertiesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.artistPropertiesBox.Enabled = false;
            this.artistPropertiesBox.Location = new System.Drawing.Point(25, 67);
            this.artistPropertiesBox.Name = "artistPropertiesBox";
            this.artistPropertiesBox.Size = new System.Drawing.Size(119, 17);
            this.artistPropertiesBox.TabIndex = 9;
            this.artistPropertiesBox.Text = "Link Artist Propeties";
            this.artistPropertiesBox.UseVisualStyleBackColor = true;
            this.artistPropertiesBox.CheckedChanged += new System.EventHandler(this.artistPropertiesBox_CheckedChanged);
            // 
            // nullifyPropertiesBox
            // 
            this.nullifyPropertiesBox.AutoSize = true;
            this.nullifyPropertiesBox.Checked = true;
            this.nullifyPropertiesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nullifyPropertiesBox.Enabled = false;
            this.nullifyPropertiesBox.Location = new System.Drawing.Point(229, 67);
            this.nullifyPropertiesBox.Name = "nullifyPropertiesBox";
            this.nullifyPropertiesBox.Size = new System.Drawing.Size(118, 17);
            this.nullifyPropertiesBox.TabIndex = 10;
            this.nullifyPropertiesBox.Text = "Nullify Other Values";
            this.nullifyPropertiesBox.UseVisualStyleBackColor = true;
            this.nullifyPropertiesBox.CheckedChanged += new System.EventHandler(this.nullifyPropertiesBox_CheckedChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Enabled = false;
            this.titleLabel.Location = new System.Drawing.Point(72, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.Enabled = false;
            this.titleBox.Location = new System.Drawing.Point(123, 116);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(285, 20);
            this.titleBox.TabIndex = 12;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Enabled = false;
            this.artistLabel.Location = new System.Drawing.Point(69, 145);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(33, 13);
            this.artistLabel.TabIndex = 13;
            this.artistLabel.Text = "Artist:";
            // 
            // artistBox
            // 
            this.artistBox.Enabled = false;
            this.artistBox.Location = new System.Drawing.Point(123, 142);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(285, 20);
            this.artistBox.TabIndex = 14;
            // 
            // contribArtistsBox
            // 
            this.contribArtistsBox.Enabled = false;
            this.contribArtistsBox.Location = new System.Drawing.Point(123, 168);
            this.contribArtistsBox.Name = "contribArtistsBox";
            this.contribArtistsBox.Size = new System.Drawing.Size(285, 20);
            this.contribArtistsBox.TabIndex = 15;
            // 
            // contribArtistsLabel
            // 
            this.contribArtistsLabel.AutoSize = true;
            this.contribArtistsLabel.Enabled = false;
            this.contribArtistsLabel.Location = new System.Drawing.Point(63, 171);
            this.contribArtistsLabel.Name = "contribArtistsLabel";
            this.contribArtistsLabel.Size = new System.Drawing.Size(39, 13);
            this.contribArtistsLabel.TabIndex = 18;
            this.contribArtistsLabel.Text = "Album:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Enabled = false;
            this.yearLabel.Location = new System.Drawing.Point(70, 196);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 19;
            this.yearLabel.Text = "Year:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Enabled = false;
            this.genreLabel.Location = new System.Drawing.Point(63, 222);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 20;
            this.genreLabel.Text = "Genre:";
            // 
            // yearBox
            // 
            this.yearBox.Enabled = false;
            this.yearBox.Location = new System.Drawing.Point(123, 194);
            this.yearBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(285, 20);
            this.yearBox.TabIndex = 21;
            // 
            // genreBox
            // 
            this.genreBox.Enabled = false;
            this.genreBox.Location = new System.Drawing.Point(125, 219);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(285, 20);
            this.genreBox.TabIndex = 22;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 276);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.contribArtistsLabel);
            this.Controls.Add(this.contribArtistsBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nullifyPropertiesBox);
            this.Controls.Add(this.artistPropertiesBox);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.mp4Button);
            this.Controls.Add(this.mp3Button);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Nitro Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button mp3Button;
        private System.Windows.Forms.Button mp4Button;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.CheckBox artistPropertiesBox;
        private System.Windows.Forms.CheckBox nullifyPropertiesBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.TextBox contribArtistsBox;
        private System.Windows.Forms.Label contribArtistsLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.NumericUpDown yearBox;
        private System.Windows.Forms.TextBox genreBox;
    }
}

