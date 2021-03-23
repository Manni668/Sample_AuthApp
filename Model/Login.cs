using System;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationAPI.Model
{
    public class Login
    { 
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

