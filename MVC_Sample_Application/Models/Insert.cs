using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Sample_Application.Models
{
    public class Insert
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="enter the Name")]
        public string Name { get; set; }
        [Range(10,100,ErrorMessage ="enter the age")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage ="enter the email address")]
        public string Email { get; set; }
        public string Message { get; set; }

    }
}