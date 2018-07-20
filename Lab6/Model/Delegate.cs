using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab6.Model
{
    public class Delegate
    {
        [Key]
        public int DelegateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        [ForeignKey("Dietary")]
        public int DietaryID { get; set; }
        [ForeignKey("AddressDetail")]
        public int AddressDetailID { get; set; }

    }
}
