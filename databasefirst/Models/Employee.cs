using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace databasefirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [Display (Name = "Employee Name")]
        [Required (ErrorMessage ="Employee Name Can't Empty")]
        public string Name { get; set; }
        [Display(Name = "Employee Email")]
        [Required(ErrorMessage = "Employee Email Address Can't Empty")]
        public string Email { get; set; }
        [Display(Name = "Employee Address")]
        [Required(ErrorMessage = "Employee Address Can't Empty")]
        public string Address { get; set; }
        [Display(Name = "Employee Gender")]
        [Required(ErrorMessage = "Employee Gender Can't Empty")]
        public string Gender { get; set; }
    }
}
