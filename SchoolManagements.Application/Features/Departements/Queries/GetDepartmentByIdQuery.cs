using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Departements.Queries
{
  
    public record GetDepartmentByIdQuery : IRequest<DeptDto>
    {
        public int departementId { get; set; }

        public GetDepartmentByIdQuery()
        {

        }
        public GetDepartmentByIdQuery(int id)
        {
            departementId = id;
        }
    }
    internal class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, DeptDto>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetDepartmentByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<DeptDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var entityDept = await _unitOfWork.Repository<Department>().GetByIdAsync(request.departementId);
            if (entityDept == null)
            {
                throw new ArgumentException($"Entity \"{entityDept}\" was not found.");
            }
            return _mapper.Map<DeptDto>(entityDept);
        }

        #endregion
    }
}
