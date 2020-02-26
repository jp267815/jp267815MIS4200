using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jp267815MIS4200.Models
{
    public class Course
    {
       
        [Key]
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseDescription{ get; set; }

        public string instructorId { get; set; }

        public int creditHours { get; set; }



        public ICollection<Grade> Grade { get; set; }

    }
}