namespace Astroneer_Launcher.Windows.FirstRun
{
    partial class SetDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDirectory));
            this.Label1 = new System.Windows.Forms.Label();
            this.SettingsINI = new System.Windows.Forms.RichTextBox();
            this.Directory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompleteSetup = new System.Windows.Forms.Button();
            this.Validity = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GeneralToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Validity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Label1.Location = new System.Drawing.Point(-1, 237);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(367, 31);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Where is your Astroneer directory located?";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsINI
            // 
            this.SettingsINI.Location = new System.Drawing.Point(12, 78);
            this.SettingsINI.Name = "SettingsINI";
            this.SettingsINI.Size = new System.Drawing.Size(331, 19);
            this.SettingsINI.TabIndex = 17;
            this.SettingsINI.Text = "";
            this.SettingsINI.Visible = false;
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(25, 269);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(284, 20);
            this.Directory.TabIndex = 18;
            this.Directory.TextChanged += new System.EventHandler(this.Directory_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(-1, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompleteSetup
            // 
            this.CompleteSetup.Location = new System.Drawing.Point(113, 295);
            this.CompleteSetup.Name = "CompleteSetup";
            this.CompleteSetup.Size = new System.Drawing.Size(135, 33);
            this.CompleteSetup.TabIndex = 21;
            this.CompleteSetup.Text = "Finish Setup";
            this.CompleteSetup.UseVisualStyleBackColor = true;
            this.CompleteSetup.Click += new System.EventHandler(this.CompleteSetup_Click);
            // 
            // Validity
            // 
            this.Validity.Image = global::Astroneer_Launcher.Properties.Resources.Invalid;
            this.Validity.Location = new System.Drawing.Point(312, 264);
            this.Validity.Name = "Validity";
            this.Validity.Size = new System.Drawing.Size(35, 29);
            this.Validity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Validity.TabIndex = 22;
            this.Validity.TabStop = false;
            this.GeneralToolTip.SetToolTip(this.Validity, "This directory does not contain a valid Astroneer install.");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Astroneer_Launcher.Properties.Resources.GameDirExample;
            this.pictureBox4.Location = new System.Drawing.Point(-5, 374);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(371, 228);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Astroneer_Launcher.Properties.Resources.Folder;
            this.pictureBox3.Location = new System.Drawing.Point(141, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Astroneer_Launcher.Properties.Resources.Header_WhereIsDirectory;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Astroneer_Launcher.Properties.Resources.Header_LocateFiles;
            this.pictureBox1.Location = new System.Drawing.Point(-47, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SetDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 592);
            this.Controls.Add(this.Validity);
            this.Controls.Add(this.CompleteSetup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.SettingsINI);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(380, 631);
            this.MinimumSize = new System.Drawing.Size(380, 631);
            this.Name = "SetDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup | Astroneer Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetDirectory_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Validity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RichTextBox SettingsINI;
        private System.Windows.Forms.TextBox Directory;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CompleteSetup;
        private System.Windows.Forms.PictureBox Validity;
        private System.Windows.Forms.ToolTip GeneralToolTip;
    }
}