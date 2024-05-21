using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("DueBalance", Schema = "sm")]
    public class DueBalance : BaseAuditableEntity
    {
        public int? StudentId { get; set; }
        public decimal? DueBalanceAmount { get; set; }
        public DateTime? LastUpdate { get; set; } = DateTime.Now;
        public Student? Student { get; set; }
    }
}