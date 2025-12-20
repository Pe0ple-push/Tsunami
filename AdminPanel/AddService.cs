namespace TsunamiApp
{
    public class AddService
    {
        public static void Add()
        {

            try
            {
                Console.Clear();
                TsunamiList addService = new TsunamiList();
                TsunamiMenu addEnter = new TsunamiMenu();

                    Console.Write("\nВведите команду открытия категории:\t");
                    var adminInput = Console.ReadLine();

                addEnter.AddSoftware(adminInput); //проверка на сущ категории для добавления сервиса
                
                switch(adminInput)
                {
                    case "--admin --category --OperationSystem":
                        Console.Write("\nВведите команду для нового сервиса:\t");
                            var adminInputServiceName = Console.ReadLine();

                        addService.AddOperationSystem(adminInputServiceName);
                        Console.WriteLine($"Сервис {adminInputServiceName} успешно добавлен!");
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