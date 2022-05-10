using System;
using System.ComponentModel.DataAnnotations;

namespace UsersProfileApp.ViewModels
{
    public class UsersViewModel
    {
        public Guid UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
