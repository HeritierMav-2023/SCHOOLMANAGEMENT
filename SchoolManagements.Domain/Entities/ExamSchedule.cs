using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("ExamenSchedule",Schema = "sm")]
    public class ExamSchedule : BaseAuditableEntity
    {
        [Required]
        public string? ExamScheduleName { get; set; }

        public virtual ICollection<ExamScheduleStandard>? ExamScheduleStandards { get; set; } = [];
    }
}
