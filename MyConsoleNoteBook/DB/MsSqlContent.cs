using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleNoteBook.DB
{
    public class MsSqlContent
    {
        static  string server = "192.168.10.134";
        static string database = "Ahtyamov_for_IS-20_02_notebook";
        static string user = "stud";
        static string password = "stud";


        private string GetConnectionString (string server , string database, string user, string password)
        {
            return $"Server = {server}; Database={database};User Id = {user}; Password={password}";
        }
    }
}
