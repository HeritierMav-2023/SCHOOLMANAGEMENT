using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{
    public class StudentsDto : IMapFrom<Student>
    {
        public int Id { get; set; }
        public int? AdmissionNo { get; set; }
        public int? EnrollmentNo { get; set; }
        public int UniqueStudentAttendanceNumber { get; set; }
        public string? StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        public GenderList? StudentGender { get; set; }
        public string? StudentReligion { get; set; }
        public string? StudentBloodGroup { get; init; }
        public string? StudentNationality { get; init; }
        public string? StudentNIDNumber { get; init; }
        public string? StudentContactNumber1 { get; init; }
        public string? StudentContactNumber2 { get; init; }
        public string? StudentEmail { get; init; }
        public string? PermanentAddress { get; init; }
        public string? TemporaryAddress { get; init; }
        public string? FatherName { get; init; }
        public string? FatherNID { get; init; }
        public string? FatherContactNumber { get; init; }
        public string? MotherName { get; init; }
        public string? MotherNID { get; init; }
        public string? MotherContactNumber { get; init; }
        public string? LocalGuardianName { get; init; }
        public string? LocalGuardianContactNumber { get; init; }
    }
    //public enum GenderList
    //{
    //    Male,
    //    Female,
    //    Other
    //}
}
