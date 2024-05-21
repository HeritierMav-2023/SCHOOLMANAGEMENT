using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{
    public class StaffDto :IMapFrom<Staff>
    {
        public int Id { get; set; }
        public string StaffName { get; set; } = default!;

        public int UniqueStaffAttendanceNumber { get; set; }// = 200;
        public Gender? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? TemporaryAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? ContactNumber1 { get; set; }
        public string? Email { get; set; }

        public string? Qualifications { get; set; }
        public DateTime? JoiningDate { get; set; } //= DateTime.Now;
        //public Designation? Designation { get; set; } a revoir enumérateur
        public string? BankAccountName { get; set; }
        public int? BankAccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? BankBranch { get; set; }
        public string? Status { get; set; }
        public int? DepartmentId { get; set; }
        public int? StaffSalaryId { get; set; }
    }
}
