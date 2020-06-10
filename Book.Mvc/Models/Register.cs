using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book.Mvc.Models
{
    public class Register
    {   
        [Required]
        [DisplayName("Adınız :")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız :")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Email :")]
        public string EMail { get; set; }

        [Required]
        [DisplayName("Parola :")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Parola Tekrar :")]
        public string RePassword { get; set; }

    }
}