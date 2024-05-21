using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagements.Domain.Entities
{
    [Table("AcademicYear", Schema = "sm")]
    public class AcademicYear
    {
        public int AcademicYearId { get; set; }
        public required string Name { get; set; }
    }
}
