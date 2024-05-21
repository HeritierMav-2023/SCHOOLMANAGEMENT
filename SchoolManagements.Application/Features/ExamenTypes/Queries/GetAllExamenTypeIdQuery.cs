using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.ExamenTypes.Queries
{

    public record GetAllExamenTypeIdQuery : IRequest<ExamTypeDto>
    {
        public int Id { get; set; }

        public GetAllExamenTypeIdQuery()
        {

        }
        public GetAllExamenTypeIdQuery(int id)
        {
            Id = id;
        }
    }
    internal class GetAllExamenTypeIdQueryHandler : IRequestHandler<GetAllExamenTypeIdQuery, ExamTypeDto>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllExamenTypeIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<ExamTypeDto> Handle(GetAllExamenTypeIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Repository<ExamType>().GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new ArgumentException($"Entity \"{entity}\" was not found.");
            }
            return _mapper.Map<ExamTypeDto>(entity);
        }

        #endregion
    }
}
