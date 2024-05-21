using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;



namespace SchoolManagements.Application.DTOs
{
    public class FeeTypeDto : IMapFrom<FeeType>
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = default!;
    }
}
