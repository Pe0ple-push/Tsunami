namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private List<string> _listTsunamMenu = new List<string>();
        public void MenuList()
        {
            _listTsunamMenu.Add("[1] Operating system");
            _listTsunamMenu.Add("[2] Design and Graphics");
            _listTsunamMenu.Add("[3] Video and Audio");
            _listTsunamMenu.Add("[4] Development");
            _listTsunamMenu.Add("[5] Utilities");
            _listTsunamMenu.Add("[6] Browsers");
            _listTsunamMenu.Add("[7] Entertainments");
            _listTsunamMenu.Add("[8] Office Applications");
            _listTsunamMenu.Add("[9] Security");
        }
        public void AddSoftCategory(string softCategory)
        {
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
        }
    }
}