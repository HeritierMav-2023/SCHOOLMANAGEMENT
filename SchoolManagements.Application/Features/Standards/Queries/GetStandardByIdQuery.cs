using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Standards.Queries
{
    public record GetStandardByIdQuery : IRequest<StandardDto>
    {
        public int standardId { get; set; }

        public GetStandardByIdQuery()
        {

        }
        public GetStandardByIdQuery(int id)
        {
            standardId = id;
        }
    }
    internal class GetStandardByIdQueryHandler : IRequestHandler<GetStandardByIdQuery, StandardDto>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetStandardByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<StandardDto> Handle(GetStandardByIdQuery request, CancellationToken cancellationToken)
        {
            var entityStandard = await _unitOfWork.Repository<Student>().GetByIdAsync(request.standardId);
            if (entityStandard == null)
            {
                throw new ArgumentException($"Entity \"{entityStandard}\" was not found.");
            }
            return _mapper.Map<StandardDto>(entityStandard);
        }

        #endregion
    }
}
