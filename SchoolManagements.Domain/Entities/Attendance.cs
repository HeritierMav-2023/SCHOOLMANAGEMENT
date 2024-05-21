using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("Attendance", Schema = "sm")]
    public class Attendance : BaseAuditableEntity
    {
        // Per day attendance record
       // public int AttendanceId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public AttendanceType Type { get; set; } = AttendanceType.Student;
        [Required]
        public int AttendanceIdentificationNumber { get; set; } = 111;
        public string? Description { get; set; }
        public bool IsPresent { get; set; } = true;
    }

    public enum AttendanceType
    {
        Student,
        Staff
    }
}
