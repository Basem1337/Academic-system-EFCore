using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicDatabaseSystem.Models
{
    //Data Anotations
    public class Department
    {
        [Key]
        public int Dept_ID { get; set; }
        [MaxLength(255)]
        public required string Dept_Name { get; set; }
        [MaxLength(255)]
        public string? Dept_Location { get; set; } = string.Empty;
        [ForeignKey("InstructorsMng")]
        public int? ManagerID { get; set; }
        public virtual Instructor? InstructorsMng { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public override string ToString()
        {
            return Dept_Name;
        }
    }
}
