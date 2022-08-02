using Astroneer_Launcher.Windows.FirstRun;
using Astroneer_Launcher.Windows.Main;
using Astroneer_Launcher.Windows.Update;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Astroneer_Launcher
{
    public partial class Splash : Form
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

        public Splash()
        {
            InitializeComponent();

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

            VersionNumber.Font = AstroneerRegular8;
            VersionNumber.Text = "v" + Properties.Settings.Default.VersionNumber;
            Status.Font = AstroneerRegular8;
            Status.Text = "Starting up...";

            DisplayTimer.Start();
        }

        private void ParseSettingsData()
        {
            Status.Text = "Checking settings...";

            foreach (string line in SettingsINI.Lines)
            {
                if (line.StartsWith("$FRSComplete=")) { Properties.Settings.Default.FirstRunCompleted = line.Replace("$FRSComplete=", null); }
                if (line.StartsWith("$CUOS=")) { Properties.Settings.Default.CheckUpdatesOnStart = line.Replace("$CUOS=", null); }
                if (line.StartsWith("$BOL=")) { Properties.Settings.Default.BackupOnLaunch = line.Replace("$BOL=", null); }
                if (line.StartsWith("$ADIR=")) { Properties.Settings.Default.AstroneerDirectory = line.Replace("$ADIR=", null); }

                Properties.Settings.Default.Save();
            }

            CheckFirstStartComplete();
        }

        private void CheckFirstStartComplete()
        {
            if(Properties.Settings.Default.FirstRunCompleted == "TRUE")
            {
                ContinueStartup();
                Status.Text = "Checking for updates...";
            }
            else
            {
                this.Hide();
                GetStarted firstrun = new GetStarted();
                firstrun.Show(); 
            }
        }

        private void ContinueStartup()
        {
            UpdateCheck.RunWorkerAsync();
        }

        private void UpdateCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            string CurrentUpdateVersion = "https://raw.githubusercontent.com/RWELabs/Astroneer-Launcher/main/web/uc.xml";
            string LatestRelease = "https://github.com/RyanWalpoleEnterprises/Astroneer-Launcher/releases/latest";

            //View current stable version number
            XmlDocument document = new XmlDocument();
            document.Load(CurrentUpdateVersion);
            string CVER = document.InnerText;

            //Compare current stable version against installed version
            if (CVER.Contains(Properties.Settings.Default.VersionNumber))
            {
                //No updates available - install version matches stable version
                Status.Invoke(new MethodInvoker(delegate
                {
                    Status.Text = "No updates found.";
                }));
            }
            else
            {
                //No updates available - install version matches stable version
                Status.Invoke(new MethodInvoker(delegate
                {
                    Status.Text = "Updates available.";
                }));
            }
        }

        private void UpdateCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Cleanup.Start();
            }
            else if (e.Error != null)
            {
                Status.Text = "Could not connect to update server.";
                Cleanup.Start();
            }
            else
            {
                if (Status.Text == "Updates available.")
                {
                    //Alert to available update
                    DialogResult dr = MessageBox.Show("There are updates available for Astroneer Launcher. Would you like to download and install the latest version?", "Update | Astroneer Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //User clicks yes
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            this.Hide();
                            Download dl = new Download();
                            dl.ShowDialog();
                        }
                        catch
                        {
                            Status.Text = "Issue updating. Launching Application...";
                            Cleanup.Start();
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        Status.Text = "Launching Application...";
                        LaunchApplicationNow();
                    }
                    else
                    {
                        Status.Text = "Launching Application...";
                        LaunchApplicationNow();
                    }
                }
                else
                {
                    LaunchApplicationNow();
                }

            }
        }

        private void LaunchApplicationNow()
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void Cleanup_Tick(object sender, EventArgs e)
        {
            Cleanup.Stop();
            LaunchApplicationNow();
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            DisplayTimer.Stop();

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string Settings = WorkingDir + "settings.ini";

            if (File.Exists(Settings))
            {
                SettingsINI.LoadFile(Settings, RichTextBoxStreamType.PlainText);
                ParseSettingsData();
            }
            else
            {
                this.Hide();
                GetStarted firstrun = new GetStarted();
                firstrun.Show();
            }
        }
    }
}
