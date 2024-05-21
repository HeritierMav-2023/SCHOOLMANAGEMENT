using SchoolManagements.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagements.Infrastructure.Persistences
{
    [Table("StudentMarksDetails", Schema = "sm")]
    public class StudentMarksDetails
    {
        [ForeignKey("MarkEntry")]
        public int MarkEntryId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }

        public int? ObtainedScore { get; set; }

        public GradesSystem? Grade { get; set; } = GradesSystem.A;

        public PassFailStatus? PassStatus { get; set; } = PassFailStatus.Passed;

        public string? Feedback { get; set; }

        public virtual Student? Student { get; set; }
        //public virtual MarkEntry? MarkEntry { get; set; }

    }

    public enum GradesSystem
    {
        A, B, C, D, E, F, NotApplicable
    }

    public enum PassFailStatus
    {
        Passed, Failed, UnderConsideration, SpecialConsideration, Withdrawn, UnderJurisdiction
    }
}