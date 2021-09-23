
namespace MHS2_Easy_Save_Backup
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
            this.ChooseRemoteFolderBtn = new System.Windows.Forms.Button();
            this.BackupBtn = new System.Windows.Forms.Button();
            this.RemoteFolderTxtBox = new System.Windows.Forms.TextBox();
            this.BackupFolderTxtBox = new System.Windows.Forms.TextBox();
            this.ChooseBackupFolderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseRemoteFolderBtn
            // 
            this.ChooseRemoteFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseRemoteFolderBtn.Location = new System.Drawing.Point(409, 12);
            this.ChooseRemoteFolderBtn.Name = "ChooseRemoteFolderBtn";
            this.ChooseRemoteFolderBtn.Size = new System.Drawing.Size(75, 26);
            this.ChooseRemoteFolderBtn.TabIndex = 0;
            this.ChooseRemoteFolderBtn.Text = "Choose";
            this.ChooseRemoteFolderBtn.UseVisualStyleBackColor = true;
            this.ChooseRemoteFolderBtn.Click += new System.EventHandler(this.ChooseRemoteFolderBtn_Click);
            // 
            // BackupBtn
            // 
            this.BackupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupBtn.Location = new System.Drawing.Point(196, 76);
            this.BackupBtn.Name = "BackupBtn";
            this.BackupBtn.Size = new System.Drawing.Size(107, 35);
            this.BackupBtn.TabIndex = 1;
            this.BackupBtn.Text = "Backup!";
            this.BackupBtn.UseVisualStyleBackColor = true;
            this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // RemoteFolderTxtBox
            // 
            this.RemoteFolderTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoteFolderTxtBox.Location = new System.Drawing.Point(12, 12);
            this.RemoteFolderTxtBox.Name = "RemoteFolderTxtBox";
            this.RemoteFolderTxtBox.Size = new System.Drawing.Size(391, 26);
            this.RemoteFolderTxtBox.TabIndex = 2;
            // 
            // BackupFolderTxtBox
            // 
            this.BackupFolderTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupFolderTxtBox.Location = new System.Drawing.Point(12, 44);
            this.BackupFolderTxtBox.Name = "BackupFolderTxtBox";
            this.BackupFolderTxtBox.Size = new System.Drawing.Size(391, 26);
            this.BackupFolderTxtBox.TabIndex = 3;
            // 
            // ChooseBackupFolderBtn
            // 
            this.ChooseBackupFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseBackupFolderBtn.Location = new System.Drawing.Point(409, 44);
            this.ChooseBackupFolderBtn.Name = "ChooseBackupFolderBtn";
            this.ChooseBackupFolderBtn.Size = new System.Drawing.Size(75, 26);
            this.ChooseBackupFolderBtn.TabIndex = 4;
            this.ChooseBackupFolderBtn.Text = "Choose";
            this.ChooseBackupFolderBtn.UseVisualStyleBackColor = true;
            this.ChooseBackupFolderBtn.Click += new System.EventHandler(this.ChooseBackupFolderBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 117);
            this.Controls.Add(this.ChooseBackupFolderBtn);
            this.Controls.Add(this.BackupFolderTxtBox);
            this.Controls.Add(this.RemoteFolderTxtBox);
            this.Controls.Add(this.BackupBtn);
            this.Controls.Add(this.ChooseRemoteFolderBtn);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseRemoteFolderBtn;
        private System.Windows.Forms.Button BackupBtn;
        private System.Windows.Forms.TextBox RemoteFolderTxtBox;
        private System.Windows.Forms.TextBox BackupFolderTxtBox;
        private System.Windows.Forms.Button ChooseBackupFolderBtn;
    }
}

