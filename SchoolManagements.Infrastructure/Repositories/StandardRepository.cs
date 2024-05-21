using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Infrastructure.Repositories
{
    public class StandardRepository : IStandardRepository
    {
        #region Propriétes
        private readonly IGenericRepository<Standard> _repository;

        #endregion

        #region Constructors
        public StandardRepository(IGenericRepository<Standard> repository)
        {
            _repository = repository; 
        }
        #endregion

    }
}
