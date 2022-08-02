using Astroneer_Launcher.Windows.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView;
using Astroneer_Launcher.Properties;

namespace Astroneer_Launcher.Windows.Preferences
{
    public partial class UserPreferences : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public UserPreferences()
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string Settings = WorkingDir + "settings.ini";

            InitializeComponent();
            GetSettings();
        }

        private void GetSettings()
        {
            //Check for Updates on Startup
            if(Properties.Settings.Default.CheckUpdatesOnStart == "TRUE")
            {
                Checkbox_CheckUpdatesOnStartup.BackColor = Color.DimGray;
                Checkbox_CheckUpdatesOnStartup.Image = Resources.Checkbox_Check;
            }
            else if (Properties.Settings.Default.CheckUpdatesOnStart != "TRUE")
            {
                Checkbox_CheckUpdatesOnStartup.BackColor = Color.DarkGray;
                Checkbox_CheckUpdatesOnStartup.Image = Resources.Checkbox_Cross;
            }

            //Do Backups on Game Launch
            if (Properties.Settings.Default.BackupOnLaunch == "TRUE")
            {
                Checkbox_BackupOnLaunch.BackColor = Color.DimGray;
                Checkbox_BackupOnLaunch.Image = Resources.Checkbox_Check;
            }
            else if (Properties.Settings.Default.BackupOnLaunch != "TRUE")
            {
                Checkbox_BackupOnLaunch.BackColor = Color.DarkGray;
                Checkbox_BackupOnLaunch.Image = Resources.Checkbox_Cross;
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkbox_CheckUpdatesOnStartup_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckUpdatesOnStart == "TRUE")
            {
                Checkbox_CheckUpdatesOnStartup.BackColor = Color.DarkGray;
                Checkbox_CheckUpdatesOnStartup.Image = Resources.Checkbox_Cross;
                Properties.Settings.Default.CheckUpdatesOnStart = "FALSE";
                Properties.Settings.Default.Save();
            }
            else if (Properties.Settings.Default.CheckUpdatesOnStart != "TRUE")
            {
                Checkbox_CheckUpdatesOnStartup.BackColor = Color.DimGray;
                Checkbox_CheckUpdatesOnStartup.Image = Resources.Checkbox_Check;
                Properties.Settings.Default.CheckUpdatesOnStart = "TRUE";
                Properties.Settings.Default.Save();
            }

            GetSettings();
            DeFocus.Focus();
        }

        private void Checkbox_BackupOnLaunch_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BackupOnLaunch == "TRUE")
            {
                Checkbox_BackupOnLaunch.BackColor = Color.DimGray;
                Checkbox_BackupOnLaunch.Image = Resources.Checkbox_Check;
                Properties.Settings.Default.BackupOnLaunch = "FALSE";
                Properties.Settings.Default.Save();
            }
            else if (Properties.Settings.Default.BackupOnLaunch != "TRUE")
            {
                Checkbox_BackupOnLaunch.BackColor = Color.DarkGray;
                Checkbox_BackupOnLaunch.Image = Resources.Checkbox_Cross;
                Properties.Settings.Default.BackupOnLaunch = "TRUE";
                Properties.Settings.Default.Save();
            }

            DeFocus.Focus();
            GetSettings();
        }

        private void UserPreferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Write Settings INI
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string Settings = WorkingDir + "settings.ini";

            SettingsINI.AppendText("$FRSComplete=" + Properties.Settings.Default.FirstRunCompleted + Environment.NewLine);
            SettingsINI.AppendText("$CUOS=" + Properties.Settings.Default.CheckUpdatesOnStart + Environment.NewLine);
            SettingsINI.AppendText("$BOL=" + Properties.Settings.Default.BackupOnLaunch + Environment.NewLine);
            SettingsINI.AppendText("$ADIR=" + Properties.Settings.Default.AstroneerDirectory + Environment.NewLine);

            SettingsINI.SaveFile(Settings, RichTextBoxStreamType.PlainText);

            //Show Dashboard
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void EditAstroDir_Click(object sender, EventArgs e)
        {
            DeFocus.Focus();
            EditAstroDirectory ed = new EditAstroDirectory();
            ed.ShowDialog();
        }
    }
}
