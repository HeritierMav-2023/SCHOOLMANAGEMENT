using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("ExamSubject",Schema = "sm")]
    public class ExamSubject : BaseAuditableEntity
    {

        public int? ExamScheduleStandardId { get; set; }
        public int SubjectId { get; set; }
        public int ExamTypeId { get; set; }
        public DateTime? ExamDate { get; set; } = DateTime.Now;
        public DateTime? ExamStartTime { get; set; } = DateTime.Now;
        public DateTime? ExamEndTime { get; set; } = DateTime.Now;

        public virtual Subject? Subject { get; set; }
        public virtual ExamType? ExamType { get; set; }
        public virtual ExamScheduleStandard? ExamScheduleStandard { get; set; }
    }
}
