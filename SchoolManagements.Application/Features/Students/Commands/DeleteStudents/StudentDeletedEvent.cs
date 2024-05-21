using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Commands.DeleteStudents
{
    public class StudentDeletedEvent : BaseEvent
    {
        //1-Propriétes
        public Student? Student { get; }

        //2-Constructors
        public StudentDeletedEvent(Student std)
        {
            Student = std;
        }

    }
}
