using System.Net.Mail;
using System;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskLogsoft.Models
{
    public enum UserStatus
    {
        Active,
        Inactive
    }


    public class User
    {
        [Key]
        public required int ID {get; set;}
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }
        public required string Password { get; set; } 
        public required int GroupID { get; set; }
        public required int PrivillageGroupID { get; set; }
        public required DateTime DateCreated { get; set; }
        public required UserStatus Status { get; set; } = UserStatus.Active;
    }
}
