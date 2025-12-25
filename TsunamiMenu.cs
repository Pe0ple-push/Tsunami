namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private static List<string> _listTsunamMenu = new List<string>();
        static TsunamiMenu()
        {
            _listTsunamMenu.Add("--tsm --os --AllLinux");
            _listTsunamMenu.Add("--tsm --os --Security");
            _listTsunamMenu.Add("--tsm --os --Windows");
            _listTsunamMenu.Add("--tsm --os --Enterprise");
            _listTsunamMenu.Add("--tsm --os --OldHardware");
            _listTsunamMenu.Add("--tsm --os --Educational");
            _listTsunamMenu.Add("--tsm --os --Game");
            _listTsunamMenu.Add("--tsm --os --Cloud");
            _listTsunamMenu.Add("--tsm --os --Special");
            _listTsunamMenu.Add("--tsm --os --Unusual");
        }
        public static void RunListMenu()
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

                    RunListMenu();//output list menu

                Console.Write("\n=>:\t");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out var err))
                {
                    Console.WriteLine("Error: введите команду для выбора категории..."); continue;
                }
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Error: команда не может быть пуста..."); continue;
                }

                switch(userInput)
                {
                    case "--tsm --os --AllLinux": await AllLinux.RunAllLinux(); break;
                    case "--tsm --os --Security": await SecurityOs.RunSecurityOs(); break;

                    case "--admin --n82c8283tb7 --openRoom": SecretRoom.AdminSecretCommand(); break; 
                    //enter admin room => admin authorization

                    default:
                        Console.WriteLine("Error: такой категории не сущетсвует..."); continue;
                }
                break;
            }
            while (true);

        }
    }
}