﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C42_G01_EF02.Entities
{
    [Table("Courses", Schema = "dbo")]
    internal class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [ForeignKey("Topics")]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
