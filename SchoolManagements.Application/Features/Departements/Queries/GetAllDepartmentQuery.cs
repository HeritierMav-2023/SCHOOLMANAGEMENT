using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Departements.Queries
{
    public record GetAllDepartmentQuery : IRequest<List<DeptDto>>;

    internal class GetAllDepartmentQueryHandler : IRequestHandler<GetAllDepartmentQuery, List<DeptDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllDepartmentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<DeptDto>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Department>().Entities
                .ProjectTo<DeptDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion
    }
}
