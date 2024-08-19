using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace C42_G01_EF02.Entities
{
    [Table("Departments", Schema = "dbo")]
    internal class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime HireDate { get; set; }


        // Collection navigation property for all instructors in the department
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
