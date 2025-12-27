
using System.Collections;
namespace TsunamiApp
{
    public class AllLinux
    {
        
        private static List<string> _allLinux = new List<string>();
        static AllLinux()
        {
            _allLinux.Add("--download --os --ArchLinux");
            _allLinux.Add("--download --os --Ubuntu");
            _allLinux.Add("--download --os --Debian");
            _allLinux.Add("--download --os --Fedora");
            _allLinux.Add("--download --os --CentOS");
            _allLinux.Add("--download --os --OpenSUSE");
            _allLinux.Add("--download --os --Manjaro");
            _allLinux.Add("--download --os --Mint");
            _allLinux.Add("--download --os --ElementaryOS");
            _allLinux.Add("--download --os --PopOS");
            _allLinux.Add("--back");
            //soon new os AllLinux...
        }
        public static async Task RunAllLinux()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                    foreach (var item in _allLinux) Console.WriteLine(item);
                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch (userInput)
                { 
                    case "--download --os --ArchLinux": await ArchLinux.RunArchLinux(); break;
                    case "--download --os --Ubuntu": await Ubuntu.RunUbuntu(); break;
                    case "-download --os --Debian": await Debian.RunDebian(); break;
                    case "--download --os --Fedora": await Fedora.RunFedora(); break;
                    case "--download --os --CentOS": await CentOS.RunCentOS(); break;
                    case "--download --os --OpenSUSE": await OpenSUSE.RunOpenSUSE(); break;
                    case "--download --os --Manjaro": await Manjaro.RunManjaro(); break;
                    case"--download --os --Mint": await Mint.RunMint(); break;
                    case"--download --os --ElementaryOS": await ElementaryOS.RunElementaryOS(); break;
                    case"--download --os --PopOS": await PopOS.RunPopOS(); break;
                    case "--back": await TsunamiMenu.Menu(); break;
                        default: continue;
                }
                break;
            }
        }
        
    }
    //os AllLinux

    public class ArchLinux
    {
        public static async Task RunArchLinux()
        {
            DownloadIso archLinux = new DownloadIso();
            await archLinux.RunDownloadSoftIso("ArchLinux", "https://al.arch.niranjan.co/iso/2025.12.01/archlinux-x86_64.iso");
        }
    }
    public class Ubuntu
    {
        private static List<string> _ubuntu = new List<string>();
        static Ubuntu()
        {
            _ubuntu.Add("--download --Ubuntu --LTS24");
            _ubuntu.Add("--download --Ubuntu --25.10");
            _ubuntu.Add("--download --Ubuntu --25.10 --ARM");
            _ubuntu.Add("--back");
        }
        public static async Task RunUbuntu()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach (var i in _ubuntu) Console.WriteLine(i);
                Console.Write("\n=>:\t");

                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "--download --Ubuntu --LTS24": await UbuntuLTS24(); break;
                    case "--download --Ubuntu --25.10": await Ubuntu25(); break;
                    case "--download --Ubuntu --25.10 --ARM": await UbuntuARM(); break;
                    case "--back": await AllLinux.RunAllLinux(); break;
                    default: continue;
                }
                break;
            }
        }
        public static async Task UbuntuLTS24()
        {
            DownloadIso ubuntuLts = new DownloadIso();
            await ubuntuLts.RunDownloadSoftIso("Ubuntu LTS", "https://mirror.team-host.ru/ubuntu-cdimage/24.04.3/ubuntu-24.04.3-desktop-amd64.iso");
        }
        public static async Task Ubuntu25()
        {
            DownloadIso ubuntu25 = new DownloadIso();
            await ubuntu25.RunDownloadSoftIso("Ubuntu 25.10", "https://mirror.team-host.ru/ubuntu-cdimage/25.10/ubuntu-25.10-desktop-amd64.iso");
        }
        public static async Task UbuntuARM()
        {
            DownloadIso ubuntuARM = new DownloadIso();
            await ubuntuARM.RunDownloadSoftIso("Ubuntu 25.10 ARM", "https://cdimage.ubuntu.com/releases/25.10/release/ubuntu-25.10-desktop-arm64.iso?_gl=1*giitdh*_gcl_au*OTg2OTA4NjA3LjE3NjY3ODIwMjU.");
        }
    }
    public class Debian
    {
        public static async Task RunDebian()
        {
           DownloadIso debian = new DownloadIso();
            await debian.RunDownloadSoftIso("Debian", "https://saimei.ftp.acc.umu.se/debian-cd/current/amd64/iso-cd/debian-13.2.0-amd64-netinst.iso");
        }
    }
    public class Fedora
    {
        private static List<string> _fedora = new List<string>();
        static Fedora()
        {
            _fedora.Add("--download --Fedora --Plasma");
            _fedora.Add("--download --Fedora --Server");
            _fedora.Add("--download --Fedora --IoT");
            _fedora.Add("--back");
        }
        public static async Task RunFedora()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach (var i in _fedora) Console.WriteLine(i);
                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "--download --Fedora --Plasma": await Fedora.FedoraPlasma(); break;
                    case "--download --Fedora --Server": await Fedora.FedoraServer(); break;
                    case "--download --Fedora --IoT": await Fedora.FedoraIoT(); break;
                    case "--back": await AllLinux.RunAllLinux(); break;
                    default: continue;
                }
                break;
            }

        }
        public static async Task FedoraPlasma()
        {
            DownloadIso fedora = new DownloadIso();
            await fedora.RunDownloadSoftIso("Fedora", "https://mirror.yandex.ru/fedora/linux/releases/43/KDE/x86_64/iso/Fedora-KDE-Desktop-Live-43-1.6.x86_64.iso");
        }
        public static async Task FedoraServer()
        {
            DownloadIso fedora = new DownloadIso();
            await fedora.RunDownloadSoftIso("Fedora Server", "https://mirror.yandex.ru/fedora/linux/releases/43/Server/x86_64/iso/Fedora-Server-netinst-x86_64-43-1.6.iso");
        }
        public static async Task FedoraIoT()
        {
            DownloadIso fedora = new DownloadIso();
            await fedora.RunDownloadSoftIso("Fedora IoT", "https://mirrors.dotsrc.org/fedora-alt/iot/43/IoT/x86_64/iso/Fedora-IoT-ostree-43-20251024.0.x86_64.iso");
        }
    }
    public class CentOS
    {
        public static async Task RunCentOS()
        {
            DownloadIso centOS = new DownloadIso();
            await centOS.RunDownloadSoftIso("CentOS", "https://mirror.hyperdedic.ru/centos-stream/10-stream/BaseOS/x86_64/iso/CentOS-Stream-10-latest-x86_64-dvd1.iso");
        }
    }
    public class OpenSUSE
    {
        public static async Task RunOpenSUSE()
        {
            DownloadIso openSUSE = new DownloadIso();
            await openSUSE.RunDownloadSoftIso("OpenSUSE", "https://mirror.tspu.ru/opensuse/distribution/leap/16.0/offline/Leap-16.0-offline-installer-x86_64.install.iso");
        }
    }
    public class Manjaro
    {
        private static List<string> _manjaro = new List<string>();
        static Manjaro()
        {
            _manjaro.Add("--download --Manjaro --Plasma");
            _manjaro.Add("--download --Manjaro --Xfce");
            _manjaro.Add("--download --Manjaro --GNOME");
            _manjaro.Add("--back");
        }
        public static async Task RunManjaro()
        {
           while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach(var item in _manjaro) Console.WriteLine(item);
                Console.Write("\n=>:\t");

                var userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "--download --Manjaro --Plasma": await ManjaroPlasma(); break;
                    case "--download --Manjaro --Xfce": await ManjaroXfce(); break;
                    case "---download --Manjaro --GNOME": await ManjaroGNOME();  break;
                    case "--back": await AllLinux.RunAllLinux();  break;
                    default: continue;
                }
                break;
            }
        }
        public static async Task ManjaroPlasma()
        {
            DownloadIso manjaro = new DownloadIso();
            await manjaro.RunDownloadSoftIso("Monjaro KDE", "https://download.manjaro.org/kde/25.0.10/manjaro-kde-25.0.10-251013-linux612.iso");
        }
        public static async Task ManjaroXfce()
        {
            DownloadIso manjaro = new DownloadIso();
            await manjaro.RunDownloadSoftIso("Monjaro Xfce", "https://download.manjaro.org/xfce/25.0.10/manjaro-xfce-25.0.10-251013-linux612.iso");
        }
        public static async Task ManjaroGNOME()
        {
            DownloadIso manjaro = new DownloadIso();
            await manjaro.RunDownloadSoftIso("Monjaro GNOME", "https://download.manjaro.org/gnome/25.0.10/manjaro-gnome-25.0.10-251013-linux612.iso");
        }
    }
    public class Mint
    {
        private static List<string> _mint = new List<string>();
        static Mint()
        {
            _mint.Add("--download --Mint --Cinnamon");
            _mint.Add("--download --Mint --Xfce");
            _mint.Add("--download --Mint --MATE");
            _mint.Add("--back");
        }
        public static async Task RunMint()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                    foreach(var i in _mint) Console.WriteLine(i);
                    Console.Write("\n=>:\t");
                    var userInput = Console.ReadLine();

                switch(userInput)
                {
                    case"--download --Mint --Cinnamon": await MintCinnamon(); break;
                    case"--download --Mint --Xfce": await MintXfce(); break;
                    case"--download --Mint --MATE": await MintMATE(); break;
                    case"--back": await AllLinux.RunAllLinux(); break;
                    default: continue;
                }
                break;
            }
        }
        public static async Task MintCinnamon()
        {
            DownloadIso mint = new DownloadIso();
            await mint.RunDownloadSoftIso("Mint Cinnamon", "https://muug.ca/mirror/linuxmint/iso/stable/22.2/linuxmint-22.2-cinnamon-64bit.iso");
        }
        public static async Task MintXfce()
        {
            DownloadIso mint = new DownloadIso();
            await mint.RunDownloadSoftIso("Mint Xfce" , "https://muug.ca/mirror/linuxmint/iso/stable/22.2/linuxmint-22.2-xfce-64bit.iso");
        }
        public static async Task MintMATE()
        {
            DownloadIso mint = new DownloadIso();
            await mint.RunDownloadSoftIso("Mint MATE" , "https://muug.ca/mirror/linuxmint/iso/stable/22.2/linuxmint-22.2-mate-64bit.iso");
        }
    }
    public class ElementaryOS
    {
        public static async Task RunElementaryOS()
        {
            DownloadIso elementaryOS = new DownloadIso();
            await elementaryOS.RunDownloadSoftIso("ElementaryOS", "https://fra1.dl.elementary.io/download/MTc2Njg0NTY0Mg==/elementaryos-8.1-stable-amd64.20251211.iso");
        }
    }
    public class PopOS
    {
        private static List<string> _pop = new List<string>();
        static PopOS()
        {
            _pop.Add("--download --PopOS --24.04 LTS");
            _pop.Add("--download --PopOS --24.04 LTS --NVIDIA");
            _pop.Add("--download --PopOS --24.04 LTS --ARM");
            _pop.Add("--back");
        }
        public static async Task RunPopOS()
        {
            while(true)
            {
                Console.Clear();
                Banner.BannerLogo();

                foreach(var i in _pop) Console.WriteLine(i);
                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch(userInput)
                {
                    case"--download --PopOS --24.04 LTS": await PopLTS(); break;
                    case"-download --PopOS --24.04 LTS --NVIDIA": await PopNvidia(); break;
                    case"--download --PopOS --24.04 LTS --ARM": await PopARM(); break;
                    case"--back": await AllLinux.RunAllLinux(); break;
                    default: continue;
                }
                break;
            }
        }
        public static async Task PopLTS()
        {
            DownloadIso pop = new DownloadIso();
            await pop.RunDownloadSoftIso("PopOS LTS" , "https://iso.pop-os.org/24.04/amd64/generic/22/pop-os_24.04_amd64_generic_22.iso");
        }
        public static async Task PopNvidia()
        {
            DownloadIso pop = new DownloadIso();
            await pop.RunDownloadSoftIso("PopOS Nvidia" , "https://iso.pop-os.org/24.04/amd64/nvidia/22/pop-os_24.04_amd64_nvidia_22.iso");
        }
        public static async Task PopARM()
        {
            DownloadIso pop = new DownloadIso();
            await pop.RunDownloadSoftIso("PopOS ARM" , "https://iso.pop-os.org/24.04/arm64/generic/3/pop-os_24.04_arm64_generic_3.iso");
        }
    }
    
}