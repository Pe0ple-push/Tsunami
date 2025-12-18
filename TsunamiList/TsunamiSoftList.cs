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

        public void AddOperationSystem(string name, string downloadUrl)
        {

        }
        public void RemoveOperationSystem(string name, string downloadUrl)
        {

        }
        public IReadOnlyList<string> GetOperationSystemList()
        {
            return _operationSystem.AsReadOnly();
        }

    }
}