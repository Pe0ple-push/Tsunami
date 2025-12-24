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
            _securityOs.Add("--download --os --Bugtraq");
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
                    case "--download --os --ParrotOS": ; break;
                    case "--download --os --BackBox": ; break;
                    case "--download --os --Pentoo": ; break;
                    case "--download --os --Bugtraq": ; break;
                    case "--download --os --Matriux": ; break;
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



    //os

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

}