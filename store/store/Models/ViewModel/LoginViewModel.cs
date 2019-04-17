using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using store.Models;

namespace store.Models.ViewModel
{
    public class LoginViewModel
    {
       
        [Required(AllowEmptyStrings = false, ErrorMessage = "Account required")]
        public string Account { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}