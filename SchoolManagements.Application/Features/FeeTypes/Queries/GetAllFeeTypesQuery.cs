using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.FeeTypes.Queries
{

    public record GetAllFeeTypesQuery : IRequest<List<FeeTypeDto>>;

    internal class GetAllFeeTypesQueryHandler : IRequestHandler<GetAllFeeTypesQuery, List<FeeTypeDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllFeeTypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<FeeTypeDto>> Handle(GetAllFeeTypesQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<FeeType>().Entities
                .ProjectTo<FeeTypeDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion
    }
}
