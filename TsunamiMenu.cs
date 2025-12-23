namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private static List<string> _listTsunamMenu = new List<string>();
        static TsunamiMenu()
        {
            _listTsunamMenu.Add("--search --category --OperationSystem");
            //_listTsunamMenu.Add("--search --category --Design&Graphics");
            //_listTsunamMenu.Add("--search --category --Video&Audio");
            //_listTsunamMenu.Add("--search --category --Development");
            //_listTsunamMenu.Add("--search --category --Utilities");
            //_listTsunamMenu.Add("--search --category --Browsers");
            //_listTsunamMenu.Add("--search --category --Entertainments");
            //_listTsunamMenu.Add("--search --category --OfficeApplications");
            //_listTsunamMenu.Add("--search --category --Security");
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
                //banner

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
                    case "--search --category --OperationSystem": await TsunamiList.RunOperationSystem(); break;
                    case "--search --category --Design&Graphics": break;
                    case "--search --category --Video&Audio": break;
                    case "--search --category --Development": break;
                    case "--search --category --Utilities": break;
                    case "--search --category --Browsers": break;
                    case "--search --category --Entertainments": break;
                    case "--search --category --OfficeApplications": break;
                    case "--search --category --Security": break;

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