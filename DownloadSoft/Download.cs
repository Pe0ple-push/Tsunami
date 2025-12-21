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
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Error: имя софта не может пустовать!");
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
        public static async Task RunDownloadSoft(string softName, string urlSoft) //USE ONLY LINK METHOD
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
    public class DownloadZip
    {
        private static async Task DownloadSoftZip(string name, string downloadUrl)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Error: имя софта не может пустовать!", nameof(name));
            if (string.IsNullOrWhiteSpace(downloadUrl)) throw new ArgumentException("Error: ссылка скачивания пуста!", nameof(downloadUrl));
            if (!downloadUrl.Contains("https://") && !downloadUrl.Contains("http://"))
            {
                throw new ArgumentException("Error: неверный формат ссылки!", nameof(downloadUrl));
            }

            var savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + ".zip");
            Console.WriteLine($"Скачиваем {name}...");

            using var client = new HttpClient();
            byte[] data = await client.GetByteArrayAsync(downloadUrl);
            await File.WriteAllBytesAsync(savePath, data);

            Console.WriteLine($"Установлено в {savePath}");
        }
        public async Task RunDownloadSoftZip(string softName , string urlSoft)
        {
            try
            {
                await DownloadSoftZip(softName, urlSoft);
            }
            catch(ArgumentException ex )
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DownloadTorrent
    {
        private static async Task DownloadSoftTorrent(string name , string downloadUrl)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Error: имя софта не может пустовать!", nameof(name));
            if (string.IsNullOrWhiteSpace(downloadUrl)) throw new ArgumentException("Error: ссылка скачивания пуста!", nameof(downloadUrl));
            if (!downloadUrl.Contains("https://") && !downloadUrl.Contains("http://"))
            {
                throw new ArgumentException("Error: неверный формат ссылки!", nameof(downloadUrl));
            }

            var savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + ".torrent");
            Console.WriteLine($"Скачиваем {name}...");

            using var client = new HttpClient();
            byte[] data = await client.GetByteArrayAsync(downloadUrl);
            await File.WriteAllBytesAsync(savePath, data);

            Console.WriteLine($"Установлено в {savePath}");
        }
        public async Task RunDownloadSoftTorrent(string softName , string urlSoft)
        {
            try
            {
                await DownloadSoftTorrent(softName , urlSoft);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DownloadIso
    {
        private static async Task DownloadSoftIso(string name, string downloadUrl)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Error: имя софта не может пустовать!", nameof(name));
            if (string.IsNullOrWhiteSpace(downloadUrl)) throw new ArgumentException("Error: ссылка скачивания пуста!", nameof(downloadUrl));
            if (!downloadUrl.Contains("https://") && !downloadUrl.Contains("http://"))
            {
                throw new ArgumentException("Error: неверный формат ссылки!", nameof(downloadUrl));
            }

            var savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + ".iso");
            Console.WriteLine($"Скачиваем {name}...");

            using var client = new HttpClient();
            byte[] data = await client.GetByteArrayAsync(downloadUrl);
            await File.WriteAllBytesAsync(savePath, data);

            Console.WriteLine($"Установлено в {savePath}");
        }
        public async Task RunDownloadSoftIso(string softName, string urlSoft)
        {
            try
            {
                await DownloadSoftIso(softName , urlSoft);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}