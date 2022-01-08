using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace VLC_BluRay_Installer_WFA
{
    internal class Statics
    {
        internal void Run(RichTextBox rtb, string vlcInstallationPath)
        {
            rtb.Text = "";
            rtb.Text += "------------------------------------------------------------\n";
            var vlcIsInstalled = File.Exists(Path.Combine(vlcInstallationPath, "vlc.exe"));
            if (!vlcIsInstalled)
            {
                throw new Exception("VLC seems to be installed somewhere else!");
            }

            rtb.Text += "KEYDB.cfg now gets copied into ProgramData/aacs\n";
            Copy("KEYDB.cfg", @"C:\ProgramData\aacs");
            rtb.Text += "Success!\n";
            rtb.Text += "------------------------------------------------------------\n";

            rtb.Text += "libaacs.dll now gets copied into the provided VLC directory\n";
            Copy("libaacs.dll", vlcInstallationPath);
            rtb.Text += "Success!\n";
            rtb.Text += "------------------------------------------------------------\n";
        }

        private static string sourcePath = @".\Data";
        internal void Copy(string fileName, string targetPath)
        {
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            Directory.CreateDirectory(targetPath);

            File.Copy(sourceFile, destFile, true);
        }

        internal bool IsElevated(RichTextBox rtb)
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return isElevated;
        }
    }
}
