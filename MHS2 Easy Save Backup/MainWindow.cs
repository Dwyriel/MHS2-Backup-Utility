using System;
using System.Windows.Forms;

namespace MHS2_Easy_Save_Backup
{
    public partial class MainWindow : Form
    {
        Timer timer = null;

        #region Constructor:
        public MainWindow()
        {
            SetStartAttributes();
            InitializeComponent();
            GetValuesFromCache();
        }
        #endregion

        #region Methods:
        private void SetStartAttributes()
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Icon = Properties.Resources.Icon;
        }

        private void GetValuesFromCache()
        {
            BackupController.LoadCache();
            if (BackupController.remoteFolderPath != null && BackupController.remoteFolderPath != "")
                RemoteFolderTxtBox.Text = BackupController.remoteFolderPath;
            if (BackupController.backupFolderPath != null && BackupController.backupFolderPath != "")
                BackupFolderTxtBox.Text = BackupController.backupFolderPath;
            BackupNumberTxtBox.Text = BackupController.backupNumber.ToString();
        }

        private void HideStatusLabel()
        {
            if (timer is null)
            {
                timer = new Timer();
                timer.Tick += Timer_Tick;
            }
            if (timer.Enabled)
                timer.Stop();
            timer.Interval = 5000;
            timer.Start();
        }
        #endregion

        #region Events:
        private void Timer_Tick(object sender, EventArgs e)
        {
            StatusLabel.Visible = false;
            timer.Stop();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            StatusLabel.Visible = BackupController.Backup(RemoteFolderTxtBox.Text, BackupFolderTxtBox.Text);
            BackupNumberTxtBox.Text = BackupController.backupNumber.ToString();
            HideStatusLabel();
        }

        private void ChooseRemoteFolderBtn_Click(object sender, EventArgs e)
        {
            string path = BackupController.SelectAndSaveRemoteFolder();
            if (path is null)
                return;
            RemoteFolderTxtBox.Text = path;
        }

        private void ChooseBackupFolderBtn_Click(object sender, EventArgs e)
        {
            string path = BackupController.SelectAndSaveBackupFolder();
            if (path is null)
                return;
            BackupFolderTxtBox.Text = path;
        }
        #endregion

        private void EnableEditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BackupNumberTxtBox.ReadOnly = !EnableEditCheckBox.Checked;
        }

        private void BackupNumberTxtBox_Leave(object sender, EventArgs e)
        {
            if (BackupNumberTxtBox.ReadOnly)
                return;
            if (uint.TryParse(BackupNumberTxtBox.Text, out uint backupNumber))
            {
                BackupController.backupNumber = backupNumber;
                return;
            }
            ErrorLog.ShowErrorText("Backup Number must be a positive number");
            BackupNumberTxtBox.Focus();

        }
    }
}
