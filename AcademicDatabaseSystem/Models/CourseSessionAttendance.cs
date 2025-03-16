using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicDatabaseSystem.Models
{
    //Data Anotations
    public class CourseSessionAttendance
    {
        [Key]
        public int CrsSAID { get; set; }
        public int? Grade { get; set; }
        public string? Notes { get; set; } = string.Empty;
        [ForeignKey("CrsSID")]
        public int CrsSessionID { get; set; }
        public CourseSession CrsSID { get; set; } = null!;
        [ForeignKey("Student")]
        public int StdID { get; set; }
        public Student Student { get; set; } = null!;

    }
}
