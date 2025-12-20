namespace TsunamiApp
{
    public class AdminPanel
    {
        //private List<string> _adminCommand = new List<string>();
        //public void AdminCommand()
        //{
        //    _adminCommand.Add(" --admin --newCommand --Panel");
        //    _adminCommand.Add(" --admin --newService");
        //    _adminCommand.Add(" --admin --removeService");
        //    _adminCommand.Add(" --admin --newCategory");
        //    _adminCommand.Add(" --admin --removeCategory");
        //    _adminCommand.Add(" --admin --newCommand --Download");
        //    _adminCommand.Add(" --admin --removeCommand --Download");
        //}

        //public void AddAdmineCommand(string command)
        //{
        //    if(string.IsNullOrWhiteSpace(command))
        //    {
        //        throw new ArgumentNullException("Error: новая команда не может пустовать..." , nameof(command));
        //    }
        //    if(command.Contains(" --admin") || command.Contains("--admin"))
        //    {
        //        throw new ArgumentException("Error: неверный формат новой команды..." , nameof (command));
        //    }
        //    _adminCommand.Add(command);
        //}
        //public void RemoveAdminCommand(string command)
        //{
        //    if(string.IsNullOrWhiteSpace(command))
        //    {

        //    }
        //}


        public static void Panel()
        {
            while(true)
            {
                Console.Clear();
                //banner
                

                    Console.Write("=>:\t");
                    var adminInput = Console.ReadLine();

                switch(adminInput) //АДМИН ПИШЕТ КОМАНДУ => ПЕРЕНОС
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