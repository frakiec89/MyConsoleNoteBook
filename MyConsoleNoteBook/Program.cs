using System;

namespace MyConsoleNoteBook
{
    internal class Program
    {
        // frakiec89 ник нейм  на  гите
        static void Main(string[] args)
        {
            Console.WriteLine("Моя записная книжка");
            while(true)
            {
                MenuPrint();

                switch(Console.ReadLine().ToLower().TrimStart().TrimEnd())
                {
                    case "log-in": Authorization(); break;
                    case "registration": Registration(); break;
                    case "exit": return;

                    default: Console.WriteLine("команда не опознана"); break;
                }
            }
        }

        private static void MenuPrint() // вывод на  экран  список  доступных команд
        {
            string exit = "exit";
            string login = "log-in"; // команды
            string registration = "registration";

            Console.WriteLine($"Для выхода из программы введите \"{exit}\"");
            Console.WriteLine($"Для входа в систему  введите  \"{login}\"");
            Console.WriteLine($"Для регистрации в системе  введите  \"{registration}\"");
        }

        private static void Authorization()
        {
            Console.WriteLine("Вход  в систему:");
            string login = GetStringConsole("Укажите логин пользователя");
            string password = GetStringConsole("Укажите пароль");
            string name = string.Empty;
            try
            {
                if (UserService.Authorization(login, password, out name))
                {
                    Console.WriteLine($"добро пожаловать {name}");
                }
                else
                {
                    Console.WriteLine($"Нам очень жаль но пользователь не  найден");
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }

        private static void Registration()
        {
           Console.WriteLine("добавление  нового пользователя");
           string name = GetStringConsole("Укажите имя пользователя");
           string login = GetStringConsole("Укажите логин пользователя");
           string password = GetPassword();

            try
            {
                if (UserService.IsCheckUser(login) == false)
                {
                    UserService.AddUser(name, login, password);
                    Console.WriteLine("Ура - пользователь добавлен");
                }
                else
                {
                    Console.WriteLine("нам очень  жаль ( но такой  логин уже есть");
                    Console.WriteLine("не  отчаивайтесь, давайте попробуем еще раз");
                    Registration(); // рекурсивно 
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static string GetPassword()
        {
            string p1 = GetStringConsole("введите пароль");
            string p2 = GetStringConsole("повторите пароль");

            if (p1 == p2)
                return p1;
            else
            {
                Console.WriteLine("пароли не  совпадают  - не  надо  так (");
                Console.WriteLine("давайте попробуем еще раз");
                return GetPassword();
            }
        }

        private static string GetStringConsole(string message)
        {
            Console.WriteLine(message);
            string buffer = Console.ReadLine(); 
            if(string.IsNullOrWhiteSpace(buffer))
            {
                Console.WriteLine("вы ввели пустой параметр - не  надо  так (");
                Console.WriteLine("давайте попробуем еще раз");
                return GetStringConsole(message); // рекурсивно
            }
            return buffer.TrimStart().TrimEnd();   // frakiec89 ник нейм  на  гите
        }
    }
}
