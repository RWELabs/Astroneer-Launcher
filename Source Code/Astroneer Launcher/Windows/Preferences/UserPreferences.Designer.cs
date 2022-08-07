namespace Astroneer_Launcher.Windows.Preferences
{
    partial class UserPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPreferences));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Checkbox_CheckUpdatesOnStartup = new Syncfusion.WinForms.Controls.SfButton();
            this.Checkbox_BackupOnLaunch = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SettingsINI = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.EditAstroDir = new Syncfusion.WinForms.Controls.SfButton();
            this.DeFocus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Astroneer_Launcher.Properties.Resources.Header_Preferences;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.Transparent;
            this.Button_Back.Image = global::Astroneer_Launcher.Properties.Resources.Button_BackToDashboard;
            this.Button_Back.Location = new System.Drawing.Point(12, 24);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(252, 43);
            this.Button_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Back.TabIndex = 1;
            this.Button_Back.TabStop = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Astroneer_Launcher.Properties.Resources.Text_CheckForUpdatesOnStartup;
            this.pictureBox2.Location = new System.Drawing.Point(85, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Checkbox_CheckUpdatesOnStartup
            // 
            this.Checkbox_CheckUpdatesOnStartup.AccessibleName = "Button";
            this.Checkbox_CheckUpdatesOnStartup.BackColor = System.Drawing.Color.DimGray;
            this.Checkbox_CheckUpdatesOnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkbox_CheckUpdatesOnStartup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Checkbox_CheckUpdatesOnStartup.ImageSize = new System.Drawing.Size(27, 27);
            this.Checkbox_CheckUpdatesOnStartup.Location = new System.Drawing.Point(50, 201);
            this.Checkbox_CheckUpdatesOnStartup.Name = "Checkbox_CheckUpdatesOnStartup";
            this.Checkbox_CheckUpdatesOnStartup.Size = new System.Drawing.Size(45, 38);
            this.Checkbox_CheckUpdatesOnStartup.Style.BackColor = System.Drawing.Color.DimGray;
            this.Checkbox_CheckUpdatesOnStartup.Style.DisabledForeColor = System.Drawing.Color.DimGray;
            this.Checkbox_CheckUpdatesOnStartup.Style.FocusedBackColor = System.Drawing.Color.DimGray;
            this.Checkbox_CheckUpdatesOnStartup.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Checkbox_CheckUpdatesOnStartup.Style.Image = global::Astroneer_Launcher.Properties.Resources.Checkbox_Check;
            this.Checkbox_CheckUpdatesOnStartup.Style.PressedBackColor = System.Drawing.Color.DimGray;
            this.Checkbox_CheckUpdatesOnStartup.TabIndex = 2;
            this.Checkbox_CheckUpdatesOnStartup.TabStop = false;
            this.Checkbox_CheckUpdatesOnStartup.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Checkbox_CheckUpdatesOnStartup.UseVisualStyleBackColor = false;
            this.Checkbox_CheckUpdatesOnStartup.Click += new System.EventHandler(this.Checkbox_CheckUpdatesOnStartup_Click);
            // 
            // Checkbox_BackupOnLaunch
            // 
            this.Checkbox_BackupOnLaunch.AccessibleName = "Button";
            this.Checkbox_BackupOnLaunch.BackColor = System.Drawing.Color.DimGray;
            this.Checkbox_BackupOnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkbox_BackupOnLaunch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Checkbox_BackupOnLaunch.ImageSize = new System.Drawing.Size(27, 27);
            this.Checkbox_BackupOnLaunch.Location = new System.Drawing.Point(50, 267);
            this.Checkbox_BackupOnLaunch.Name = "Checkbox_BackupOnLaunch";
            this.Checkbox_BackupOnLaunch.Size = new System.Drawing.Size(45, 38);
            this.Checkbox_BackupOnLaunch.Style.BackColor = System.Drawing.Color.DimGray;
            this.Checkbox_BackupOnLaunch.Style.DisabledForeColor = System.Drawing.Color.DimGray;
            this.Checkbox_BackupOnLaunch.Style.FocusedBackColor = System.Drawing.Color.DimGray;
            this.Checkbox_BackupOnLaunch.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Checkbox_BackupOnLaunch.Style.Image = global::Astroneer_Launcher.Properties.Resources.Checkbox_Check;
            this.Checkbox_BackupOnLaunch.Style.PressedBackColor = System.Drawing.Color.DimGray;
            this.Checkbox_BackupOnLaunch.TabIndex = 3;
            this.Checkbox_BackupOnLaunch.TabStop = false;
            this.Checkbox_BackupOnLaunch.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Checkbox_BackupOnLaunch.UseVisualStyleBackColor = false;
            this.Checkbox_BackupOnLaunch.Click += new System.EventHandler(this.Checkbox_BackupOnLaunch_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Astroneer_Launcher.Properties.Resources.Text_BackupSavesAutomatically;
            this.pictureBox3.Location = new System.Drawing.Point(101, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(289, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // SettingsINI
            // 
            this.SettingsINI.Location = new System.Drawing.Point(729, 42);
            this.SettingsINI.Name = "SettingsINI";
            this.SettingsINI.Size = new System.Drawing.Size(40, 25);
            this.SettingsINI.TabIndex = 6;
            this.SettingsINI.Text = "";
            this.SettingsINI.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Astroneer_Launcher.Properties.Resources.Text_SetChangeDirectory;
            this.pictureBox4.Location = new System.Drawing.Point(61, 350);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(289, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // EditAstroDir
            // 
            this.EditAstroDir.AccessibleName = "Button";
            this.EditAstroDir.BackColor = System.Drawing.Color.DimGray;
            this.EditAstroDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAstroDir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.EditAstroDir.ImageSize = new System.Drawing.Size(27, 27);
            this.EditAstroDir.Location = new System.Drawing.Point(50, 360);
            this.EditAstroDir.Name = "EditAstroDir";
            this.EditAstroDir.Size = new System.Drawing.Size(45, 38);
            this.EditAstroDir.Style.BackColor = System.Drawing.Color.DimGray;
            this.EditAstroDir.Style.DisabledForeColor = System.Drawing.Color.DimGray;
            this.EditAstroDir.Style.FocusedBackColor = System.Drawing.Color.DimGray;
            this.EditAstroDir.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditAstroDir.Style.Image = global::Astroneer_Launcher.Properties.Resources.Checkbox_More;
            this.EditAstroDir.Style.PressedBackColor = System.Drawing.Color.DimGray;
            this.EditAstroDir.TabIndex = 4;
            this.EditAstroDir.TabStop = false;
            this.EditAstroDir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.EditAstroDir.UseVisualStyleBackColor = false;
            this.EditAstroDir.Click += new System.EventHandler(this.EditAstroDir_Click);
            // 
            // DeFocus
            // 
            this.DeFocus.Location = new System.Drawing.Point(61, 74);
            this.DeFocus.Name = "DeFocus";
            this.DeFocus.Size = new System.Drawing.Size(75, 23);
            this.DeFocus.TabIndex = 1;
            this.DeFocus.TabStop = false;
            this.DeFocus.Text = "button1";
            this.DeFocus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(387, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astroneer_Launcher.Properties.Resources.AstroSpaceBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditAstroDir);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SettingsINI);
            this.Controls.Add(this.Checkbox_BackupOnLaunch);
            this.Controls.Add(this.Checkbox_CheckUpdatesOnStartup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DeFocus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "UserPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Preferences | Astroneer Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPreferences_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Button_Back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.WinForms.Controls.SfButton Checkbox_CheckUpdatesOnStartup;
        private Syncfusion.WinForms.Controls.SfButton Checkbox_BackupOnLaunch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox SettingsINI;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Syncfusion.WinForms.Controls.SfButton EditAstroDir;
        private System.Windows.Forms.Button DeFocus;
        private System.Windows.Forms.Label label1;
    }
}