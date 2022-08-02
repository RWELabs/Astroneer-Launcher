using Astroneer_Launcher.Properties;
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

namespace Astroneer_Launcher.Windows.Preferences
{
    public partial class EditAstroDirectory : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font AstroneerRegular8;
        Font AstroneerRegular10;
        Font AstroneerRegular12;
        Font AstroneerRegular14;

        public EditAstroDirectory()
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

            string Path = Properties.Settings.Default.AstroneerDirectory.ToString();
            AstroneerDirectoryPath.Text = Path;
            CheckValidity();
        }

        private void CheckValidity()
        {
            string AstroPath = Path.GetFullPath(AstroneerDirectoryPath.Text + @"\Astro.exe");

            if (File.Exists(AstroPath))
            {
                ValidityIcon.Image = Resources.Valid;
                UpdateDirectory.Enabled = true;
            }
            else
            {
                ValidityIcon.Image = Resources.Invalid;
                UpdateDirectory.Enabled = false;
            }
        }

        private void CompleteSetup_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AstroneerDirectory = AstroneerDirectoryPath.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void TextboxUpdateDetected(object sender, EventArgs e)
        {
            string AstroPath = Path.GetFullPath(AstroneerDirectoryPath.Text + @"\Astro.exe");

            if (File.Exists(AstroPath))
            {
                ValidityIcon.Image = Resources.Valid;
                UpdateDirectory.Enabled = true;
            }
            else
            {
                ValidityIcon.Image = Resources.Invalid;
                UpdateDirectory.Enabled = false;
            }
        }
    }
}
