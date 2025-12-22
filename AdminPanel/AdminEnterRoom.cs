using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace TsunamiApp
{
    public class SecretRoom
    {
        public static void AdminSecretCommand()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Привет , ты попал на админку , это временное сообщение");
                //BANNER
                Console.WriteLine("\n=>:\t");

                var adminInput = Console.ReadLine();
                switch (adminInput)
                {
                    case "EPZVdBQ8pEJOCP1ofFEZD19GxsEOAfaM": AdminPanel.Panel(); break;     //key admin ENCRYPTED !!!!!!!!!!!
                        default: continue;
                }
            }

        }
    }
}