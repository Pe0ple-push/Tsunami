namespace TsunamiApp
{
    public class TsunamiMenu
    {
        private List<string> _listTsunam = new List<string>();
            public void AddSoftware(string softName, string downloadUrl)
            {
                if(string.IsNullOrWhiteSpace(softName) && string.IsNullOrWhiteSpace(downloadUrl))
                {
                    throw new ArgumentException("Error: новый софт не может быть пуст!");
                }
                if (_listTsunam.Contains(softName))
                {
                   throw new ArgumentException("Error: софт уже существует!");
                }
                    if (!downloadUrl.Contains("https") && !downloadUrl.Contains('.'))
                    {
                        throw new ArgumentException("Error: ссылка на софт некорректна!"); 
                    }
                    _listTsunam.Add(softName);
                    _listTsunam.Add(downloadUrl);
            }
            public void RemoveSoftware(string softName , string downloadUrl)
            {
                if(string.IsNullOrWhiteSpace(softName) && string.IsNullOrWhiteSpace(downloadUrl))
                {
                    throw new ArgumentException("Error: поле удаления софта пустует!");
                }
                if(!_listTsunam.Contains(softName ) && !_listTsunam.Contains(downloadUrl))
                {
                    throw new ArgumentException("Error: софт для удаления - не найден!");
                }
                _listTsunam.Remove(softName); _listTsunam.Remove(downloadUrl);
            }
            public IReadOnlyList<string> GetSoftwareList()
            {
                return _listTsunam.AsReadOnly();
            }
    }
}