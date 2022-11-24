using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_CF_Core.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your mobile number")]
        [Display(Name = "Mobile number")]
        public long MobileNo { get; set; }
        [Required(ErrorMessage = "Please enter your email id")]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Please enter your Manager name")]
        [Display(Name = "Manager Name")]
        public string ManagerName { get; set; }
        public float Salary { get; set; }
        [Required(ErrorMessage = "Please enter user name")]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Please enter confirm your password")]
        //[Display(Name = "Confirm password")]
        //[DataType(DataType.Password)]
        //[NotMapped]
        //[Compare("Password",ErrorMessage ="Passwords doesn't match.Please enter the same password")]
        //public string ConfirmPassword { get; set; }
    }
}
