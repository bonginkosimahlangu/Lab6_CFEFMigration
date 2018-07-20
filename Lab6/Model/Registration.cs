using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab6.Model
{
    public class Registration
    {
        [Key]
        public int RegistrationID { get; set; }
        [ForeignKey("Delegate")]
        public int DelegateID { get; set; }
        [ForeignKey("Training")]
        public int TrainingID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateNodified { get; set; }
    }
}
