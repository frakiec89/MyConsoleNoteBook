using Microsoft.EntityFrameworkCore;

namespace MyConsoleNoteBook.DB
{
    public class MsSqlContext : DbContext
    {
        static string server = "192.168.10.134";
        static string database = "Ahtyamov_for_IS-20_02_notebook"; // новая -  у каждого  своя
        static string user = "stud";
        static string password = "stud";

        public MsSqlContext() {
        
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(GetConnectionString(server,database,user,password));
        }


        private string GetConnectionString (string server , string database, string user, string password)
        {
            return $"Server = {server}; Database={database};User Id = {user}; Password={password}; connect timeout=5;";
        }


        public DbSet<User> Users { get; set; }
    }
}

//команды миграции 
//add-migration 
//update-database