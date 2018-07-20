using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab6.Model
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [ForeignKey("Province")]
        public int ProvinceID { get; set; }
        [ForeignKey("City")]
        public int CityID { get; set; }

    }
}
