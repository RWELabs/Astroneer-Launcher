using Astroneer_Launcher.Properties;
using Astroneer_Launcher.Windows.Preferences;
using Astroneer_Launcher.Windows.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Astroneer_Launcher.Windows.Main
{

    public partial class Dashboard : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font AstroneerRegular8;
        Font AstroneerRegular10;
        Font AstroneerRegular12;
        Font AstroneerRegular14;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
            CheckIfGameRunning.Start();
            CheckIfGameRunningNow();

            byte[] fontData = Properties.Resources.NDAstroneer_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.NDAstroneer_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.NDAstroneer_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            AstroneerRegular8 = new Font(fonts.Families[0], 8.5F);
            AstroneerRegular10 = new Font(fonts.Families[0], 10.0F);
            AstroneerRegular12 = new Font(fonts.Families[0], 12.0F);
            AstroneerRegular14 = new Font(fonts.Families[0], 14.0F);

            Version.Font = AstroneerRegular8;
            Version.Text = "Launcher Version: " + Environment.NewLine + Properties.Settings.Default.VersionNumber;
            AstroVersion.Font = AstroneerRegular8;
            CheckForUpdates.Font = AstroneerRegular8;
            CreditsLink.Font = AstroneerRegular8;
            HelpLink.Font = AstroneerRegular8;

            //MessageBox.Show(Properties.Settings.Default.AstroneerDirectory + @"\build.version");

            if(File.Exists(Path.GetFullPath(Properties.Settings.Default.AstroneerDirectory + @"\build.version")))
            {
                buildversion.LoadFile(Properties.Settings.Default.AstroneerDirectory + @"\build.version", RichTextBoxStreamType.PlainText);
                AstroVersion.Text = "Astroneer Version: " + Environment.NewLine + buildversion.Text;
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckIfGameRunning_Tick(object sender, EventArgs e)
        {
            CheckIfGameRunningNow();
        }

        private void CheckIfGameRunningNow()
        {
            int counter = 0;
            foreach (Process process in Process.GetProcessesByName("Astro-Win64-Shipping"))
            {
                counter++;
            }
            foreach (Process process in Process.GetProcessesByName("Astro"))
            {
                counter++;
            }

            if (counter > 0)
            {
                Button_Play.Enabled = false;
                Button_Play.Image = Resources.Button_GameRunning;
            }
            else
            {
                Button_Play.Enabled = true;
                Button_Play.Image = Resources.Button_PlayGame;
            }
        }

        private void Button_ManageBackups_Click(object sender, EventArgs e)
        {
            if(ManageBackups.Visible == true) 
            { 
                ManageBackups.Visible = false; 
            }
            else if(ManageBackups.Visible == false) 
            { 
                ManageBackups.Visible = true; 
            }
        }

        private void Button_Play_MouseEnter(object sender, EventArgs e)
        {
            Button_Play.Image = Resources.Button_PlayGame_Bold;
        }

        private void Button_Play_MouseLeave(object sender, EventArgs e)
        {
            Button_Play.Image = Resources.Button_PlayGame;
        }

        private void Button_ManageBackups_MouseEnter(object sender, EventArgs e)
        {
            Button_ManageBackups.Image = Resources.Button_ManageBackups_Bold;
        }

        private void Button_ManageBackups_MouseLeave(object sender, EventArgs e)
        {
            Button_ManageBackups.Image = Resources.Button_ManageBackups;
        }

        private void Button_OpenSettings_MouseEnter(object sender, EventArgs e)
        {
            Button_OpenSettings.Image = Resources.Button_Preferences_Bold;
        }

        private void Button_OpenSettings_MouseLeave(object sender, EventArgs e)
        {
            Button_OpenSettings.Image = Resources.Button_Preferences;
        }

        private void Button_Exit_MouseEnter(object sender, EventArgs e)
        {
            Button_Exit.Image = Resources.Button_Exit_Bold;
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            Button_Exit.Image = Resources.Button_Exit;
        }

        private void Button_BackupSaves_MouseEnter(object sender, EventArgs e)
        {
            Button_BackupSavesButton.Image = Resources.Button_BackUpSaves_Bold;
        }

        private void Button_BackupSavesButton_MouseLeave(object sender, EventArgs e)
        {
            Button_BackupSavesButton.Image = Resources.Button_BackUpSaves;
        }

        private void Button_ViewBackups_MouseEnter(object sender, EventArgs e)
        {
            Button_ViewBackups.Image = Resources.Button_ViewBackups_Bold;
        }

        private void Button_ViewBackups_MouseLeave(object sender, EventArgs e)
        {
            Button_ViewBackups.Image = Resources.Button_ViewBackups;
        }

        private void Button_ViewSavesFolder_MouseEnter(object sender, EventArgs e)
        {
            Button_ViewSavesFolder.Image = Resources.Button_OpenSavesFolder_Bold;
        }

        private void Button_ViewSavesFolder_MouseLeave(object sender, EventArgs e)
        {
            Button_ViewSavesFolder.Image = Resources.Button_OpenSavesFolder;
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string BackupsDir = AppData + @"\RWE Labs\Astroneer Launcher\backups\auto\";
            string Settings = WorkingDir + "settings.ini";

            string AstroAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string AstroSaves = AstroAppData + @"\Astro\Saved\SaveGames\";

            Button_Play.Enabled = false;

            if (Properties.Settings.Default.BackupOnLaunch == "TRUE")
            {
                Button_Play.Image = Resources.Button_BackingUpSaves;

                try
                {
                    if (!Directory.Exists(AstroSaves)) 
                    { 
                        MessageBox.Show("There was an issue reaching your saves folder. Folder directory should be: " + AstroSaves);
                        Button_Play.Enabled = true;
                        Button_Play.Image = Resources.Button_PlayGame;
                    }
                    if (!Directory.Exists(BackupsDir)) 
                    { 
                        Directory.CreateDirectory(BackupsDir); 
                    }

                    DoBackup.RunWorkerAsync();
                }
                catch
                {

                }
            }
            else if(Properties.Settings.Default.BackupOnLaunch != "TRUE")
            {
                Button_Play.Enabled = false;
                Button_Play.Image = Resources.Button_LaunchingGame;
                StartGameLaunch();
            }
        }

        private void DoBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingIndicator.Invoke(new MethodInvoker(delegate
            {
                LoadingIndicator.Visible = true;
            }));

            Button_Play.Invoke(new MethodInvoker(delegate
            {
                Button_Play.Image = Resources.Button_BackingUpSaves;
            }));

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string BackupsDir = AppData + @"\RWE Labs\Astroneer Launcher\backups\auto\";
            string Settings = WorkingDir + "settings.ini";

            string AstroAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string AstroSaves = AstroAppData + @"\Astro\Saved\SaveGames\";

            ZipFile.CreateFromDirectory(AstroSaves, BackupsDir + @"backup_" + DateTime.Now.ToString("dd-mm-yy-hh-mm-ss") + ".zip");
        }

        private void DoBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Button_Play.Enabled = true;
                Button_Play.Image = Resources.Button_PlayGame;
                LoadingIndicator.Visible = false;
            }
            else if (e.Error != null)
            {
                Button_Play.Enabled = true;
                Button_Play.Image = Resources.Button_PlayGame;
                LoadingIndicator.Visible = false;
            }
            else
            {
                Button_Play.Image = Resources.Button_LaunchingGame;
                StartGameLaunch();
            }
        }

        private void StartGameLaunch()
        {
            string Astroneer = Path.GetFullPath(Properties.Settings.Default.AstroneerDirectory + @"\Astro\Binaries\Win64\Astro-Win64-Shipping.exe");
            string AstroneerBackup = Path.GetFullPath(Properties.Settings.Default.AstroneerDirectory + @"\Astro.exe");
            
            try
            {
                if (File.Exists(Astroneer))
                {
                    Process.Start(Astroneer);
                    LoadingIndicator.Visible = false;
                }
                else
                {
                    Process.Start(AstroneerBackup);
                    LoadingIndicator.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                LoadingIndicator.Visible = false;
            }
        }

        private void Button_BackupSavesButton_Click(object sender, EventArgs e)
        {
            LoadingIndicator.Visible = true;

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string BackupsDir = AppData + @"\RWE Labs\Astroneer Launcher\backups\manual\";
            string Settings = WorkingDir + "settings.ini";

            string AstroAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string AstroSaves = AstroAppData + @"\Astro\Saved\SaveGames\";

            Button_BackupSavesButton.Enabled = false;
            Button_BackupSavesButton.Image = Resources.Button_BackingUpSaves;

            if (!Directory.Exists(AstroSaves))
            {
                MessageBox.Show("There was an issue reaching your saves folder. Folder directory should be: " + AstroSaves);
                Button_BackupSavesButton.Enabled = true;
                Button_BackupSavesButton.Image = Resources.Button_BackUpSaves;
            }
            if (!Directory.Exists(BackupsDir))
            {
                Directory.CreateDirectory(BackupsDir);
            }

            DoBackupManual.RunWorkerAsync();
        }

        private void DoBackupManual_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingIndicator.Invoke(new MethodInvoker(delegate
            {
                LoadingIndicator.Visible = true;
            }));

            Button_BackupSavesButton.Invoke(new MethodInvoker(delegate
            {
                Button_BackupSavesButton.Image = Resources.Button_BackingUpSaves;
            }));

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string BackupsDir = AppData + @"\RWE Labs\Astroneer Launcher\backups\manual\";
            string Settings = WorkingDir + "settings.ini";

            string AstroAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string AstroSaves = AstroAppData + @"\Astro\Saved\SaveGames\";

            ZipFile.CreateFromDirectory(AstroSaves, BackupsDir + @"backup_" + DateTime.Now.ToString("dd-mm-yy-hh-mm-ss") + ".zip");
        }

        private void DoBackupManual_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Button_BackupSavesButton.Enabled = true;
                Button_BackupSavesButton.Image = Resources.Button_BackUpSaves;
                LoadingIndicator.Visible = false;
            }
            else if (e.Error != null)
            {
                Button_BackupSavesButton.Enabled = true;
                Button_BackupSavesButton.Image = Resources.Button_BackUpSaves;
                LoadingIndicator.Visible = false;
            }
            else
            {
                Button_BackupSavesButton.Enabled = true;
                Button_BackupSavesButton.Image = Resources.Button_BackUpSaves;
                LoadingIndicator.Visible = false;
            }
        }

        private void Button_ViewBackups_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string BackupsDir = AppData + @"\RWE Labs\Astroneer Launcher\backups\";

            if (Directory.Exists(BackupsDir))
            {
                Process.Start(BackupsDir);
            }
            else
            {
                MessageBox.Show("Oops. Looks like you haven't made any backups yet. Make a backup and then try again.","Astroneer Launcher",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Button_ViewSavesFolder_Click(object sender, EventArgs e)
        {
            string AstroAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string AstroSaves = AstroAppData + @"\Astro\Saved\SaveGames\";

            if (Directory.Exists(AstroSaves))
            {
                Process.Start(AstroSaves);
            }
            else
            {
                MessageBox.Show("Oops. We couldn't find your Astroneer saves folder. Make sure you have at least started one new game on your PC and try again.", "Astroneer Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_OpenSettings_Click(object sender, EventArgs e)
        {
            UserPreferences up = new UserPreferences();
            up.Show();
            this.Hide();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckForUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckForUpdates.Text = "Checking for updates...";

            string CurrentUpdateVersion = "https://raw.githubusercontent.com/RWELabs/Astroneer-Launcher/main/web/uc.xml";
            string LatestRelease = "https://github.com/RyanWalpoleEnterprises/Astroneer-Launcher/releases/latest";

            //View current stable version number
            XmlDocument document = new XmlDocument();
            document.Load(CurrentUpdateVersion);
            string CVER = document.InnerText;

            //Compare current stable version against installed version
            if (CVER.Contains(Properties.Settings.Default.VersionNumber))
            {
                CheckForUpdates.Text = "No updates found.";
            }
            else
            {
                //No updates available - install version matches stable version
                CheckForUpdates.Text = "Updates available!";
                //Alert to available update
                DialogResult dr = MessageBox.Show("There are updates available for Astroneer Launcher. Would you like to download and install the latest version?", "Update | Astroneer Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //User clicks yes
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Download dl = new Download();
                        dl.ShowDialog();
                    }
                    catch
                    {
                        CheckForUpdates.Text = "Updates available!";
                    }
                }
                else if (dr == DialogResult.No)
                {
                    CheckForUpdates.Text = "Updates available!";
                }
            }
        }

        private void CreditsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Credits cred = new Credits();
            cred.ShowDialog();
        }

        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://rwe-labs.gitbook.io/astrolauncher/");
        }
    }
}
