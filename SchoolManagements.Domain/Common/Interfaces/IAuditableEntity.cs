using System;
using System.Collections.Generic;


namespace SchoolManagements.Domain.Common.Interfaces
{
    public interface IAuditableEntity : IEntity
    {
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletededDate { get; set; }
    }
}
