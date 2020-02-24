using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jp267815MIS4200.Models
{
    public class Student
    {
        public System.Guid SID { get; set; }

        [Key]
       
        public int studentId { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "Student first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Student last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display (Name = "Most used email address")]
        [Required(ErrorMessage = "Must enter an email address")]
        public string email { get; set; }

        [Display(Name = "Mobile phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3} - \d{4}$")]
        [Required(ErrorMessage = "Phone numbers must be in the format (xxx) xxxx - xxx or xxx-xxx-xxxx ")]
        public string phone { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Must enter an address")]
        public string address { get; set; }
        [StringLength(50)]

        
        [Required(ErrorMessage = "Must enter a city")]
        public string city { get; set; }

        [StringLength(2, MinimumLength =2, ErrorMessage = "State must be two characters")]
        public string state { get; set; }

      


        [Required(ErrorMessage = "Must enter a zip")]
        public int zip { get; set; }

        public int courseId { get; set; }

        public string fullName { get { return lastName + ", " + firstName; }  }
        public ICollection<Grade> Grade { get; set; }


    }
}