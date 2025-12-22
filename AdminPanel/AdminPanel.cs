namespace TsunamiApp
{
    public class AdminPanel
    {
        private static List<string> _adminCommand = new List<string>();
        static AdminPanel()
        {
            _adminCommand.Add(" --admin --newCommand --Panel");
            _adminCommand.Add(" --admin --newService");
            _adminCommand.Add(" --admin --removeService");
            _adminCommand.Add(" --admin --newCategory");
            _adminCommand.Add(" --admin --removeCategory");
            _adminCommand.Add(" --admin --newCommand --Download");
            _adminCommand.Add(" --admin --removeCommand --Download");
        }
        public static void RunAdminPanelCommand()
        {
            foreach (string command in _adminCommand) Console.WriteLine(command);
        }

        public static void Panel()
        {
            while(true)
            {
                Console.Clear();
                //banner

                RunAdminPanelCommand();

                Console.WriteLine("\n“˚ ÛÊÂ ‚ Ô‡ÌÂÎË");
                    Console.Write("=>:\t");
                    var adminInput = Console.ReadLine();

                switch(adminInput) //¿ƒÃ»Õ œ»ÿ≈“  ŒÃ¿Õƒ” => œ≈–≈ÕŒ—
                {
                    case "--admin --newService": AddService.Add(); break;
                    case "--admin --removeService": RemoveService.Remove(); break;
                    case "--admin --newCategory": AddCategory.Add(); break;
                    case "--admin --removeCategory": RemoveCategory.Remove(); break;

                        default:
                        //admin non error
                        continue;
                }//switch end
                break;
            }
        }//Panel end
    }
}