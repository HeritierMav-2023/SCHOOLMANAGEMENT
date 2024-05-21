using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("PaymentDetail", Schema = "sm")]
    public class PaymentDetail : BaseAuditableEntity
    {
        //public int PaymentDetailId { get; set; }
        public int MonthlyPaymentId { get; set; }
        public string FeeName { get; set; }
        public decimal FeeAmount { get; set; }

    }
}