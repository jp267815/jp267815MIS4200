using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jp267815MIS4200.Models
{
    public class Student
    {

        [Key]
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int zip { get; set; }

        public int courseId { get; set; }
        public ICollection<Grade> Grade { get; set; }


    }
}