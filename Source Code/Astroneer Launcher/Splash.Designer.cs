namespace Astroneer_Launcher
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.VersionNumber = new System.Windows.Forms.Label();
            this.SettingsINI = new System.Windows.Forms.RichTextBox();
            this.UpdateCheck = new System.ComponentModel.BackgroundWorker();
            this.Status = new System.Windows.Forms.Label();
            this.Cleanup = new System.Windows.Forms.Timer(this.components);
            this.DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Astroneer_Launcher.Properties.Resources.AstroLogoText;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Astroneer_Launcher.Properties.Resources.Header_UnofficialLauncher;
            this.pictureBox2.Location = new System.Drawing.Point(45, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Astroneer_Launcher.Properties.Resources.RWE_Labs_White;
            this.pictureBox3.Location = new System.Drawing.Point(362, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // VersionNumber
            // 
            this.VersionNumber.AutoSize = true;
            this.VersionNumber.BackColor = System.Drawing.Color.Transparent;
            this.VersionNumber.ForeColor = System.Drawing.Color.White;
            this.VersionNumber.Location = new System.Drawing.Point(56, 197);
            this.VersionNumber.Name = "VersionNumber";
            this.VersionNumber.Size = new System.Drawing.Size(35, 13);
            this.VersionNumber.TabIndex = 4;
            this.VersionNumber.Text = "label1";
            // 
            // SettingsINI
            // 
            this.SettingsINI.Location = new System.Drawing.Point(12, 89);
            this.SettingsINI.Name = "SettingsINI";
            this.SettingsINI.Size = new System.Drawing.Size(10, 96);
            this.SettingsINI.TabIndex = 5;
            this.SettingsINI.Text = "";
            this.SettingsINI.Visible = false;
            // 
            // UpdateCheck
            // 
            this.UpdateCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateCheck_DoWork);
            this.UpdateCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UpdateCheck_RunWorkerCompleted);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(56, 213);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(280, 24);
            this.Status.TabIndex = 6;
            this.Status.Text = "Starting up...";
            // 
            // Cleanup
            // 
            this.Cleanup.Interval = 6000;
            this.Cleanup.Tick += new System.EventHandler(this.Cleanup_Tick);
            // 
            // DisplayTimer
            // 
            this.DisplayTimer.Interval = 5000;
            this.DisplayTimer.Tick += new System.EventHandler(this.DisplayTimer_Tick);
            // 
            // LoadingIndicator
            // 
            this.LoadingIndicator.BackColor = System.Drawing.Color.Transparent;
            this.LoadingIndicator.Image = global::Astroneer_Launcher.Properties.Resources.AstroLoaderWhite;
            this.LoadingIndicator.Location = new System.Drawing.Point(12, 197);
            this.LoadingIndicator.Name = "LoadingIndicator";
            this.LoadingIndicator.Size = new System.Drawing.Size(44, 29);
            this.LoadingIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingIndicator.TabIndex = 8;
            this.LoadingIndicator.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astroneer_Launcher.Properties.Resources.Astro_BG_Splash2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 237);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingIndicator);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.VersionNumber);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SettingsINI);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astroneer Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label VersionNumber;
        private System.Windows.Forms.RichTextBox SettingsINI;
        private System.ComponentModel.BackgroundWorker UpdateCheck;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer Cleanup;
        private System.Windows.Forms.Timer DisplayTimer;
        private System.Windows.Forms.PictureBox LoadingIndicator;
    }
}

