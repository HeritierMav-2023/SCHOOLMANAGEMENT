using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("AcademicMonth", Schema = "sm")]
    public class AcademicMonth : BaseAuditableEntity
    {
        public int MonthId { get; set; }
        public String? MonthName { get; set; }
        public MonthlyPayment? monthlyPayment { get; set; }

    }
}