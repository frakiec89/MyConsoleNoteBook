using System;

namespace MyConsoleNoteBook
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Моя записная книжка");
            while(true)
            {
                MenuPrint();

                switch(Console.ReadLine().ToLower().TrimStart().TrimEnd())
                {
                    case "exit": return;
                    default: Console.WriteLine("команда не опознана"); break;
                }

            }
        }

        private static void MenuPrint() // вывод на  экран  список  доступных команд
        {
            string exit = "exit"; // команды
            Console.WriteLine($"Для выхода из программы введите \"{exit}\"");
        }
    }
}
