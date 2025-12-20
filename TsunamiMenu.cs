namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private List<string> _listTsunamMenu = new List<string>();
        public void MenuList()
        {
            _listTsunamMenu.Add("--open --category --OperationSystem");
            _listTsunamMenu.Add("Design and Graphics");
            _listTsunamMenu.Add("Video and Audio");
            _listTsunamMenu.Add("Development");
            _listTsunamMenu.Add("Utilities");
            _listTsunamMenu.Add("Browsers");
            _listTsunamMenu.Add("Entertainments");
            _listTsunamMenu.Add("Office Applications");
            _listTsunamMenu.Add("Security");
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

        public void AddSoftCategory(string softCategory)
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
        public void RemoveSoftCategory(string softCategory)
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
        public IReadOnlyList<string> GetSoftCategory()
        {
            return _listTsunamMenu.AsReadOnly();
        }
        public static void Menu()
        {
            TsunamiMenu menu = new TsunamiMenu();
                var menuMain = menu.GetSoftCategory();
                    foreach (var item in menuMain) Console.WriteLine(item);
            do
            {
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

                    default:
                        Console.WriteLine("Error: такой категории не сущетсвует..."); continue;
                }
            }
            while (true);

        }
    }
}