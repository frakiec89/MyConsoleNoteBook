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
                    case "exit": return;
                    default: Console.WriteLine("команда не опознана"); break;
                }
            }
        }

        private static void MenuPrint() // вывод на  экран  список  доступных команд
        {
            string exit = "exit";
            string login = "log-in"; // команды

            Console.WriteLine($"Для выхода из программы введите \"{exit}\"");
            Console.WriteLine($"Для входа в систему  введите  \"{login}\"");
        }

        private static void Authorization()
        {

        }

        private static void Registration()
        {
           Console.WriteLine("добавление  нового пользователя");
           string name = GetStringConsole("Укажите имя пользователя");
           string password = GetPassword();

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
