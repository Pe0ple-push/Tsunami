namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private static List<string> _listTsunamMenu = new List<string>();
        static TsunamiMenu()
        {
            _listTsunamMenu.Add("--search --os --AllLinux");
            _listTsunamMenu.Add("--search --os --Security");
            _listTsunamMenu.Add("--search --os --Windows");
            _listTsunamMenu.Add("--search --os --Enterprise");
            _listTsunamMenu.Add("--search --os --OldHardware");
            _listTsunamMenu.Add("--search --os --Educational");
            _listTsunamMenu.Add("--search --os --Game");
            _listTsunamMenu.Add("--search --os --Cloud");
            _listTsunamMenu.Add("--search --os --Special");
            _listTsunamMenu.Add("--search --os --Unusual");
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
                    case "--search --os --AllLinux": await AllLinux.RunAllLinux(); break;
                    case "--search --os --Security": await SecurityOs.RunSecurityOs(); break;

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