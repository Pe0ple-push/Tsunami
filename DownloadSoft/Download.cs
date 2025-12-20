using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace TsunamiApp
{
    public class Download
    {
        private static async Task DowloadSoftExe(string name, string downloadUrl)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Error: имя софта не может пустовать!" , nameof(name));
            if (string.IsNullOrWhiteSpace(downloadUrl)) throw new ArgumentException("Error: ссылка скачивания пуста!", nameof(downloadUrl));
            if (!downloadUrl.Contains("https://") && !downloadUrl.Contains("http://")) 
            {
                throw new ArgumentException("Error: неверный формат ссылки!" , nameof(downloadUrl));
            }

            var savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + ".exe");
            Console.WriteLine($"Скачиваем {name}...");

                using var client = new HttpClient();
                    byte[] data = await client.GetByteArrayAsync(downloadUrl);
                        await File.WriteAllBytesAsync(savePath, data);

            Console.WriteLine($"Установлено в {savePath}");
        }
        public static async Task RunDownloadSoft(string softName, string urlSoft)
        {
            try
            {
                await DowloadSoftExe(softName, urlSoft);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DownloadZip : Download
    {
        private static async Task DownloadSoftZip(string name, string downloadUrl)
        {
            //ZIP
        }
        public void RunDownloadSoftZip(string softName , string urlSoft)
        {

        }
    }
    public class DownloadTorrent : Download
    {
        private static async Task DownloadSoftTorrent(string name , string downloadUrl)
        {
            //TORRENT
        }
        public void RunDownloadSoftTorrent(string softName , string urlSoft)
        {

        }
    }
    public class DownloadIso : Download
    {
        //Async Task Iso
    }
}