using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{
    public class StaffSalaryDto: IMapFrom<StaffSalary>
    {
        public int Id { get; set; }
        public string? StaffName { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? FestivalBonus { get; set; }
        public decimal? Allowance { get; set; }
        public decimal? MedicalAllowance { get; set; }
        public decimal? HousingAllowance { get; set; }
        public decimal? TransportationAllowance { get; set; }
        public decimal? SavingFund { get; set; } = 0;
        public decimal? Taxes { get; set; } = 0;
        public decimal? NetSalary { get; set; }
    }
}
