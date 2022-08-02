namespace Astroneer_Launcher.Windows.Preferences
{
    partial class EditAstroDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAstroDirectory));
            this.UpdateDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AstroneerDirectoryPath = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ValidityIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValidityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateDirectory
            // 
            this.UpdateDirectory.Enabled = false;
            this.UpdateDirectory.Location = new System.Drawing.Point(118, 295);
            this.UpdateDirectory.Name = "UpdateDirectory";
            this.UpdateDirectory.Size = new System.Drawing.Size(135, 33);
            this.UpdateDirectory.TabIndex = 30;
            this.UpdateDirectory.Text = "Save Directory";
            this.UpdateDirectory.UseVisualStyleBackColor = true;
            this.UpdateDirectory.Click += new System.EventHandler(this.CompleteSetup_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(4, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 40);
            this.label2.TabIndex = 29;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AstroneerDirectoryPath
            // 
            this.AstroneerDirectoryPath.Location = new System.Drawing.Point(30, 269);
            this.AstroneerDirectoryPath.Name = "AstroneerDirectoryPath";
            this.AstroneerDirectoryPath.Size = new System.Drawing.Size(284, 20);
            this.AstroneerDirectoryPath.TabIndex = 27;
            this.AstroneerDirectoryPath.TextChanged += new System.EventHandler(this.TextboxUpdateDetected);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Label1.Location = new System.Drawing.Point(4, 237);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(367, 31);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Where is your Astroneer directory located?";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValidityIcon
            // 
            this.ValidityIcon.Image = global::Astroneer_Launcher.Properties.Resources.Invalid;
            this.ValidityIcon.Location = new System.Drawing.Point(317, 264);
            this.ValidityIcon.Name = "ValidityIcon";
            this.ValidityIcon.Size = new System.Drawing.Size(35, 29);
            this.ValidityIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ValidityIcon.TabIndex = 31;
            this.ValidityIcon.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Astroneer_Launcher.Properties.Resources.GameDirExample;
            this.pictureBox4.Location = new System.Drawing.Point(0, 374);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(371, 228);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Astroneer_Launcher.Properties.Resources.Folder;
            this.pictureBox3.Location = new System.Drawing.Point(146, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Astroneer_Launcher.Properties.Resources.Header_WhereIsDirectory;
            this.pictureBox2.Location = new System.Drawing.Point(0, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Astroneer_Launcher.Properties.Resources.Header_LocateFiles;
            this.pictureBox1.Location = new System.Drawing.Point(-42, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // EditAstroDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 589);
            this.ControlBox = false;
            this.Controls.Add(this.ValidityIcon);
            this.Controls.Add(this.UpdateDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.AstroneerDirectoryPath);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(387, 628);
            this.MinimumSize = new System.Drawing.Size(387, 628);
            this.Name = "EditAstroDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expanded Preferences | Astroneer Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.ValidityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ValidityIcon;
        private System.Windows.Forms.Button UpdateDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox AstroneerDirectoryPath;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
    }
}