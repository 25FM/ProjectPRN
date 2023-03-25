using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchMovie
{
    public partial class WatchMovie : Form
    {
        public WatchMovie()
        {
            InitializeComponent();
        }


        OpenFileDialog openFileDialog;
        string[] filePaths;
        string[] fileNames;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files (*.mp4;*.mov;*.avi;*.mkv)|*.mp4;*.mov;*.avi;*.mkv|All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames; //lấy đường dẫn
                fileNames = openFileDialog.SafeFileNames; // lấy tên file
                foreach (var item in fileNames)
                {
                    this.listBox1.Items.Add(item);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int choice = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = filePaths[choice];
                this.textBox1.Text = fileNames[choice];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
