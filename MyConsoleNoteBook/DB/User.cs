
using System;
using System.ComponentModel.DataAnnotations;

namespace MyConsoleNoteBook.DB
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }   
        public  DateTime DateRegistration { get; set; } 
    }
}