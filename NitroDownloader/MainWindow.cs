using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace NitroDownloader
{
    public partial class MainWindow : Form
    {

        #region Init
        //Directory on file open dialogs
        string acc_path = "";
        string previousPath = "";

        //NitroPath for application.
        string nitroPath = Directory.GetCurrentDirectory();

        //Needed public variables.
        string downloadedFileName = "";
        string fileName = "";
        string filePath = "";


        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }


        //Download Mp3
        private void mp3Button_Click(object sender, EventArgs e)
        {

           try
           {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(urlBox.Text) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();



                //Get where user will save file.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.InitialDirectory = previousPath;
                saveFileDialog1.Title = "Export File";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.Filter = "Mpeg3 Audio| *.mp3|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;


                //If OK.
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //Get previously opened path.
                    previousPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    acc_path = saveFileDialog1.FileName;

                    //Download MPEG3
                    string args = "--extract-audio --audio-format mp3 " + urlBox.Text;
                    Process p = new Process();
                    p.StartInfo.FileName = "\"" + nitroPath + "\\Tools\\youtube-dl.exe\"";
                    p.StartInfo.Arguments = args;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Directory.SetCurrentDirectory(nitroPath + "\\Tools");
                    p.Start();
                    p.WaitForExit();

                    //Rename the file to something managable.
                    downloadedFileName = Directory.GetFiles(nitroPath + "\\Tools", "*.mp3")[0];
                    File.Copy(downloadedFileName, "temp.mp3", true);
                    File.Delete(downloadedFileName);
                    Directory.SetCurrentDirectory(nitroPath);

                    //Now enter properties mode.
                    mp3Button.Enabled = false;
                    mp4Button.Enabled = false;
                    urlBox.Enabled = false;
                    urlLabel.Enabled = false;
                    setButton.Enabled = true;
                    skipButton.Enabled = true;
                    artistPropertiesBox.Enabled = true;
                    nullifyPropertiesBox.Enabled = true;
                    fileNameLabel.Enabled = true;
                    fileNameBox.Enabled = true;
                    titleLabel.Enabled = true;
                    titleBox.Enabled = true;
                    artistLabel.Enabled = true;
                    artistBox.Enabled = true;

                    //Set filename.
                    fileName = saveFileDialog1.FileName;
                    filePath = Path.GetDirectoryName(fileName);
                    fileName = Path.GetFileName(fileName);
                    fileNameBox.Text = fileName;


                    //The properties buttons will take care of the rest of the work.
                }


            }
            catch
            {
                //Error time.
                System.Windows.Forms.MessageBox.Show("Video is invalid or doesn't exist!", "Error!");
            }

        }

        //Get and set artists properties.
        private void artistPropertiesBox_CheckedChanged(object sender, EventArgs e)
        {
            if (artistPropertiesBox.Checked)
            {

                contribArtistsBox.Enabled = false;
                contribArtistsLabel.Enabled = false;

            }
            else {

                contribArtistsBox.Enabled = true;
                contribArtistsLabel.Enabled = true;

            }
        }

        private void nullifyPropertiesBox_CheckedChanged(object sender, EventArgs e)
        {

            if (nullifyPropertiesBox.Checked)
            {

                yearBox.Enabled = false;
                yearLabel.Enabled = false;
                genreBox.Enabled = false;
                genreLabel.Enabled = false;

            }
            else {

                yearBox.Enabled = true;
                yearLabel.Enabled = true;
                genreBox.Enabled = true;
                genreLabel.Enabled = true;

            }

        }

        //For not bothering to set properties
        private void skipButton_Click(object sender, EventArgs e)
        {

            //Move the file.
            File.Copy(nitroPath + "\\Tools\\temp.mp3", filePath + "\\" + fileName, true);
            File.Delete(nitroPath + "\\Tools\\temp.mp3");

            //Reset the downloader.
            mp3Button.Enabled = true;
            mp4Button.Enabled = true;
            urlBox.Enabled = true;
            urlLabel.Enabled = true;
            yearBox.Enabled = false;
            yearLabel.Enabled = false;
            genreBox.Enabled = false;
            genreLabel.Enabled = false;
            contribArtistsBox.Enabled = false;
            contribArtistsLabel.Enabled = false;
            setButton.Enabled = false;
            skipButton.Enabled = false;
            artistPropertiesBox.Enabled = false;
            nullifyPropertiesBox.Enabled = false;
            fileNameLabel.Enabled = false;
            fileNameBox.Enabled = false;
            titleLabel.Enabled = false;
            titleBox.Enabled = false;
            artistLabel.Enabled = false;
            artistBox.Enabled = false;

        }

        private void mp4Button_Click(object sender, EventArgs e)
        {

            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(urlBox.Text) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();



                //Get where user will save file.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.InitialDirectory = previousPath;
                saveFileDialog1.Title = "Export File";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.Filter = "Mpeg4 Video| *.mp4|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;


                //If OK.
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //Get previously opened path.
                    previousPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    acc_path = saveFileDialog1.FileName;

                    //Download WEBM
                    string args = "-f bestvideo+bestaudio " + urlBox.Text;
                    Process p = new Process();
                    p.StartInfo.FileName = "\"" + nitroPath + "\\Tools\\youtube-dl.exe\"";
                    p.StartInfo.Arguments = args;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Directory.SetCurrentDirectory(nitroPath + "\\Tools");
                    p.Start();
                    p.WaitForExit();

                    //Rename the file to something managable.
                    downloadedFileName = Directory.GetFiles(nitroPath + "\\Tools", "*.webm")[0];
                    File.Copy(downloadedFileName, "temp.webm", true);
                    File.Delete(downloadedFileName);

                    //Convert MPEG4
                    string args2 = "-i temp.webm -qscale 0 temp.mp4";
                    Process p2 = new Process();
                    p2.StartInfo.FileName = "\"" + nitroPath + "\\Tools\\ffmpeg.exe\"";
                    p2.StartInfo.Arguments = args2;
                    p2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Directory.SetCurrentDirectory(nitroPath + "\\Tools");
                    p2.Start();
                    p2.WaitForExit();

                    //Delete WebM
                    File.Delete("temp.webm");
                    Directory.SetCurrentDirectory(nitroPath);
                    

                    //Set filename.
                    fileName = saveFileDialog1.FileName;

                    //Move the file.
                    File.Copy(nitroPath + "\\Tools\\temp.mp4", fileName, true);
                    File.Delete(nitroPath + "\\Tools\\temp.mp4");

                    //The properties buttons will take care of the rest of the work.
                }


            }
            catch
            {
                //Error time.
                System.Windows.Forms.MessageBox.Show("Video is invalid or doesn't exist!", "Error!");
            }

        }


        //Set the properties. ID3 NOT WORKING????
        private void setButton_Click(object sender, EventArgs e)
        {

            //Set current directory.
            Directory.SetCurrentDirectory(nitroPath + "\\Tools");

            //Delete mp3 tags.
            string args2 = "-2 -1 -u " + "temp.mp3";
            Process p2 = new Process();
            p2.StartInfo.FileName = "id3.exe";
            p2.StartInfo.Arguments = args2;
            p2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p2.Start();
            p2.WaitForExit();

            //Get the data.
            string newFileName = fileNameBox.Text;
            string title = titleBox.Text;
            string artist = artistBox.Text;
            string contribArtists = contribArtistsBox.Text;
            string albumArtist = artistBox.Text;
            string genre = genreBox.Text;
            int year = (int)yearBox.Value;
            bool setGenreAndYear = true;

            if (artistPropertiesBox.Checked) {

                albumArtist = artist;
                contribArtists = artist;

            }

            if (nullifyPropertiesBox.Checked) {

                setGenreAndYear = false;

            }

            //Now set the actual properties.
            string args = "--title \"" + title + "\" --artist \"" + artist + "\" --album \"" + albumArtist + "\"";
            if (setGenreAndYear) { args += " --genre \"" + genre + "\" --year \"" + year + "\""; }
            args += " temp.mp3";

            Process p = new Process();
            p.StartInfo.FileName = "id3.exe";
            p.StartInfo.Arguments = args;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();



            //Apply album artist.
            string args3 = "-o ";

            Process p3 = new Process();
            p3.StartInfo.FileName = "youtube-dl.exe";
            p3.StartInfo.Arguments = args3;
            p3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p3.Start();
            p3.WaitForExit();


            //Set filename.
            if (newFileName != "") { if (fileName.EndsWith(".mp3")) { fileName = newFileName; } else { fileName = newFileName + ".mp3"; } }

        }
    }
}
