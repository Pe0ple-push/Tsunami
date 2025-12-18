using System.Windows.Controls.Primitives;

namespace TsunamiApp
{
    public class AddService
    {
        public static void Add()
        {
            Console.Clear();
            TsunamiList addService = new TsunamiList();

            TsunamiMenu.Menu();
            Console.WriteLine();

            Console.WriteLine("Ваш выбор:\t");
             int adminInput = Convert.ToInt32(Console.ReadLine());

            switch(adminInput)
            {
                case 1:
                    Console.WriteLine("Введите имя софта:\t");
                    string? nameSoft = Console.ReadLine();
                    Console.WriteLine("Введите ссылку скачивания:\t");
                    string? downloadUrl = Console.ReadLine();

                    addService.AddSoftware(nameSoft, downloadUrl);
                    Console.WriteLine("Софт успешно добавлен!");
                    break;
            }
        }
    }
}