namespace TsunamiApp
{
    public class TsunamiList
    {
        private List<string> _operationSystem = new List<string>();
        private List<string> _designGraphics = new List<string>();
        private List<string> _videoAudio = new List<string>();
        private List<string> _development = new List<string>();
        private List<string> _Utilities = new List<string>();
        private List<string> _browsers = new List<string>();
        private List<string> _entertainments = new List<string>();
        private List<string> _officeApplications = new List<string>();
        private List<string> _security = new List<string>();

        //создание списка сервисов по умолчанию => тестирование ПО

        public void AddOperationSystem(string name, string downloadUrl)
        {
            if(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(downloadUrl))
                throw new ArgumentException("Error: ссылка или название сервиса пусты!");

            if(_operationSystem.Contains(name))
                throw new ArgumentException("Error: сервис уже существует!" , nameof(name));

            if (!downloadUrl.Contains("https://") || !downloadUrl.Contains("http://"))
                throw new ArgumentException("Error: неверный формат ссылки!", nameof(downloadUrl));

            if(!downloadUrl.Contains('.')) 
                throw new ArgumentException("Error: неверный формат домена в ссылке!" , nameof(downloadUrl));

            _operationSystem.AddRange(name, downloadUrl);
        }
        public void RemoveOperationSystem(string name , string downloadUrl)
        {
            if (!_operationSystem.Contains(name)) throw new ArgumentException("Error: сервис для удаления не найден!", nameof(name));
            if (!downloadUrl.Contains("https://") && downloadUrl.Contains("http://"))
            throw new ArgumentException("Error: неверный форма ссылки для удаления", nameof(downloadUrl));

                var indexRemove = _operationSystem.IndexOf(downloadUrl);
                _operationSystem.RemoveAt(indexRemove);

            _operationSystem.Remove(name);
        }
        public IReadOnlyList<string> GetOperationSystemList()
        {
            return _operationSystem.AsReadOnly();
        }

    }
}