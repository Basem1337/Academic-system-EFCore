using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicDatabaseSystem.Models
{
    //Data Anotation + Fleunt API
    public class StdCrs
    {
        [ForeignKey("Course")]
        public int CrsID { get; set; }
        [ForeignKey("Student")]
        public int StdID { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}
