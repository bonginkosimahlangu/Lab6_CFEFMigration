using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab6.Model
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string Description { get; set; }
        [ForeignKey("Province")]
        public int PrivinceID { get; set; }
    }
}
