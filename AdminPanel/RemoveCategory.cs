namespace TsunamiApp
{
    public class RemoveCategory
    {
        public static void Remove()
        {
            try
            {
                Console.Clear();
                TsunamiMenu removeCategory = new TsunamiMenu();
                Console.Write("Введите команду категории:\t");

                var adminRemove = Console.ReadLine();
                //removeCategory.RunRemoveSoftCategory(adminRemove);

                    Console.Clear();
                    Console.WriteLine($"Категория {adminRemove} удалена!");

                //Отправить результат в БД

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}