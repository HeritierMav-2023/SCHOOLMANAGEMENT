using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Commands.UpdateStudents
{
    public class StudentUpdatedEvent : BaseEvent
    {
        //1-Propriétes
        public Student? Student { get; }

        //2-Constructors
        public StudentUpdatedEvent(Student std)
        {
            Student = std;
        }

    }
}
