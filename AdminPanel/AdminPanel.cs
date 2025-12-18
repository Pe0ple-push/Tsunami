namespace TsunamiApp
{
    public class AdminPanel
    {
        public static void Panel()
        {
            Console.Clear();
            Console.WriteLine(" [1] tsunami --newService");
            Console.WriteLine(" [2] tsunami --removeService");
            Console.WriteLine(" [3] tsunami --newCategory");
            Console.WriteLine(" [4] tsunami --removeCategory");
            int adminInput = Convert.ToInt32(Console.ReadLine());

            switch(adminInput)
            {
                case 1: AddService.Add(); break;
                case 2: RemoveService.Remove(); break;
                case 3: AddCategory.Add(); break;
                case 4: RemoveCategory.Remove(); break;

                default:
                throw new ArgumentException("Error: такой команды не существует!");
            }//switch end

        }//Panel end
    }
}