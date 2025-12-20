namespace TsunamiApp
{
    public class RemoveService
    {
        public static void Remove()
        {
            try
            {
                TsunamiList removeService = new TsunamiList();
                TsunamiMenu removeEnter = new TsunamiMenu();

                Console.Write("\nВведите категорию для удаления сервиса:\t");
                var adminInput = Console.ReadLine();

                removeEnter.AddSoftware(adminInput);

                switch(adminInput)
                {
                    case "Operating system":
                        Console.Write("\nВведите имя сервиса для удаления:\t");
                        var adminNameRemove = Console.ReadLine();

                        Console.Write("\nВведите ссылку для удаления:\t");
                        var adminUrlRemove = Console.ReadLine();

                        removeService.RemoveOperationSystem(adminNameRemove , adminUrlRemove);
                        Console.WriteLine($"Сервис {adminNameRemove} удалён!");
                        break;

                    case "Design and Graphics": break;
                    case "Video and Audio": break;
                    case "Development": break;
                    case "Utilities": break;
                    case "Browsers": break;
                    case "Entertainments": break;
                    case "Office Applications": break;
                    case "Security": break;

                }

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}