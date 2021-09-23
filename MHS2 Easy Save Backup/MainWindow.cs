using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MHS2_Easy_Save_Backup
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files (x86)\Steam\userdata\158163168\1277400\remote";
            string dest = @"C:\test\arq";
            string[] files = Directory.GetFiles(path);
            int i = 0;
            foreach (string file in files)
            {
                File.Copy(file, dest + (i++).ToString());
            }
        }

        private void ChooseRemoteFolderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.Title = "Select remote folder";
            openFileDialog.IsFolderPicker = true;
            openFileDialog.ShowDialog();
        }

        private void ChooseBackupFolderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
