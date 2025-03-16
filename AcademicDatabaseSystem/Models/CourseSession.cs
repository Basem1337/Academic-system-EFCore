using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicDatabaseSystem.Models
{
    //Data Anotation + Fleunt API
    public class CourseSession
    {
        [Key]
        public int CrsSID { get; set; }
        [ForeignKey("Instructor")]
        public int? InsID { get; set; }
        [ForeignKey("Course")]
        public int CrsID { get; set; }
        [MaxLength(255)]
        public string? Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
        public virtual ICollection<CourseSessionAttendance> CrsSA { get; set; } = new HashSet<CourseSessionAttendance>();


    }
}
