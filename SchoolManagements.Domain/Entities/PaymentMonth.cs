using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("PaymentMonth", Schema = "sm")]
    public class PaymentMonth : BaseAuditableEntity
    {
        //public int PaymentMonthId { get; set; }
        public int MonthlyPaymentId { get; set; }
        public string MonthName { get; set; }
    }
}