using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MuckScraperMVCApp.Models
{
    public class User : IdentityUser<int>
    {
        public DateTime RegistrationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ProfilePhoto { get; set; }
        ICollection<Article> Library { get; set;}
    }
}
