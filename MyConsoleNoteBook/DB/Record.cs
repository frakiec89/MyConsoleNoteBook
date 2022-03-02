using System;
using System.ComponentModel.DataAnnotations;

namespace MyConsoleNoteBook.DB
{
    public class Record
    {
        [Key]
        public int RecordId { get; set; }   
        public string Content { get; set; }
        public DateTime dateTime { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


        public override string ToString()
        {
            return $"дата {dateTime}, контент \n{Content}" +
                $"\n{User.UserName}\n";
        }
    }
}