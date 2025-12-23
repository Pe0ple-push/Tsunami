using System.CodeDom;

namespace TsunamiApp
{
    internal class TsunamiList //ÑÎÇÄÀÒÜ ÎÒÄÅËÜÍÛÅ ÌÅÒÎÄÛ ÄËß ÊÀÆÄÎÃÎ ËÈÑÒÀ
    {
        private static List<string> _operationSystem = new List<string>();
        private static List<string> _designGraphics = new List<string>();
        private static List<string> _videoAudio = new List<string>();
        private static List<string> _development = new List<string>();
        private static List<string> _Utilities = new List<string>();
        private static List<string> _browsers = new List<string>();
        private static List<string> _entertainments = new List<string>();
        private static List<string> _officeApplications = new List<string>();
        private static List<string> _security = new List<string>();
      
        static TsunamiList()
        {
            _operationSystem.Add("--download --software --KaliLinux");
            //list OS
        }
        public static async Task RunOperationSystem()
        {
            do
            {
                Console.Clear();
                //banner

                foreach (string item in _operationSystem) Console.WriteLine(item);
                Console.Write("\n=>:\t");

                var userInputSoft = Console.ReadLine();
                switch (userInputSoft)
                {
                    case "--download --software --KaliLinux": await KaliLinux.KaliLinuxDownload(); break;
                    default: Console.WriteLine("Error: òàêîãî ñîôòà íå ñóùåñòâóåò..."); continue;
                }
                break;
            }
            while (true);

        }
    }
}