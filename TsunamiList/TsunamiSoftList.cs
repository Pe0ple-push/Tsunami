using System.CodeDom;

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

        public void AddOperationSystem(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Error: название сервиса пустует!");

            if(_operationSystem.Contains(name))
                throw new ArgumentException("Error: сервис уже существует!" , nameof(name));

            _operationSystem.Add(name);
        }
        public void RemoveOperationSystem(string name)
        {
          if(!_operationSystem.Contains(name))
            {
                throw new ArgumentException("Error: такого сервиса не существует...", nameof(name));
            }
          if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Error: введите имя сервиса для удаления...", nameof(name));
            }
            _operationSystem.Remove(name);
        }
        public IReadOnlyList<string> GetOperationSystemList()
        {
            return _operationSystem.AsReadOnly();
        }

    }
}