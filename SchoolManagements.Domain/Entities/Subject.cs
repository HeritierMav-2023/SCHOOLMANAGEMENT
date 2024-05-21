using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("Subject", Schema = "sm")]
    public class Subject : BaseAuditableEntity
    {
        //public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public int? SubjectCode { get; set; }
        public int? StandardId { get; set; }
        public virtual Standard? Standard { get; set; }
        public virtual ICollection<ExamSubject>? ExamSubjects { get; set; }
    }
}
