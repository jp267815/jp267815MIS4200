using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jp267815MIS4200.Models
{
    public class Grade
    {

        
        [Key]
        public int gradeId { get; set; }
        public int studentId { get; set; }
        public int courseId { get; set; }
        public string letterGrade { get; set; }

        //linking the Grade to the Course
        public virtual Course Course { get; set; }

        //linking the Grade to the student

        public virtual Student Student { get; set; }





    }
}