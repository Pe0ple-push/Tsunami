using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace TsunamiApp
{
    public class SecurityOs
    {
        private static List<string> _securityOs = new List<string>();

        static SecurityOs()
        {
            _securityOs.Add("--download --os --KaliLinux");
            _securityOs.Add("--download --os --BlackArchLinux");
            _securityOs.Add("--download --os --ParrotOS");
            _securityOs.Add("--download --os --BackBox");
            _securityOs.Add("--download --os --Pentoo");
            _securityOs.Add("--download --os --Matriux");
            _securityOs.Add("--download --os --CyborgLinux");
            _securityOs.Add("--download --os --Weakerthan");
            _securityOs.Add("--download --os --NodeZero");
            _securityOs.Add("--download --os --CAINE");
            _securityOs.Add("--download --os --DEFT");
            _securityOs.Add("--download --os --SamuraiWTF");
            _securityOs.Add("--download --os --NetworkSecurityToolkit");
            _securityOs.Add("--download --os --ArchStrike");
            _securityOs.Add("--download --os --FedoraSecurityLab");
            _securityOs.Add("--download --os --Tails");
            _securityOs.Add("--download --os --Whonix");
            _securityOs.Add("--download --os --QubesOS");
            _securityOs.Add("--download --os --SubgraphOS");
            _securityOs.Add("--download --os --DiscreeteLinux");
            _securityOs.Add("--back");
        }
        public static async Task RunSecurityOs()
        {
            bool isUserChoice = true;
            while(isUserChoice)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach(var item in  _securityOs) Console.WriteLine(item);

                    Console.Write("\n=>:\t");
                    var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "--download --os --KaliLinux":  await KaliLinux.RunKaliLinux();  break;
                    case "--download --os --BlackArchLinux": await BlackArchLinux.RunBlackArchLinux(); break;
                    case "--download --os --ParrotOS": await ParrotOS.RunParrotOs(); break;
                    case "--download --os --BackBox": await BackBox.RunBackBox(); break;
                    case "--download --os --Pentoo": await Pentoo.RunPentoo(); break;
                    case "--download --os --Matriux": await Matriux.MetriuxIso(); break;
                    case "--download --os --CyborgLinux": ; break;
                    case "--download --os --Weakerthan": ; break;
                    case "--download --os --NodeZero": ; break;
                    case "--download --os --CAINE": ; break;
                    case "--download --os --DEFT": ; break;
                    case "--download --os --SamuraiWTF": ; break;
                    case "--download --os --NetworkSecurityToolkit": ; break;
                    case "--download --os --ArchStrike": ; break;
                    case "--download --os --FedoraSecurityLab": ; break;
                    case "--download --os --Tails": ; break;
                    case "--download --os --Whonix": ; break;
                    case "--download --os --QubesOS": ; break;
                    case "--download --os --SubgraphOS": ; break;
                    case "--download --os --DiscreeteLinux": ; break;

                    case "--back": await TsunamiMenu.Menu(); break;

                    default: continue;
                }
                break;
            }

        }
    }

    public class KaliLinux
    {
        private static List<string> _kaliLinux = new List<string>();
        static KaliLinux()
        {
            _kaliLinux.Add("--download --KaliLinux --Default");
            _kaliLinux.Add("--download --KaliLinux --VM");
            _kaliLinux.Add("--download --KaliLinux --LiveBoot");
            _kaliLinux.Add("--back");
        }
        public static async Task RunKaliLinux()
        {
            do
            {
                Console.Clear();
                //banner

                foreach (var item in _kaliLinux) Console.WriteLine(item);

                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "--download --KaliLinux --Default": await KaliLinuxDefault(); break;
                    case "--download --KaliLinux --VM": await KaliLinuxVM(); break;
                    case "--download --KaliLinux --LiveBoot": await KaliLinuxLiveBoot(); break;
                    case "--back":  await SecurityOs.RunSecurityOs(); break;
                    default: continue;
                }
                break;
            }
            while (true);
        }
        public static async Task KaliLinuxDefault()
        {
            DownloadIso kaliLinux = new DownloadIso();
            await kaliLinux.RunDownloadSoftIso("Kali Linux", "https://kali.koyanet.lv/kali-images/kali-2025.4/kali-linux-2025.4-installer-amd64.iso");
        }
        public static async Task KaliLinuxLiveBoot()
        {
            DownloadTorrent kaliLinux = new DownloadTorrent();
            await kaliLinux.RunDownloadSoftTorrent("Kali Linux", "https://kali.download/base-images/kali-2025.4/kali-linux-2025.4-live-amd64.iso.torrent");
        }
        public static async Task KaliLinuxVM()
        {
            DownloadZip kaliLinux = new DownloadZip();
            await kaliLinux.RunDownloadSoftZip("Kali Linux", "https://kali.download/base-images/kali-2025.4/kali-linux-2025.4-vmware-amd64.7z");
        }
    }

    public class BlackArchLinux
    {
        private static List<String> _blackArchLinux = new List<string>();

        static BlackArchLinux()
        {
            _blackArchLinux.Add("--download --BlackArchLinux --Netinstall");
            _blackArchLinux.Add("--download --BlackArchLinux --Slim");
            _blackArchLinux.Add("--download --BlackArchLinux --Full");
            _blackArchLinux.Add("--back");
        }
        public static async Task RunBlackArchLinux()
        {
            while(true)
            {
                Console.Clear();
                //banner

                    foreach(var item in  _blackArchLinux) Console.WriteLine(item);
                Console.Write("\n=>:\t"); 

                var userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "--download --BlackArchLinux --Netinstall": await BlackArchNetinstall();  break;
                    case "--download --BlackArchLinux --Slim": await BlackArchSlim();  break;
                    case "--download --BlackArchLinux --Full": await BlackArchFull();  break;
                    case "--back": await SecurityOs.RunSecurityOs(); break;

                    default: continue;
                }
                break;
            }
        }

        public static async Task BlackArchNetinstall()
        {
            DownloadIso blackarch = new DownloadIso();
            await blackarch.RunDownloadSoftIso("BlackArch", "https://ftp.halifax.rwth-aachen.de/blackarch/iso/blackarch-linux-netinst-2023.04.01-x86_64.iso");
        }
        public static async Task BlackArchSlim()
        {
            DownloadIso blackarch = new DownloadIso();
            await blackarch.RunDownloadSoftIso("BlackArch", "https://ftp.halifax.rwth-aachen.de/blackarch/iso/blackarch-linux-slim-2023.05.01-x86_64.iso");
        }
        public static async Task BlackArchFull()
        {
            DownloadIso blackarch = new DownloadIso();
            await blackarch.RunDownloadSoftIso("BlackArch", "https://ftp.halifax.rwth-aachen.de/blackarch/iso/blackarch-linux-full-2023.04.01-x86_64.iso");
        }

    }

    public class ParrotOS
    {
        private static List<string> _parrotOs = new List<string>();
        static ParrotOS()
        {
            _parrotOs.Add("--download --ParrotOS --Iso");
            _parrotOs.Add("--download --ParrotOS --Torrent");
            _parrotOs.Add("--back");
        }
        public static async Task RunParrotOs()
        {
            while(true)
            {
                Console.Clear();
                    Banner.BannerLogo();

                foreach (var item in _parrotOs) Console.WriteLine(item);
                Console.Write("\n=>:\t");
                    var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "--download --ParrotOS --Iso": await RunParrotOSIso(); break;
                    case "--download --ParrotOS --Torrent": await RunParrotOsTorrent(); break;
                    case "--back": await SecurityOs.RunSecurityOs(); break;
                    default: continue;
                }
                break;
            }
        }
        public static async Task RunParrotOSIso()
        {
            DownloadIso parrotOs = new DownloadIso();
            await parrotOs.RunDownloadSoftIso("ParrotOS","https://dn721607.ca.archive.org/0/items/parrot-security-4.2.2-i-386.iso_202306/Parrot-security-4.2.2_i386.iso");
        }
        public static async Task RunParrotOsTorrent()
        {
            DownloadTorrent parrotOs = new DownloadTorrent();
            await parrotOs.RunDownloadSoftTorrent("ParrotOS","https://dn721607.ca.archive.org/0/items/parrot-security-4.2.2-i-386.iso_202306/parrot-security-4.2.2-i-386.iso_202306_archive.torrent");
        }
    }

    public class BackBox
    { 
        private static List<string> _backBox = new List<string>();
        static BackBox()
        {
            _backBox.Add("--download --BackBox --Iso");
            _backBox.Add("--download --BackBox --Torrent");
            _backBox.Add("--back");
        }
        public static async Task RunBackBox()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach (var item in _backBox) Console.WriteLine(item);
                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "--download --BackBox --Iso": await BackBoxIso(); break;
                    case "--download --BackBox --Torrent": await BackBoxTorrent(); break;
                    case "--back": await SecurityOs.RunSecurityOs(); break;
                    default: continue;
                }
                break;
            }
        }
        public static async Task BackBoxIso()
        {
            DownloadIso backBox = new DownloadIso();
            await backBox.RunDownloadSoftIso("BackBox", "https://backbox.mirror.garr.it/backbox-9-desktop-amd64.iso");
        }
        public static async Task BackBoxTorrent()
        {
            DownloadTorrent backBox = new DownloadTorrent();
            await backBox.RunDownloadSoftTorrent("BackBox", "https://mirror.backbox.org/backbox-9-desktop-amd64.iso.torrent");
        }
    }

   public class Pentoo
    {
        private static List<string> _pentoo = new List<string>();
        static Pentoo()
        {
            _pentoo.Add("--download --Pentoo --Full");
            _pentoo.Add("--download --Pentoo");
            _pentoo.Add("--back");
        }
        public static async Task RunPentoo()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach (var item in _pentoo) Console.WriteLine(item);
                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "--download --Pentoo --Full": await PentooFull(); break;
                    case "--download --Pentoo": await PentooDefault(); break;
                    case "--back": break;
                    default: continue; 
                }
                break;
            }
        }
        public static async Task PentooFull()
        {
            DownloadIso pentooFull = new DownloadIso();
            await pentooFull.RunDownloadSoftIso("Pentoo", "https://pentoo.ch/isos/Release/Pentoo_Full_amd64_hardened/pentoo-full-amd64-hardened-2025.0_p20251102.iso");
        }
        public static async Task PentooDefault()
        {
            DownloadIso pentooDefault = new DownloadIso();
            await pentooDefault.RunDownloadSoftIso("Pentoo", "https://www.pentoo.ch/isos/Release/Pentoo_x86_hardened/pentoo-x86-hardened-2024.0_p20240111.iso");
        }
    }

    public class Matriux
    {
        public static async Task MetriuxIso()
        {
            DownloadIso matriux = new DownloadIso();
            await matriux.RunDownloadSoftIso("Matriux", "https://sourceforge.net/projects/matriux/files/Matriux-blue/Matriux-Blue-Lite-x64.iso/download");
        }
    }
}