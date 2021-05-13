using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MuckScraperMVCApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public byte Credentials { get; set; }

        [DataType(DataType.EmailAddress)]
        public string PrimaryEmail { get; set; }
        
        List<Article> articleLibrary { get; set; }
    }
}
