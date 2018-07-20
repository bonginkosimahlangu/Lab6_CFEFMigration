using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab6.Model
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CaurseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string NodifiedBy { get; set; }
    }
}
