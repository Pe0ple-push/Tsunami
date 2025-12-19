namespace TsunamiApp
{
    public class AddCategory
    {
        public static void Add()
        {
            try
            {
                TsunamiMenu adminAddCategory = new TsunamiMenu();
                Console.Write("Введите новую категорию:\t");

                string? adminInput = Console.ReadLine();
                adminAddCategory.AddSoftCategory(adminInput);

                Console.Clear();
                Console.WriteLine($"Категория: {adminInput} добавлена!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            
        }
    }
}

    