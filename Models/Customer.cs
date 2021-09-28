using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiaiptBac1.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string Customername { get; set; }
        public string Address { get; set; }
        public DateTime CustomerBirth { get; set; }

    }
}