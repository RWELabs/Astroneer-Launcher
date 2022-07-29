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

namespace Astroneer_Launcher.Windows.FirstRun
{
    public partial class GetStarted : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font AstroneerRegular8;
        Font AstroneerRegular10;
        Font AstroneerRegular12;
        Font AstroneerRegular14;

        public GetStarted()
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

            Label1.Font = AstroneerRegular10;
            Label2.Font = AstroneerRegular10;
            Label3.Font = AstroneerRegular10;
            Label4.Font = AstroneerRegular10;
            Label5.Font = AstroneerRegular8;
        }

        private void GetStarted_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CompleteSetup_Click(object sender, EventArgs e)
        {
            if(CheckUpdates.SelectedItem.ToString() == "Yes") { Properties.Settings.Default.CheckUpdatesOnStart = "TRUE"; Properties.Settings.Default.Save(); SettingsINI.AppendText("$CUOS=TRUE" + Environment.NewLine); }
            else if(CheckUpdates.SelectedItem.ToString() == "No") { Properties.Settings.Default.CheckUpdatesOnStart = "FALSE"; Properties.Settings.Default.Save(); SettingsINI.AppendText("$CUOS=FALSE" + Environment.NewLine); }
            
            if (BackupOnLaunch.SelectedItem.ToString() == "Yes") { Properties.Settings.Default.BackupOnLaunch = "TRUE"; Properties.Settings.Default.Save(); SettingsINI.AppendText("$BOL=TRUE" + Environment.NewLine); }
            else if (BackupOnLaunch.SelectedItem.ToString() == "No") { Properties.Settings.Default.BackupOnLaunch = "FALSE"; Properties.Settings.Default.Save(); SettingsINI.AppendText("$BOL=FALSE" + Environment.NewLine); }
        
            if(PlaysOnSteam.SelectedItem.ToString() == "No")
            {
                MessageBox.Show("This tool is designed to work with the steam version of Astroneer. We cannot guarantee that the application will function correctly with other versions of Astroneer.", "Astroneer Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //SettingsINI.AppendText("$ADIR=QQQ3");

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string Settings = WorkingDir + "settings.ini";
            if (!Directory.Exists(WorkingDir))
            {
                Directory.CreateDirectory(WorkingDir);
                SettingsINI.SaveFile(Settings, RichTextBoxStreamType.PlainText);
            }
            else
            {
                SettingsINI.SaveFile(Settings, RichTextBoxStreamType.PlainText);
            }

            //Show Next Step
            SetDirectory sd = new SetDirectory();
            sd.Show();
            this.Hide();
        }

        private void HasExistingSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(HasExistingSave.SelectedIndex > -1)
            {
                PlaysOnSteam.Enabled = true;
            }
            else
            {
                PlaysOnSteam.Enabled = false;
            }
        }

        private void PlaysOnSteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlaysOnSteam.SelectedIndex > -1)
            {
                CheckUpdates.Enabled = true;
            }
            else
            {
                CheckUpdates.Enabled = false;
            }
        }

        private void CheckUpdates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckUpdates.SelectedIndex > -1)
            {
                BackupOnLaunch.Enabled = true;
            }
            else
            {
                BackupOnLaunch.Enabled = false;
            }
        }

        private void BackupOnLaunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BackupOnLaunch.SelectedIndex > -1)
            {
                CompleteSetup.Enabled = true;
            }
            else
            {
                CompleteSetup.Enabled = false;
            }
        }
    }
}
