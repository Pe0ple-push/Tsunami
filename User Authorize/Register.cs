using System.Reflection.Metadata.Ecma335;

namespace TsunamiApp
{
    public class Register
    {
        private static void UserRegister(string? name, string? pass, string? repeatPass, string? key , string? repeatKey)
        {
            bool isUserReg = true; //user reg bool
            while(isUserReg)
            {
                Console.Clear();
                //banner

                Console.Write("Придумайте логин:\t");
                name = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: ваш логин пуст..."); Console.ReadKey(); continue;
                }
                if(name.Length <= 3)
                {
                    Console.WriteLine("Error: ваш логин слишком короткий..."); Console.ReadKey(); continue;
                }
                if(name.Length >= 15)
                {
                    Console.WriteLine("Error: ваш логин слишком длинный..."); Console.ReadKey(); continue;
                }
                if(int.TryParse(name, out var err))
                {
                    Console.WriteLine("Error: логин не может состоять из цифр..."); Console.ReadKey(); continue;
                }
                break;

            }//end while

            while(true)
            {
                Console.Clear();
                //banner

                Console.Write("Придумайте пароль:\t");
                pass = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace (pass))
                    {
                        Console.WriteLine("Error: пароль не может быть пуст..."); Console.ReadKey(); continue;
                    }
                    if(int.TryParse (pass, out var err))
                    {
                        Console.WriteLine("Error: введите пароль не только из цифр..."); Console.ReadKey(); continue;
                    }
                    if(pass.Length <= 3)
                    {
                        Console.WriteLine("Error: слишком слабый пароль..."); Console.ReadKey(); continue;
                    }
                    if(!pass.Contains('$') || !pass.Contains('@') || !pass.Contains('&') || !pass.Contains('#'))
                    {
                        Console.WriteLine("Error: пароль не содержит специальные символы ($ | @ | & | #) "); Console.ReadKey(); continue;
                    }

                    bool PassRepeat = true;

                    while(PassRepeat)
                    {
                        Console.Clear();
                        //banner

                        Console.Write("Повторите пароль:\t");
                        repeatPass = Console.ReadLine();

                            if(pass != repeatPass)
                            {
                               Console.WriteLine("Error: пароли не совпадают..."); Console.ReadKey(); continue;
                            }
                            break;
                    }
                    break;
            }//while password

            while(true)//key
            {
                Console.Clear();
                //banner

                    Console.Write("Ваш приватный ключ: a7dfba8tdf => сохраните для входа\n");
                    Console.WriteLine("Нажмите любую клавишу для продолжения..."); Console.ReadKey(); Console.Clear();

                Console.Write("Введите приватный ключ:\t");
                repeatKey = Console.ReadLine();

                key = "a7dfba8tdf";

                    if (repeatKey != key)
                    {
                        Console.WriteLine("Error: неверный приватный ключ..."); Console.ReadKey(); continue;
                    }
                    break;
            }

            Console.Clear();
            Console.WriteLine($"Успешная регистрация под логином {name}!");

                Console.WriteLine($"Сохраните данный ключ в txt файл => {key}"); Console.ReadKey();

            TsunamiMenu.Menu(); //переход к функционалу ПО
        }
        public void RunUserRegister(string? name, string? pass, string? repeatPass, string? Key, string? repeatKey)
        {
           UserRegister(name, pass, repeatPass, Key, repeatKey);  
        }
    }
}