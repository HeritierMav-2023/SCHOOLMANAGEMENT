
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("MonthlyPayment", Schema = "sm")]
    public class MonthlyPayment : BaseAuditableEntity
    {
        //public int MonthlyPaymentId { get; set; }
        public int? StudentId { get; set; }
        public decimal TotalFeeAmount { get; set; }
        public decimal Waver { get; set; } = 0;
        public decimal PreviousDue { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountRemaining { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public Student? Student { get; set; }
        public IList<Fee> fees { get; set; }
        public IList<AcademicMonth> academicMonths { get; set; }
        public IList<PaymentMonth>? paymentMonths { get; set; }
        public IList<PaymentDetail>? PaymentDetails { get; set; }
        public IList<DueBalance>? dueBalances { get; set; }
    }
}
