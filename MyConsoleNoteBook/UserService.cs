using System;
using System.Collections.Generic;
using System.Linq;

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
            try
            {
                using DB.MsSqlContext db = new DB.MsSqlContext();
                return  db.Users.Any(x => x.Login == login);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка  обращения  к базе данных");
            }
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

            try
            {
                name = "пользователь не найден";
                using DB.MsSqlContext db = new DB.MsSqlContext();
                var f =    db.Users.Any(x => x.Login == login && x.Password == password);
                if (f == true)
                {
                    name = db.Users.Single(x => x.Login == login).UserName;
                }

                return f;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка  обращения  к базе данных");
            }


        }

       
    }
}