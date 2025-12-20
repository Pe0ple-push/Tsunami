using System.Reflection.Metadata.Ecma335;

namespace TsunamiApp
{
    public class AdminPanel
    {
        public static void Panel()
        {
            while(true)
            {
                Console.Clear();
                //banner
                Console.WriteLine(" --admin --newService");
                Console.WriteLine(" --admin --removeService");
                Console.WriteLine(" --admin --newCategory");
                Console.WriteLine(" --admin --removeCategory\n");

                    Console.Write("=>:\t");
                    var adminInput = Console.ReadLine();

                switch(adminInput)
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