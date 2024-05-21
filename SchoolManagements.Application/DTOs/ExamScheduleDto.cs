using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{
    public class ExamScheduleDto : IMapFrom<ExamSchedule>
    {
        public int Id { get; set; }
        public string? ExamScheduleName { get; set; } 
    }
}
