using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Common;


namespace SchoolManagements.Domain.Entities
{
    [Table("FeeType", Schema = "sm")]
    public class FeeType : BaseAuditableEntity
    {
        //public int FeeTypeId { get; set; }
        public string? TypeName { get; set; }
        public List<Fee> FeeList { get; set; } = new();

    }
}
