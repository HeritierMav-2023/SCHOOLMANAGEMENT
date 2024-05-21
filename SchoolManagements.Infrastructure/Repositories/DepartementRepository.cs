using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Infrastructure.Repositories
{
    #region Abstraction For Api ReadOnly
    public class DepartementRepository : IDepartementRepository
    {
        private readonly IGenericRepository<Department> _repository;
        public DepartementRepository(IGenericRepository<Department> repository)
        {
            _repository = repository;
        }
    }
    public class ExamenScheduleRepository : IExamenScheduleRepository
    {
        private readonly IGenericRepository<ExamSchedule> _repository;
        public ExamenScheduleRepository(IGenericRepository<ExamSchedule> repository)
        {
            _repository = repository;
        }
    }
    public class ExamenTypeRepository : IExamenTypeRepository
    {
        private readonly IGenericRepository<ExamType> _repository;
        public ExamenTypeRepository(IGenericRepository<ExamType> repository)
        {
            _repository = repository;
        }
    }
    public class FeeTypeRepository : IFeeTypeRepository
    {
        private readonly IGenericRepository<FeeType> _repository;
        public FeeTypeRepository(IGenericRepository<FeeType> repository)
        {
            _repository = repository;
        }
    }
    #endregion
    
}
