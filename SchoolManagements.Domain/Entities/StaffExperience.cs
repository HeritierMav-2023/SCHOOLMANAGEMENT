using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagements.Domain.Helpers;
using SchoolManagements.Domain.Common;

namespace SchoolManagements.Domain.Entities
{
    [Table("StaffExperience", Schema = "sm")]
    public class StaffExperience : BaseAuditableEntity
    {
        //public int StaffExperienceId { get; set; }
        public string? CompanyName { get; set; }
        public string? Designation { get; set; }
        public DateTime JoiningDate { get; set; } = DateTime.Now;
        public DateTime? LeavingDate { get; set; } = DateTime.Now;
        public string? Responsibilities { get; set; }
        public string? Achievements { get; set; }
        public TimeSpan ServiceDuration => LeavingDate.HasValue
                                      ? LeavingDate.Value - JoiningDate
                                      : DateTime.Now - JoiningDate;
        public string ServiceDurationText => ServiceDuration.ToReadableString();

    }
}