using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("OtherPaymentDetail", Schema = "sm")]
    public class OtherPaymentDetail : BaseAuditableEntity
    {
     
        public int PaymentDetailId { get; set; }
        public int OthersPaymentId { get; set; }
        public string FeeName { get; set; }
        public decimal FeeAmount { get; set; }

    }
}