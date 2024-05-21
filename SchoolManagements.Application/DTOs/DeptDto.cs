using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{
    public class DeptDto : IMapFrom<Department>
    {
        public int Id { get; set; }
        public string? DepartmentName { get; set; }
    }
}
