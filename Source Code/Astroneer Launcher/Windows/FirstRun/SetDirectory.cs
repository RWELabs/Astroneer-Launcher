using Astroneer_Launcher.Properties;
using Astroneer_Launcher.Windows.Main;
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

namespace Astroneer_Launcher.Windows.FirstRun
{
    public partial class SetDirectory : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font AstroneerRegular8;
        Font AstroneerRegular10;
        Font AstroneerRegular12;
        Font AstroneerRegular14;

        public SetDirectory()
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

            if(File.Exists(@"C:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\Astro.exe")) { Directory.Text = @"C:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\"; }
            else if (File.Exists(@"D:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\Astro.exe")) { Directory.Text = @"D:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\"; }
            else if (File.Exists(@"E:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\Astro.exe")) { Directory.Text = @"E:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\"; }
            else if (File.Exists(@"G:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\Astro.exe")) { Directory.Text = @"G:\Program Files (x86)\Steam\steamapps\common\ASTRONEER\"; }
            else 
            { 
                //do nothing, no auto found directory
            }
        }

        private void SetDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Directory_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(Directory.Text + @"\Astro.exe"))
            {
                Validity.Image = Resources.Invalid;
                CompleteSetup.Enabled = false;
            }
            else if (File.Exists(Directory.Text + @"\Astro.exe"))
            {
                Validity.Image = Resources.Valid;
                CompleteSetup.Enabled = true;
            }
        }

        private void CompleteSetup_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string WorkingDir = AppData + @"\RWE Labs\Astroneer Launcher\";
            string Settings = WorkingDir + "settings.ini";

            SettingsINI.LoadFile(Settings, RichTextBoxStreamType.PlainText);

            SettingsINI.AppendText(Environment.NewLine + "$ADIR=" + Directory.Text);
            SettingsINI.AppendText(Environment.NewLine + "$FRSComplete=TRUE");

            //Save in AppData Settings.ini
            SettingsINI.SaveFile(Settings, RichTextBoxStreamType.PlainText);

            //Save in Application Settings
            Properties.Settings.Default.AstroneerDirectory = Directory.Text;
            Properties.Settings.Default.FirstRunCompleted = "TRUE";
            Properties.Settings.Default.Save();

            Dashboard db = new Dashboard();
            this.Hide();
            db.Show();
        }
    }
}
