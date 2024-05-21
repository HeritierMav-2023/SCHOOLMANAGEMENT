using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("StaffSalary", Schema = "sm")]
    public class StaffSalary : BaseAuditableEntity
    {
        // Per individual Staff's salary prototype

        //public int StaffSalaryId { get; set; }
        public string? StaffName { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? FestivalBonus { get; set; }
        public decimal? Allowance { get; set; }
        public decimal? MedicalAllowance { get; set; }
        public decimal? HousingAllowance { get; set; }
        public decimal? TransportationAllowance { get; set; }
        public decimal? SavingFund { get; set; } = 0;
        public decimal? Taxes { get; set; } = 0;
        // Calculated property
        public decimal? NetSalary { get; set; }

    }
}