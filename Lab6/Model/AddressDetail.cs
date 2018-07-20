using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab6.Model
{
    public class AddressDetail
    {
        [Key]
        public int AddressDetailID { get; set; }
        public string AddressLine1 { get; set; }
        [ForeignKey("AddressType")]
        public int AddressTypeID { get; set; }
        [ForeignKey("Address")]
        public int AddressID { get; set; }

    }
}
