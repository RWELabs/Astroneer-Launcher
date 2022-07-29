namespace Astroneer_Launcher.Windows.FirstRun
{
    partial class GetStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStarted));
            this.HasExistingSave = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PlaysOnSteam = new System.Windows.Forms.ComboBox();
            this.CheckUpdates = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.BackupOnLaunch = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.CompleteSetup = new System.Windows.Forms.Button();
            this.SettingsINI = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HasExistingSave
            // 
            this.HasExistingSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HasExistingSave.FormattingEnabled = true;
            this.HasExistingSave.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.HasExistingSave.Location = new System.Drawing.Point(92, 205);
            this.HasExistingSave.Name = "HasExistingSave";
            this.HasExistingSave.Size = new System.Drawing.Size(174, 21);
            this.HasExistingSave.TabIndex = 2;
            this.HasExistingSave.SelectedIndexChanged += new System.EventHandler(this.HasExistingSave_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Label1.Location = new System.Drawing.Point(89, 162);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(206, 46);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Do you have an existing Astroneer save on your PC?";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Label2.Location = new System.Drawing.Point(83, 237);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(183, 41);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Do you use the Steam copy of Astroneer?";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlaysOnSteam
            // 
            this.PlaysOnSteam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaysOnSteam.Enabled = false;
            this.PlaysOnSteam.FormattingEnabled = true;
            this.PlaysOnSteam.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.PlaysOnSteam.Location = new System.Drawing.Point(92, 281);
            this.PlaysOnSteam.Name = "PlaysOnSteam";
            this.PlaysOnSteam.Size = new System.Drawing.Size(174, 21);
            this.PlaysOnSteam.TabIndex = 4;
            this.PlaysOnSteam.SelectedIndexChanged += new System.EventHandler(this.PlaysOnSteam_SelectedIndexChanged);
            // 
            // CheckUpdates
            // 
            this.CheckUpdates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckUpdates.Enabled = false;
            this.CheckUpdates.FormattingEnabled = true;
            this.CheckUpdates.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CheckUpdates.Location = new System.Drawing.Point(92, 363);
            this.CheckUpdates.Name = "CheckUpdates";
            this.CheckUpdates.Size = new System.Drawing.Size(174, 21);
            this.CheckUpdates.TabIndex = 8;
            this.CheckUpdates.SelectedIndexChanged += new System.EventHandler(this.CheckUpdates_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Label3.Location = new System.Drawing.Point(89, 319);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(206, 46);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Would you like to check for updates on startup?";
            // 
            // BackupOnLaunch
            // 
            this.BackupOnLaunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackupOnLaunch.Enabled = false;
            this.BackupOnLaunch.FormattingEnabled = true;
            this.BackupOnLaunch.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.BackupOnLaunch.Location = new System.Drawing.Point(92, 447);
            this.BackupOnLaunch.Name = "BackupOnLaunch";
            this.BackupOnLaunch.Size = new System.Drawing.Size(174, 21);
            this.BackupOnLaunch.TabIndex = 11;
            this.BackupOnLaunch.SelectedIndexChanged += new System.EventHandler(this.BackupOnLaunch_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Label4.Location = new System.Drawing.Point(83, 403);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(183, 41);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Should we backup your saves every time you play?";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Astroneer_Launcher.Properties.Resources.Backup;
            this.pictureBox6.Location = new System.Drawing.Point(272, 403);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Astroneer_Launcher.Properties.Resources.StayUpdated;
            this.pictureBox5.Location = new System.Drawing.Point(12, 319);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Astroneer_Launcher.Properties.Resources.CD;
            this.pictureBox4.Location = new System.Drawing.Point(272, 237);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Astroneer_Launcher.Properties.Resources.PC;
            this.pictureBox3.Location = new System.Drawing.Point(12, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Astroneer_Launcher.Properties.Resources.Header_YourJourneyBlack;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Astroneer_Launcher.Properties.Resources.Header_GetStartedBlack;
            this.pictureBox1.Location = new System.Drawing.Point(-47, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label5.Location = new System.Drawing.Point(64, 471);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(202, 34);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Requires you to launch the game using Astroneer Launcher";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CompleteSetup
            // 
            this.CompleteSetup.Enabled = false;
            this.CompleteSetup.Location = new System.Drawing.Point(92, 536);
            this.CompleteSetup.Name = "CompleteSetup";
            this.CompleteSetup.Size = new System.Drawing.Size(174, 34);
            this.CompleteSetup.TabIndex = 15;
            this.CompleteSetup.Text = "Next Step";
            this.CompleteSetup.UseVisualStyleBackColor = true;
            this.CompleteSetup.Click += new System.EventHandler(this.CompleteSetup_Click);
            // 
            // SettingsINI
            // 
            this.SettingsINI.Location = new System.Drawing.Point(12, 72);
            this.SettingsINI.Name = "SettingsINI";
            this.SettingsINI.Size = new System.Drawing.Size(331, 31);
            this.SettingsINI.TabIndex = 16;
            this.SettingsINI.Text = "";
            this.SettingsINI.Visible = false;
            // 
            // GetStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 592);
            this.Controls.Add(this.SettingsINI);
            this.Controls.Add(this.CompleteSetup);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.BackupOnLaunch);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.CheckUpdates);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PlaysOnSteam);
            this.Controls.Add(this.HasExistingSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(380, 631);
            this.MinimumSize = new System.Drawing.Size(380, 631);
            this.Name = "GetStarted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup | Astroneer Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetStarted_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox HasExistingSave;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox PlaysOnSteam;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox CheckUpdates;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox BackupOnLaunch;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button CompleteSetup;
        private System.Windows.Forms.RichTextBox SettingsINI;
    }
}