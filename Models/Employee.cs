using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace EmployeeRegistrationApp.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Required")]
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Required")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Invalid MailID")]
        public string EmpEmail { get; set; }
    }
}