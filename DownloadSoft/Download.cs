using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace TsunamiApp
{
    public class Download
    {
        private static async Task DowloadSoft(string name, string downloadUrl)
        { 

            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Error: имя софта не может пустовать!" , nameof(name));
            if (string.IsNullOrWhiteSpace(downloadUrl)) throw new ArgumentException("Error: ссылка скачивания пуста!", nameof(downloadUrl));
            if (!downloadUrl.Contains("https://") && !downloadUrl.Contains("http://")) 
            {
                throw new ArgumentException("Error: неверный формат ссылки!" , nameof(downloadUrl));
            }

                //long fileSize = await GetFileSizeAsync(downloadUrl);

            var savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + ".zip");
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
                await DowloadSoft(softName, urlSoft);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch(HttpRequestException ex)
            //{
            //    Console.WriteLine(ex.Message); 
            //}
        }
    }
}