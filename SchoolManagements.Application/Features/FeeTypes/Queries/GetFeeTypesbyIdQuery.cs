using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.FeeTypes.Queries
{

    public record GetFeeTypesbyIdQuery : IRequest<FeeTypeDto>
    {
        public int Id { get; set; }

        public GetFeeTypesbyIdQuery()
        {

        }
        public GetFeeTypesbyIdQuery(int id)
        {
            Id = id;
        }
    }
    internal class GetFeeTypesbyIdQueryHandler : IRequestHandler<GetFeeTypesbyIdQuery, FeeTypeDto>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetFeeTypesbyIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<FeeTypeDto> Handle(GetFeeTypesbyIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Repository<FeeType>().GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new ArgumentException($"Entity \"{entity}\" was not found.");
            }
            return _mapper.Map<FeeTypeDto>(entity);
        }

        #endregion
    }
}
