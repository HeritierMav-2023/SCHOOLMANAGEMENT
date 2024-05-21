using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;



namespace SchoolManagements.Application.DTOs
{
    public class AcademicMonthDto: IMapFrom<AcademicMonth>
    {
        public string MonthName { get; set; } = default!;
    }
}
