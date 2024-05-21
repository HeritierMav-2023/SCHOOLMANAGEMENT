using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.ExamenSchedules.Queries
{
  
    public record GetAllExamenScheduleQuery : IRequest<List<ExamScheduleDto>>;

    internal class GetAllExamenScheduleQueryHandler : IRequestHandler<GetAllExamenScheduleQuery, List<ExamScheduleDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllExamenScheduleQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<ExamScheduleDto>> Handle(GetAllExamenScheduleQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<ExamSchedule>().Entities
                .ProjectTo<ExamScheduleDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion
    }
}
