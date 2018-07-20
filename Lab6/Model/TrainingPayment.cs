using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab6.Model
{
    public class TrainingPayment
    {
        [Key]
        public int TrainingPaymentID { get; set; }
        public string Description { get; set; }

    }
}
