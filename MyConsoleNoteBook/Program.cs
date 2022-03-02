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
                    case "log in": Authorization(); break;
                    case "exit": return;
                    default: Console.WriteLine("команда не опознана"); break;
                }
            }
        }

        private static void MenuPrint() // вывод на  экран  список  доступных команд
        {
            string exit = "exit";
            string login = "log in"; // команды

            Console.WriteLine($"Для выхода из программы введите \"{exit}\"");
            Console.WriteLine($"Для входа в систему  введите  \"{login}\"");
        }

        private static void Authorization()
        {
           Console.WriteLine("добавление  нового пользователя");
            string name = GetStringConsole("Укажите имя пользователя");
        }

        private static string GetStringConsole(string message)
        {
            Console.WriteLine(message);
            string buffer = Console.ReadLine(); 
            if(string.IsNullOrWhiteSpace(buffer))
            {
                Console.WriteLine("вы ввели пустой параметр - не  надо  так (");
                Console.WriteLine("давайте попробуем еще раз");
                return GetStringConsole(message);
            }
            return buffer.TrimStart().TrimEnd();
        }
    }
}
