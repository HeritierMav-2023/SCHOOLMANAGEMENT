using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("ExamType", Schema = "sm")]
    public class ExamType : BaseAuditableEntity
    {
        //public int ExamTypeId { get; set; }

        [Required]
        public string? ExamTypeName { get; set; }
        public virtual ICollection<ExamSubject>? ExamSubjects { get; set; }
    }
}
