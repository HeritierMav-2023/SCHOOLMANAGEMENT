using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;

namespace SchoolManagements.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Propriétes
        private readonly IGenericRepository<Student> _repository;

        #endregion

        #region Constructors
        public StudentRepository(IGenericRepository<Student> studentRepository)
        {
            _repository = studentRepository; 
        }
        #endregion

        #region Ovveride Methods
        public async Task<List<Student>> GetStudentByStandards(int standardId)
        {
            return await _repository.Entities.Where(s=>s.StandardId == standardId).ToListAsync();
        }
        #endregion
    }
}
