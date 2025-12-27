using System.Security;

namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private static List<string> _listTsunamMenu = new List<string>();
        static TsunamiMenu()
        {
            _listTsunamMenu.Add("--tsm --os --open --AllLinux");
            _listTsunamMenu.Add("--tsm --os --open --Security");
            _listTsunamMenu.Add("--tsm --exit");
        }
        public static async Task RunListMenu()
        {
            foreach(string item  in _listTsunamMenu) Console.WriteLine(item);
        }

        //run menu 
        public static async Task Menu() //USER && ADMIN INTERFACE
        {
            do
            {
                Console.Clear();
                Banner.BannerLogo();

                    await RunListMenu();//output list menu

                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out var err))
                {
                    Console.WriteLine("Error: ������� ������� ��� ������ ���������..."); continue;
                }
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error: ������� �� ����� ���� �����..."); continue;
                }

                switch(userInput)
                {
                    case "--tsm --os --open --AllLinux": await AllLinux.RunAllLinux(); break;
                    case "--tsm --os --open --Security": await SecurityOs.RunSecurityOs(); break;
                    case"--tsm --exit": Environment.Exit(0); break;

                    case "--admin --n82c8283tb7 --openRoom": SecretRoom.AdminSecretCommand(); break; 
                    //enter admin room => admin authorization

                    default:
                        Console.WriteLine("Error: ����� ��������� �� ����������..."); continue;
                }
                break;
            }
            while (true);

        }
    }
}