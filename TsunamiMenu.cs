namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private List<string> _listTsunamMenu = new List<string>();//no work!!!
        public void MenuList()
        {
            _listTsunamMenu.Add("--open --category --OperationSystem");
            _listTsunamMenu.Add("--open --category --Design&Graphics");
            _listTsunamMenu.Add("--open --category --Video&Audio");
            _listTsunamMenu.Add("--open --category --Development");
            _listTsunamMenu.Add("--open --category --Utilities");
            _listTsunamMenu.Add("--open --category --Browsers");
            _listTsunamMenu.Add("--open --category --Entertainments");
            _listTsunamMenu.Add("--open --category --OfficeApplications");
            _listTsunamMenu.Add("--open --category --Security");

            foreach(string menu in _listTsunamMenu) Console.WriteLine(menu);//попытка вывода
        }
        private void AddSoftwareFirst(string softCategory)
        {
            if(!_listTsunamMenu.Contains(softCategory))
            {
                throw new ArgumentException("Error: невозможно добавить сервис в эту категорию!", nameof(softCategory));
            }
            if(string.IsNullOrWhiteSpace(softCategory))
            {
                throw new ArgumentException("Error: имя категории для добавления сервиса пустое!" , nameof(softCategory));
            }
        }
        public void AddSoftware(string  softCategory)
        {
            AddSoftwareFirst(softCategory);
        }

        private void AddSoftCategory(string softCategory)
        {
            if(softCategory.Length < 2)
            {
                throw new ArgumentException("Error: слишком короткое имя категории");
            }
            if (softCategory.Length > 25)
            {
                throw new ArgumentException("Error: слишком длинное имя категории");
            }
            if (string.IsNullOrWhiteSpace(softCategory))
            {
                throw new ArgumentException("Error: новая категория не может быть пуста!");
            }
            if (_listTsunamMenu.Contains(softCategory))
            {
                throw new ArgumentException("Error: софт уже существует!");
            }
            _listTsunamMenu.Add(softCategory);

        }
        public void RunAddSoftCategory(string softCategory)
        {
            AddSoftCategory(softCategory);
        }

        private void RemoveSoftCategory(string softCategory)
        {
            if (string.IsNullOrWhiteSpace(softCategory))
            {
                throw new ArgumentException("Error: поле удаления категории пустует!");
            }
            if (!_listTsunamMenu.Contains(softCategory))
            {
                throw new ArgumentException("Error: категория для удаления - не найдена!");
            }
            _listTsunamMenu.Remove(softCategory);
        }
        public void RunRemoveSoftCategory(string softCategory)
        {
            RemoveSoftCategory(softCategory);
        }
        public IReadOnlyList<string> GetSoftCategory()
        {
            return _listTsunamMenu.AsReadOnly();
        }


        public static void Menu() //USER && ADMIN INTERFACE
        {
            do
            {
                Console.Clear();
                TsunamiMenu menu = new TsunamiMenu();
                var menuMain = menu.GetSoftCategory();
                //list

                Console.WriteLine("\n=>:\t");
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
                    case "--open --category --OperationSystem": break;



                    case "--admin --n82c8283tb7 --openRoom": SecretRoom.AdminSecretCommand(); break; 
                    //enter admin room => admin authorization

                    default:
                        Console.WriteLine("Error: такой категории не сущетсвует..."); continue;
                }
            }
            while (true);

        }
    }
}