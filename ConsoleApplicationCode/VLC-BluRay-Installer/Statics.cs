using System.Security.Principal;

namespace VLC_BluRay_Installer
{
    internal static class Statics
    {
        internal static void Copyright()
        {
            Console.WriteLine("© 2022 N. J. Rueber");
            Console.WriteLine("This tool is a private project of N. J. Rueber.");
            Console.WriteLine("It was created to make life easier and install the BluRay Support for VLC MediaPlayer.");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        internal static void EnsureAdminRights()
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            if (isElevated) return;
            Console.WriteLine("You have to run the program as Administrator.");
            Quit();
        }

        internal static void Menue()
        {
            Console.Clear();
            Console.WriteLine("Press 1 for Standard VLC Installation Directory or 2 for Custom VLC Installation Directory");
            var input = Console.ReadKey().Key;
            try
            {
                Console.Clear();
                switch (input)
                {
                    case ConsoleKey.D1:
                        Run();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Please provide the installation Path:");
                        var vlcInstallationPath = Console.ReadLine();
                        var pathExists = System.IO.File.Exists(Path.Combine(vlcInstallationPath,"vlc.exe"));
                        if (!pathExists)
                        {
                            throw new Exception("VLC seems to be installed somewhere else!");
                        }
                        Run(vlcInstallationPath);
                        break;
                    default:
                        throw new Exception("Invalid Input!");
                }
                Quit();
            }
            catch (Exception e)
            {
                var defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("------------------------------------------------------------");
                Console.ForegroundColor = defaultColor;
                Console.WriteLine("Press any key to try again.");
                Console.ReadKey();
            }
        }

        internal static void Run()
        {
            FileHandler fh = new FileHandler();

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("KEYDB.cfg now gets copied into ProgramData/aacs");
            fh.Copy("KEYDB.cfg", @"C:\ProgramData\aacs");
            Success();
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("libaacs.dll now gets copied into the VLC standard directory");
            fh.Copy("libaacs.dll", @"C:\Program Files (x86)\VideoLAN\VLC");
            Success();
            Console.WriteLine("------------------------------------------------------------");
        }

        private static void Success()
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ForegroundColor = defaultColor;
        }

        internal static void Run(string vlcInstallationPath)
        {
            FileHandler fh = new FileHandler();

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("KEYDB.cfg now gets copied into ProgramData/aacs");
            fh.Copy("KEYDB.cfg", @"C:\ProgramData\aacs");
            Success();
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("libaacs.dll now gets copied into the provided VLC directory");
            fh.Copy("libaacs.dll", vlcInstallationPath);
            Success();
            Console.WriteLine("------------------------------------------------------------");
        }

        internal static void Quit()
        {
            Console.WriteLine("Press any button to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
