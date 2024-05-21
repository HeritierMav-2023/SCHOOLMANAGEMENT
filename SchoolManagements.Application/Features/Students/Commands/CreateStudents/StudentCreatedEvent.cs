using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Commands.CreateStudents
{
    public class StudentCreatedEvent : BaseEvent
    {
        //1-Propriétes
        public Student? Student { get;}

        //2-Constructors
        public StudentCreatedEvent(Student std)
        {
            Student = std;
        }

    }
}
