
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("Department", Schema = "sm")]
    public class Department : BaseAuditableEntity
    {
        //public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }

    }
}
