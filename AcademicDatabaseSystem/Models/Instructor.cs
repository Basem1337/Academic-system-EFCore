using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicDatabaseSystem.Models
{
    //External Configuration [Fluent API]
    public class Instructor
    {
        [Key]
        public int InsID { get; set; }
        [MaxLength(255)]
        public string? InsFName { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? InsLName { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? Phone { get; set; } = string.Empty;
        public decimal? Salary { get; set; }
        [ForeignKey("Department")]
        public int? Dept_ID { get; set; }
        public Department? Department { get; set; }
        public Department? ManagedAt { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

    }
}
