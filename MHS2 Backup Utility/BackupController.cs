using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MHS2_Backup_Utility
{
    public static class BackupController
    {
        public static string remoteFolderPath, backupFolderPath;
        public static ulong backupNumber;

        public static void LoadCache()
        {
            remoteFolderPath = Properties.Settings.Default.RemoteFolderPath;
            backupFolderPath = Properties.Settings.Default.BackupFolderPath;
            backupNumber = Properties.Settings.Default.BackupNumber;
        }

        public static void SaveCache(string remotePath = null, string backupPath = null)
        {
            remoteFolderPath = (remotePath is null) ? remoteFolderPath : remotePath;
            Properties.Settings.Default.RemoteFolderPath = remoteFolderPath;
            backupFolderPath = (backupPath is null) ? backupFolderPath : backupPath;
            Properties.Settings.Default.BackupFolderPath = backupFolderPath;
            Properties.Settings.Default.BackupNumber = backupNumber;
            Properties.Settings.Default.Save();
        }

        public static bool Backup(string remotePath, string backupPath)
        {
            Backup_Error_Type verification = VerifyPaths(remotePath, backupPath);
            if (verification != Backup_Error_Type.None)
            {
                DealWithPathError(verification);
                return false;
            }
            try
            {
                string newFolderPath = CreateNewFolder(backupPath);
                if (newFolderPath is null)
                    return false;
                if (!CopyFilesToFolder(remotePath, newFolderPath))
                    return false;
                SaveCache(remotePath, backupPath);
                return true;
            }
            catch (Exception exception)
            {
                ErrorLog.ShowErrorTextWithExceptionMessage("An error occurred while backing up save.", exception);
                return false;
            }
        }

        private static string CreateNewFolder(string backupPath)
        {
            DirectoryInfo dir = Directory.CreateDirectory(backupPath + @"\" + Strings.BackupFolderBaseName + (Properties.Settings.Default.useDate ? DateTime.Now.ToString().Replace("/", "-").Replace(":", ".") : backupNumber++.ToString()));
            return (dir is null || dir.FullName is null) ? null : dir.FullName;
        }

        private static bool CopyFilesToFolder(string remotePath, string backupPath)
        {
            if (CheckForSaveFiles(remotePath, out List<FileInfo> filesToSave))
            {
                foreach (FileInfo file in filesToSave)
                    File.Copy(file.FullName, backupPath + @"\" + file.Name);
                return true;
            }
            return false;
        }

        private static Backup_Error_Type VerifyPaths(string remotePath, string backupPath)
        {
            if (remotePath == "" || remotePath is null)
                return Backup_Error_Type.EmptyRemoteFolder;
            if (backupPath == "" || backupPath is null)
                return Backup_Error_Type.EmptyBackupFolder;
            if (!Directory.Exists(remotePath))
                return Backup_Error_Type.RemoteFolderDoesntExist;
            if (!Directory.Exists(backupPath))
                return Backup_Error_Type.BackupFolderDoesntExist;
            if (!CheckForSaveFiles(remotePath, out _))
                return Backup_Error_Type.NoSaveFilesOnRemoteFolder;
            if (SelectAndSaveRemoteFolder(remotePath) is null)
                return Backup_Error_Type.RemoteFolderDoesntExist;
            if (SelectAndSaveBackupFolder(backupPath) is null)
                return Backup_Error_Type.BackupFolderDoesntExist;
            return Backup_Error_Type.None;
        }

        private static void DealWithPathError(Backup_Error_Type error)
        {
            switch (error)
            {
                case Backup_Error_Type.EmptyRemoteFolder:
                    ErrorLog.ShowErrorText("Remote folder path can't be empty.");
                    break;
                case Backup_Error_Type.EmptyBackupFolder:
                    ErrorLog.ShowErrorText("Backup folder path can't be empty.");
                    break;
                case Backup_Error_Type.RemoteFolderDoesntExist:
                    ErrorLog.ShowErrorText("Remote folder doesn't exist or is invalid.");
                    break;
                case Backup_Error_Type.BackupFolderDoesntExist:
                    ErrorLog.ShowErrorText("Backup folder doesn't exist or is invalid.");
                    break;
                case Backup_Error_Type.NoSaveFilesOnRemoteFolder:
                    ErrorLog.ShowErrorText("No MHS2 save files found.");
                    break;
            }
        }

        public static string SelectAndSaveBackupFolder(string path = null)
        {
            try
            {
                if (path is null)
                    path = SelectFolderFromDialog("Select Backup Folder");
                if (path is null)
                    return null;
                backupFolderPath = path;
                Properties.Settings.Default.BackupFolderPath = backupFolderPath;
                Properties.Settings.Default.Save();
                return backupFolderPath;
            }
            catch (Exception expection)
            {
                ErrorLog.ShowErrorTextWithExceptionMessage(Strings.ErrorSelectFodler, expection);
                return null;
            }
        }

        public static string SelectAndSaveRemoteFolder(string path = null)
        {
            try
            {
                if (path is null)
                    path = SelectFolderFromDialog("Select Remote Folder");
                if (path is null)
                    return null;
                if (!CheckForSaveFiles(path, out _))
                {
                    MessageBox.Show("No MHS2 SaveFiles found on remote folder.");
                    return null;
                }
                remoteFolderPath = path;
                Properties.Settings.Default.RemoteFolderPath = remoteFolderPath;
                Properties.Settings.Default.Save();
                return remoteFolderPath;
            }
            catch (Exception expection)
            {
                ErrorLog.ShowErrorTextWithExceptionMessage(Strings.ErrorSelectFodler, expection);
                return null;
            }
        }

        private static string SelectFolderFromDialog(string title)
        {
            using (CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog())
            {
                commonOpenFileDialog.Title = title;
                commonOpenFileDialog.IsFolderPicker = true;
                CommonFileDialogResult dialogResult = commonOpenFileDialog.ShowDialog();
                return (dialogResult == CommonFileDialogResult.Ok) ? commonOpenFileDialog.FileName : null;
            }
        }

        private static bool CheckForSaveFiles(string remoteFolder, out List<FileInfo> filesToSave)
        {
            DirectoryInfo remote = new DirectoryInfo(remoteFolder);
            FileInfo[] files = remote.GetFiles();
            filesToSave = new List<FileInfo>();
            foreach (FileInfo file in files)
            {
                if (IsMHS2SaveFile(file.Name))
                    filesToSave.Add(file);
            }
            if (filesToSave.Count < 1)
                return false;
            return true;
        }

        private static bool IsMHS2SaveFile(string fileName)
        {
            foreach (string saveFileName in Strings.SaveStringsArray)
                if (fileName.Equals(saveFileName))
                    return true;
            return false;
        }
    }

    public enum Backup_Error_Type
    {
        None, EmptyRemoteFolder, EmptyBackupFolder, RemoteFolderDoesntExist, BackupFolderDoesntExist, NoSaveFilesOnRemoteFolder,
    }
}
