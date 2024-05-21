using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{
    public class ExamTypeDto : IMapFrom<ExamType>
    {
        public int Id { get; set; }
        public string ExamenTypeName { get; set; } = default!;
    }
}
