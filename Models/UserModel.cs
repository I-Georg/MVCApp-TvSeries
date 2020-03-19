using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class UserModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "You need to enter username")]
        public string Username { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need to enter an email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "you need to enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}