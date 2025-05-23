﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF02.Entities
{
    [Table("Stud_Courses",Schema ="dbo")]
    internal class Stud_Course
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [StringLength(2)] 
        public string Grade { get; set; }
    }
}
