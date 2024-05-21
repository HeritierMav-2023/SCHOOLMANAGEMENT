using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("ExamScheduleStandard",Schema = "sm")]
    public class ExamScheduleStandard : BaseAuditableEntity
    {
        //public int ExamScheduleStandardId { get; set; }
        public int? ExamScheduleId { get; set; }
        public int StandardId { get; set; }
        public virtual Standard? Standard { get; set; }
        public virtual ExamSchedule? ExamSchedule { get; set; }
        public virtual ICollection<ExamSubject>? ExamSubjects { get; set; } = [];
    }
}
