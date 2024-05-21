using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.ExamenSchedules.Queries
{
 
    public record GetExamenScheduleIdQuery : IRequest<ExamScheduleDto>
    {
        public int Id { get; set; }

        public GetExamenScheduleIdQuery()
        {

        }
        public GetExamenScheduleIdQuery(int id)
        {
            Id = id;
        }
    }
    internal class GetExamenScheduleIdQueryHandler : IRequestHandler<GetExamenScheduleIdQuery, ExamScheduleDto>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetExamenScheduleIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<ExamScheduleDto> Handle(GetExamenScheduleIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Repository<ExamSchedule>().GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new ArgumentException($"Entity \"{entity}\" was not found.");
            }
            return _mapper.Map<ExamScheduleDto>(entity);
        }

        #endregion
    }
}
