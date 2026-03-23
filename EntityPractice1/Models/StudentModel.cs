using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityPractice1.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name"), StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Pass { get; set; }
        public string Gender { get; set; } 
        public DateTime dob { get; set; }
        public string profession { get; set; }
    }
}