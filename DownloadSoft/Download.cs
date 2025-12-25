using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Runtime.InteropServices;

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

                if(File.Exists(savePath))
                {
                    Console.WriteLine($"Файл с именем {name} уже существует...");
                    Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
                }

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"[!] До завершения загрузки => не трогайте файл {name} на рабочем столе");
            Console.WriteLine($"Скачиваем {name}...");

            using var client = new HttpClient();
            var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            await using var stream = await response.Content.ReadAsStreamAsync();
            await using var fileStream = File.Create(savePath);

                await fileStream.CopyToAsync(fileStream);

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"Установлено в {savePath}");
            Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
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

                if(File.Exists(savePath))
                {
                    Console.WriteLine("Файл с именем {name} уже существует...");
                    Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
                }

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"[!] До завершения загрузки => не трогайте файл {name} на рабочем столе");
            Console.WriteLine($"Скачиваем {name}...");

            using var client = new HttpClient();
            using var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            await using var stream = await response.Content.ReadAsStreamAsync();
                await using var fileStream = File.Create(savePath);

                    await stream.CopyToAsync(fileStream);

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"Установлено в {savePath}");
            Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
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

            if(File.Exists(savePath))
            {
                Console.WriteLine($"Файл под именем {name} уже существует...");
                Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
            }

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"[!] До завершения загрузки => не трогайте файл {name} на рабочем столе");
            Console.WriteLine($"Скачиваем {name}...");

            using var client = new HttpClient();
            var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            await using var stream = await response.Content.ReadAsStreamAsync();
            await using var fileStream = File.Create(savePath);

                await fileStream.CopyToAsync(fileStream);

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"Установлено в {savePath}");
            Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
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

                if(File.Exists(savePath))
                {
                    Console.WriteLine($"Файл под именем {name} уже существует...");
                    Console.WriteLine("Нажмите любую клавишу => меню"); Console.ReadKey(); await TsunamiMenu.Menu();
                }

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"[!] До завершения загрузки => не трогайте файл {name} на рабочем столе");
            Console.WriteLine($"\nСкачиваем {name}...");

            using var client = new HttpClient();

            using var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            await using var stream = await response.Content.ReadAsStreamAsync();
            await using var fileStream = File.Create(savePath);

                await stream.CopyToAsync(fileStream);

            Console.Clear();
            Banner.BannerLogo();

            Console.WriteLine($"\nУстановлено в {savePath}");
            Console.WriteLine("Нажмите любую клавишу => меню..."); Console.ReadKey(); await TsunamiMenu.Menu();
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