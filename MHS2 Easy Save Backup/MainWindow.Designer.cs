
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
            this.RemoteLabel = new System.Windows.Forms.Label();
            this.BackupLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BackupNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnableEditCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ChooseRemoteFolderBtn
            // 
            this.ChooseRemoteFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseRemoteFolderBtn.Location = new System.Drawing.Point(409, 30);
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
            this.BackupBtn.Location = new System.Drawing.Point(193, 112);
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
            this.RemoteFolderTxtBox.Location = new System.Drawing.Point(12, 30);
            this.RemoteFolderTxtBox.Name = "RemoteFolderTxtBox";
            this.RemoteFolderTxtBox.Size = new System.Drawing.Size(391, 26);
            this.RemoteFolderTxtBox.TabIndex = 2;
            // 
            // BackupFolderTxtBox
            // 
            this.BackupFolderTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupFolderTxtBox.Location = new System.Drawing.Point(12, 80);
            this.BackupFolderTxtBox.Name = "BackupFolderTxtBox";
            this.BackupFolderTxtBox.Size = new System.Drawing.Size(391, 26);
            this.BackupFolderTxtBox.TabIndex = 3;
            // 
            // ChooseBackupFolderBtn
            // 
            this.ChooseBackupFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseBackupFolderBtn.Location = new System.Drawing.Point(409, 80);
            this.ChooseBackupFolderBtn.Name = "ChooseBackupFolderBtn";
            this.ChooseBackupFolderBtn.Size = new System.Drawing.Size(75, 26);
            this.ChooseBackupFolderBtn.TabIndex = 4;
            this.ChooseBackupFolderBtn.Text = "Choose";
            this.ChooseBackupFolderBtn.UseVisualStyleBackColor = true;
            this.ChooseBackupFolderBtn.Click += new System.EventHandler(this.ChooseBackupFolderBtn_Click);
            // 
            // RemoteLabel
            // 
            this.RemoteLabel.AutoSize = true;
            this.RemoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoteLabel.Location = new System.Drawing.Point(9, 9);
            this.RemoteLabel.Name = "RemoteLabel";
            this.RemoteLabel.Size = new System.Drawing.Size(145, 18);
            this.RemoteLabel.TabIndex = 5;
            this.RemoteLabel.Text = "Remote Folder Path:";
            // 
            // BackupLabel
            // 
            this.BackupLabel.AutoSize = true;
            this.BackupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupLabel.Location = new System.Drawing.Point(9, 59);
            this.BackupLabel.Name = "BackupLabel";
            this.BackupLabel.Size = new System.Drawing.Size(142, 18);
            this.BackupLabel.TabIndex = 6;
            this.BackupLabel.Text = "Backup Folder Path:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(306, 118);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 24);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Done!";
            this.StatusLabel.Visible = false;
            // 
            // BackupNumberTxtBox
            // 
            this.BackupNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupNumberTxtBox.Location = new System.Drawing.Point(109, 128);
            this.BackupNumberTxtBox.Name = "BackupNumberTxtBox";
            this.BackupNumberTxtBox.ReadOnly = true;
            this.BackupNumberTxtBox.Size = new System.Drawing.Size(41, 21);
            this.BackupNumberTxtBox.TabIndex = 8;
            this.BackupNumberTxtBox.Leave += new System.EventHandler(this.BackupNumberTxtBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Backup Number:";
            // 
            // EnableEditCheckBox
            // 
            this.EnableEditCheckBox.AutoSize = true;
            this.EnableEditCheckBox.Location = new System.Drawing.Point(13, 112);
            this.EnableEditCheckBox.Name = "EnableEditCheckBox";
            this.EnableEditCheckBox.Size = new System.Drawing.Size(80, 17);
            this.EnableEditCheckBox.TabIndex = 10;
            this.EnableEditCheckBox.Text = "Enable Edit";
            this.EnableEditCheckBox.UseVisualStyleBackColor = true;
            this.EnableEditCheckBox.CheckedChanged += new System.EventHandler(this.EnableEditCheckBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 152);
            this.Controls.Add(this.EnableEditCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackupNumberTxtBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BackupLabel);
            this.Controls.Add(this.RemoteLabel);
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
        private System.Windows.Forms.Label RemoteLabel;
        private System.Windows.Forms.Label BackupLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox BackupNumberTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox EnableEditCheckBox;
    }
}

