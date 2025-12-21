using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Runtime.CompilerServices;

namespace TsunamiApp
{
    public class DownloadChoice
    {
        private static void UserDownloadChoice()//user choice
        {
                List<string> _downloadCommand = new List<string>();
                _downloadCommand.Add(" --download --Torrent");
                _downloadCommand.Add(" --download --Zip");
                _downloadCommand.Add(" --download --Iso");
                _downloadCommand.Add(" --download --Exe");

            do
            {
                Console.Clear(); //update console ( err / next step )
                //banner !!!!!!!!!!

                foreach (var item in _downloadCommand) Console.WriteLine(item);
                Console.WriteLine("\n=>:\t");

                var userInputChoice = Console.ReadLine();

                    if(int.TryParse(userInputChoice, out var err))
                    {
                        Console.WriteLine("Error: команда не может состоять лишь из цифр..."); Console.ReadKey();
                        continue;
                    }
                    if(string.IsNullOrWhiteSpace(userInputChoice))
                    {
                        Console.WriteLine("Error: введена пустая команда..."); Console.ReadKey();
                        continue;
                    }
                    if(!userInputChoice.Contains("--download"))
                    {
                        Console.WriteLine("Error: нет команды для загрузки => --download "); Console.ReadKey();
                        continue;
                    }

                    switch(userInputChoice)
                    {
                        case "--download --Torrent": //переход к скачиванию выбранного софта break;
                        case "--download --Zip": //переход к скачиванию выбранного софта   break;
                        case "--download --Iso": //переход к скачиванию выбранного софта break;
                        case "--download --Exe": //переход к скачиванию выбранного софта break;

                    default: Console.WriteLine("Error: несуществующая команда..."); continue;
                    }
                    break;//do...while
            }
            while (true);
             
        }
        public void RunUserDownloadChoice()
        {
            UserDownloadChoice();
        }
    }
}