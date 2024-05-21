using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("Standard", Schema = "sm")]
    public class Standard : BaseAuditableEntity
    {
        //public int StandardId { get; set; } 
        [Required]
        public string? StandardName { get; set; }
        public string? StandardCapacity { get; set; }
        public virtual ICollection<Subject>? Subjects { get; set; }
        public virtual ICollection<ExamScheduleStandard>? ExamScheduleStandards { get; set; }
        public virtual ICollection<Student>? Students { get; set; } = [];
    }
}
