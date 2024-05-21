using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.DTOs
{

/// <summary>
/// Class Standard DTO 
/// </summary>
    public class StandardDto : IMapFrom<Standard>
    {
        public int Id { get; set; }
        public string? StandardName { get; set; }
        public string? StandardCapacity { get; set; }
        
    }
}
