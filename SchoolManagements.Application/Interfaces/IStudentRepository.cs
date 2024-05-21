using SchoolManagements.Domain.Entities;



namespace SchoolManagements.Application.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentByStandards(int standardId);
    }
}
