using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("Fee", Schema = "sm")]
    public class Fee : BaseAuditableEntity
    {
        //public int FeeId { get; set; }
        public int FeeTypeId { get; set; }
        public int StandardId { get; set; }
        public Frequency PaymentFrequency { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public Standard? standard { get; set; }
        public FeeType? feeType { get; set; }
        public MonthlyPayment? monthlyPayment { get; set; }
        public OthersPayment? othersPayment { get; set; }

    }

    public enum Frequency
    {
        Monthly,
        Yearly,
        Quarterly,
        Semesterly,
        Biannually,
        Custom
    }
}
