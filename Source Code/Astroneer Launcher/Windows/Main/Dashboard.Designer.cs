namespace Astroneer_Launcher.Windows.Main
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Play = new System.Windows.Forms.PictureBox();
            this.Button_ManageBackups = new System.Windows.Forms.PictureBox();
            this.Button_OpenSettings = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.AstroVersion = new System.Windows.Forms.Label();
            this.buildversion = new System.Windows.Forms.RichTextBox();
            this.CheckForUpdates = new System.Windows.Forms.LinkLabel();
            this.CheckIfGameRunning = new System.Windows.Forms.Timer(this.components);
            this.ManageBackups = new System.Windows.Forms.Panel();
            this.Button_ViewSavesFolder = new System.Windows.Forms.PictureBox();
            this.Button_ViewBackups = new System.Windows.Forms.PictureBox();
            this.Button_BackupSavesButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DoBackup = new System.ComponentModel.BackgroundWorker();
            this.DoBackupManual = new System.ComponentModel.BackgroundWorker();
            this.LoadingIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ManageBackups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_OpenSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.ManageBackups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewSavesFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewBackups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_BackupSavesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Astroneer_Launcher.Properties.Resources.AstroLogoText;
            this.pictureBox1.Location = new System.Drawing.Point(17, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Play
            // 
            this.Button_Play.BackColor = System.Drawing.Color.Transparent;
            this.Button_Play.Image = global::Astroneer_Launcher.Properties.Resources.Button_PlayGame;
            this.Button_Play.Location = new System.Drawing.Point(12, 159);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(290, 39);
            this.Button_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Play.TabIndex = 1;
            this.Button_Play.TabStop = false;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            this.Button_Play.MouseEnter += new System.EventHandler(this.Button_Play_MouseEnter);
            this.Button_Play.MouseLeave += new System.EventHandler(this.Button_Play_MouseLeave);
            // 
            // Button_ManageBackups
            // 
            this.Button_ManageBackups.BackColor = System.Drawing.Color.Transparent;
            this.Button_ManageBackups.Image = global::Astroneer_Launcher.Properties.Resources.Button_ManageBackups;
            this.Button_ManageBackups.Location = new System.Drawing.Point(12, 200);
            this.Button_ManageBackups.Name = "Button_ManageBackups";
            this.Button_ManageBackups.Size = new System.Drawing.Size(290, 39);
            this.Button_ManageBackups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_ManageBackups.TabIndex = 2;
            this.Button_ManageBackups.TabStop = false;
            this.Button_ManageBackups.Click += new System.EventHandler(this.Button_ManageBackups_Click);
            this.Button_ManageBackups.MouseEnter += new System.EventHandler(this.Button_ManageBackups_MouseEnter);
            this.Button_ManageBackups.MouseLeave += new System.EventHandler(this.Button_ManageBackups_MouseLeave);
            // 
            // Button_OpenSettings
            // 
            this.Button_OpenSettings.BackColor = System.Drawing.Color.Transparent;
            this.Button_OpenSettings.Image = global::Astroneer_Launcher.Properties.Resources.Button_Preferences;
            this.Button_OpenSettings.Location = new System.Drawing.Point(12, 241);
            this.Button_OpenSettings.Name = "Button_OpenSettings";
            this.Button_OpenSettings.Size = new System.Drawing.Size(290, 39);
            this.Button_OpenSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_OpenSettings.TabIndex = 3;
            this.Button_OpenSettings.TabStop = false;
            this.Button_OpenSettings.Click += new System.EventHandler(this.Button_OpenSettings_Click);
            this.Button_OpenSettings.MouseEnter += new System.EventHandler(this.Button_OpenSettings_MouseEnter);
            this.Button_OpenSettings.MouseLeave += new System.EventHandler(this.Button_OpenSettings_MouseLeave);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Image = global::Astroneer_Launcher.Properties.Resources.Button_Exit;
            this.Button_Exit.Location = new System.Drawing.Point(12, 282);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(290, 39);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            this.Button_Exit.MouseEnter += new System.EventHandler(this.Button_Exit_MouseEnter);
            this.Button_Exit.MouseLeave += new System.EventHandler(this.Button_Exit_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Astroneer_Launcher.Properties.Resources.RWE_Labs_White;
            this.pictureBox6.Location = new System.Drawing.Point(725, 368);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Version.Location = new System.Drawing.Point(124, 393);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(93, 26);
            this.Version.TabIndex = 6;
            this.Version.Text = "Launcher Version:\r\nv220000";
            // 
            // AstroVersion
            // 
            this.AstroVersion.AutoSize = true;
            this.AstroVersion.BackColor = System.Drawing.Color.Transparent;
            this.AstroVersion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AstroVersion.Location = new System.Drawing.Point(12, 393);
            this.AstroVersion.Name = "AstroVersion";
            this.AstroVersion.Size = new System.Drawing.Size(93, 13);
            this.AstroVersion.TabIndex = 7;
            this.AstroVersion.Text = "Astroneer Version:";
            // 
            // buildversion
            // 
            this.buildversion.Location = new System.Drawing.Point(736, 127);
            this.buildversion.Name = "buildversion";
            this.buildversion.Size = new System.Drawing.Size(52, 15);
            this.buildversion.TabIndex = 8;
            this.buildversion.Text = "";
            this.buildversion.Visible = false;
            // 
            // CheckForUpdates
            // 
            this.CheckForUpdates.ActiveLinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.BackColor = System.Drawing.Color.Transparent;
            this.CheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.CheckForUpdates.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CheckForUpdates.LinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.Location = new System.Drawing.Point(124, 422);
            this.CheckForUpdates.Name = "CheckForUpdates";
            this.CheckForUpdates.Size = new System.Drawing.Size(150, 23);
            this.CheckForUpdates.TabIndex = 9;
            this.CheckForUpdates.TabStop = true;
            this.CheckForUpdates.Text = "Check for Updates";
            this.CheckForUpdates.VisitedLinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckForUpdates_LinkClicked);
            // 
            // CheckIfGameRunning
            // 
            this.CheckIfGameRunning.Interval = 4750;
            this.CheckIfGameRunning.Tick += new System.EventHandler(this.CheckIfGameRunning_Tick);
            // 
            // ManageBackups
            // 
            this.ManageBackups.BackColor = System.Drawing.Color.Transparent;
            this.ManageBackups.Controls.Add(this.Button_ViewSavesFolder);
            this.ManageBackups.Controls.Add(this.Button_ViewBackups);
            this.ManageBackups.Controls.Add(this.Button_BackupSavesButton);
            this.ManageBackups.Controls.Add(this.pictureBox2);
            this.ManageBackups.Location = new System.Drawing.Point(190, 200);
            this.ManageBackups.Name = "ManageBackups";
            this.ManageBackups.Size = new System.Drawing.Size(310, 133);
            this.ManageBackups.TabIndex = 10;
            this.ManageBackups.Visible = false;
            // 
            // Button_ViewSavesFolder
            // 
            this.Button_ViewSavesFolder.BackColor = System.Drawing.Color.Transparent;
            this.Button_ViewSavesFolder.Image = global::Astroneer_Launcher.Properties.Resources.Button_OpenSavesFolder;
            this.Button_ViewSavesFolder.Location = new System.Drawing.Point(11, 83);
            this.Button_ViewSavesFolder.Name = "Button_ViewSavesFolder";
            this.Button_ViewSavesFolder.Size = new System.Drawing.Size(290, 39);
            this.Button_ViewSavesFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_ViewSavesFolder.TabIndex = 13;
            this.Button_ViewSavesFolder.TabStop = false;
            this.Button_ViewSavesFolder.Click += new System.EventHandler(this.Button_ViewSavesFolder_Click);
            this.Button_ViewSavesFolder.MouseEnter += new System.EventHandler(this.Button_ViewSavesFolder_MouseEnter);
            this.Button_ViewSavesFolder.MouseLeave += new System.EventHandler(this.Button_ViewSavesFolder_MouseLeave);
            // 
            // Button_ViewBackups
            // 
            this.Button_ViewBackups.BackColor = System.Drawing.Color.Transparent;
            this.Button_ViewBackups.Image = global::Astroneer_Launcher.Properties.Resources.Button_ViewBackups;
            this.Button_ViewBackups.Location = new System.Drawing.Point(11, 42);
            this.Button_ViewBackups.Name = "Button_ViewBackups";
            this.Button_ViewBackups.Size = new System.Drawing.Size(290, 39);
            this.Button_ViewBackups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_ViewBackups.TabIndex = 12;
            this.Button_ViewBackups.TabStop = false;
            this.Button_ViewBackups.Click += new System.EventHandler(this.Button_ViewBackups_Click);
            this.Button_ViewBackups.MouseEnter += new System.EventHandler(this.Button_ViewBackups_MouseEnter);
            this.Button_ViewBackups.MouseLeave += new System.EventHandler(this.Button_ViewBackups_MouseLeave);
            // 
            // Button_BackupSavesButton
            // 
            this.Button_BackupSavesButton.BackColor = System.Drawing.Color.Transparent;
            this.Button_BackupSavesButton.Image = global::Astroneer_Launcher.Properties.Resources.Button_BackUpSaves;
            this.Button_BackupSavesButton.Location = new System.Drawing.Point(11, 1);
            this.Button_BackupSavesButton.Name = "Button_BackupSavesButton";
            this.Button_BackupSavesButton.Size = new System.Drawing.Size(290, 39);
            this.Button_BackupSavesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_BackupSavesButton.TabIndex = 11;
            this.Button_BackupSavesButton.TabStop = false;
            this.Button_BackupSavesButton.Click += new System.EventHandler(this.Button_BackupSavesButton_Click);
            this.Button_BackupSavesButton.MouseEnter += new System.EventHandler(this.Button_BackupSaves_MouseEnter);
            this.Button_BackupSavesButton.MouseLeave += new System.EventHandler(this.Button_BackupSavesButton_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Astroneer_Launcher.Properties.Resources.WhiteLine;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // DoBackup
            // 
            this.DoBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoBackup_DoWork);
            this.DoBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DoBackup_RunWorkerCompleted);
            // 
            // DoBackupManual
            // 
            this.DoBackupManual.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoBackupManual_DoWork);
            this.DoBackupManual.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DoBackupManual_RunWorkerCompleted);
            // 
            // LoadingIndicator
            // 
            this.LoadingIndicator.BackColor = System.Drawing.Color.Transparent;
            this.LoadingIndicator.Image = global::Astroneer_Launcher.Properties.Resources.AstroLoaderWhite;
            this.LoadingIndicator.Location = new System.Drawing.Point(725, 325);
            this.LoadingIndicator.Name = "LoadingIndicator";
            this.LoadingIndicator.Size = new System.Drawing.Size(63, 37);
            this.LoadingIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingIndicator.TabIndex = 11;
            this.LoadingIndicator.TabStop = false;
            this.LoadingIndicator.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astroneer_Launcher.Properties.Resources.AstroBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadingIndicator);
            this.Controls.Add(this.ManageBackups);
            this.Controls.Add(this.CheckForUpdates);
            this.Controls.Add(this.buildversion);
            this.Controls.Add(this.AstroVersion);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_OpenSettings);
            this.Controls.Add(this.Button_ManageBackups);
            this.Controls.Add(this.Button_Play);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard | Astroneer Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ManageBackups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_OpenSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ManageBackups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewSavesFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewBackups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_BackupSavesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Button_Play;
        private System.Windows.Forms.PictureBox Button_ManageBackups;
        private System.Windows.Forms.PictureBox Button_OpenSettings;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label AstroVersion;
        private System.Windows.Forms.RichTextBox buildversion;
        private System.Windows.Forms.LinkLabel CheckForUpdates;
        private System.Windows.Forms.Timer CheckIfGameRunning;
        private System.Windows.Forms.Panel ManageBackups;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Button_ViewBackups;
        private System.Windows.Forms.PictureBox Button_BackupSavesButton;
        private System.Windows.Forms.PictureBox Button_ViewSavesFolder;
        private System.ComponentModel.BackgroundWorker DoBackup;
        private System.ComponentModel.BackgroundWorker DoBackupManual;
        private System.Windows.Forms.PictureBox LoadingIndicator;
    }
}