namespace TsunamiApp
{
    public class AddCategory
    {
        public static void Add()
        {
            try
            {
                TsunamiMenu adminAddCategory = new TsunamiMenu();
                Console.Write("Введите команду для новой категории:\t");

                string? adminInput = Console.ReadLine();
                //adminAddCategory.RunAddSoftCategory(adminInput);

                Console.Clear();
                Console.WriteLine($"Категория: {adminInput} добавлена!");

                //Отправить результат в БД
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            
        }
    }
}

    