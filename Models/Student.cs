﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiaiptBac1.Models
{
    [Table]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string Studentname { get; set; }
    }
}