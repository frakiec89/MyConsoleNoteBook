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

        public static void AddUser(string name, string login, string password)
        {
            try
            {
                using DB.MsSqlContext db = new DB.MsSqlContext();
                db.Users.Add(
                    new DB.User()
                    {
                        Password = password,
                        Login = login,
                        UserName = name,
                        DateRegistration = DateTime.Now
                    }
                    );
                db.SaveChanges(); // отправить  объект  в  бд 
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка  добавление  в  базу данных");
            }
        }

        internal static bool Authorization(string login, string password, out string name)
        {
            throw new NotImplementedException();
        }
    }
}