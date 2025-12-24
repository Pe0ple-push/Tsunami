namespace TsunamiApp
{
    public class AllLinux
    {
        
        private static List<string> _allLinux = new List<string>();
        static AllLinux()
        {
            _allLinux.Add("--download --os --ArchLinux");
            _allLinux.Add("--back");
            //soon new os AllLinux...
        }
        public static async Task RunAllLinux()
        {
            while(true)
            {
                Console.Clear();
                //banner

                    foreach (var item in _allLinux) Console.WriteLine(item);
                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                switch (userInput)
                { 
                    case "--download --os --ArchLinux": await ArchLinux.RunArchLinux(); break;
                    //soon new case 

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
}