using SchoolManagements.Domain.Common.Interfaces;


namespace SchoolManagements.Domain.Common
{
    public class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
        public DateTime? CreatedDate { get; set; } 
        public DateTime? ModifiedDate { get; set; } 
        public DateTime? DeletededDate { get; set; } 
    }
}
