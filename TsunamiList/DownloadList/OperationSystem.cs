namespace TsunamiApp
{
    public class KaliLinux
    {
        public static async Task KaliLinuxDownload()
        {
            DownloadIso kaliLinux = new DownloadIso();
            await kaliLinux.RunDownloadSoftIso("Kali Linux", "https://kali.koyanet.lv/kali-images/kali-2025.4/kali-linux-2025.4-installer-amd64.iso");

        }
    }

    public class ArchLinux
    { 
        //download & constructor
    }

}