using System;

namespace MyConsoleNoteBook
{
    internal class UserService
    {
        /// <summary>
        /// проверяет повторение  пользователя в  бд
        /// </summary>
        /// <param name="login"></param>
        /// <returns>истина если такой пользователь есть</returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static bool IsCheckUser(string login)
        {
            throw new NotImplementedException();
        }

        internal static void AddUser(string name, string login, string password)
        {
            throw new NotImplementedException();
        }

        internal static bool Authorization(string login, string password, out string name)
        {
            throw new NotImplementedException();
        }
    }
}