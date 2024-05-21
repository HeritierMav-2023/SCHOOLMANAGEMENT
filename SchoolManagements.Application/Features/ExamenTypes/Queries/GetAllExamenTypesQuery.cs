using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.ExamenTypes.Queries
{
  
    public record GetAllExamenTypesQuery : IRequest<List<ExamTypeDto>>;

    internal class GetAllExamenTypesQueryHandler : IRequestHandler<GetAllExamenTypesQuery, List<ExamTypeDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllExamenTypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<ExamTypeDto>> Handle(GetAllExamenTypesQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<ExamType>().Entities
                .ProjectTo<ExamTypeDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion
    }
}
