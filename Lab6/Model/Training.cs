using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab6.Model
{
    public class Training
    {
        [Key]
        public int TrainingID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Venue { get; set; }
        public int Seats { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public double Cost { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        [ForeignKey("TrainingPayment")]
        public int TrainingPaymentID { get; set; }
    }
}
