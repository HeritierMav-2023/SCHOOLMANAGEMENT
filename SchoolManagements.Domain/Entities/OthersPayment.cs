using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("OthersPayment", Schema = "sm")]
    public class OthersPayment : BaseAuditableEntity
    {
        public int? StudentId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountRemaining { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public Student? Student { get; set; }
        public IList<Fee>? fees { get; set; } = new List<Fee>();
        public IList<OtherPaymentDetail>? otherPaymentDetails { get; set; } = new List<OtherPaymentDetail>();

    }
}
