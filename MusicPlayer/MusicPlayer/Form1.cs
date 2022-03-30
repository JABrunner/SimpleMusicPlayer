using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //Variables to Save name of Track and paths
        String[] paths, files;

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            //Select Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Select Multiple files at once
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save names of tracks in files array
                paths = ofd.FileNames; //Save track paths in path array

                for(int i=0; i < files.Length; i++)
                {
                    MusicListBox.Items.Add(files[i]);
                }
            }
        }

        private void MusicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Play Music when clicked
            axWindowsMediaPlayerMusic.URL = paths[MusicListBox.SelectedIndex];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close App
            this.Close();
        }
    }
}
