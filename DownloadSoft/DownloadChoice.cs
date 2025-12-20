using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace TsunamiApp
{
    public class DownloadChoice
    {
        private List<string> _downloadCommand = new List<string>();
        public void DownloadCommand()
        {
            _downloadCommand.Add(" --download --Torrent");
            _downloadCommand.Add(" --download --Zip");
            _downloadCommand.Add(" --download --Iso");
            _downloadCommand.Add(" --download --Exe");
        }//перенести в др файл
        private void AddDownloadCommand(string command)
        {
            if(_downloadCommand.Contains(command))
            {
                throw new ArgumentException("Error: така€ команда уже существует..." , nameof(command));
            }
        }
        //public void RunAddDownloadCommand(string downloadCommand)
        //{
        //    AddDownloadCommand(downloadCommand);
        //}



        //public List<string> GetDownloadCommand()
        //{
        //    return _downloadCommand;
        //}



        //private static void UserDownloadChoice()
        //{
        //    Console.Clear();
        //    //banner

        //    DownloadChoice commandList = new DownloadChoice();
        //        var listDownload = commandList.GetDownloadCommand();

        //    foreach ( var item in listDownload) Console.WriteLine(item);
        //    Console.WriteLine("\n=>:\t");
        //}
        //public void RunUserDownloadChoice()
        //{
        //    UserDownloadChoice();
        //}
    }
}