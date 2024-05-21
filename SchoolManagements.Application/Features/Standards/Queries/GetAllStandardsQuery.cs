using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Standards.Queries
{
    public record GetAllStandardsQuery : IRequest<List<StandardDto>>;

    #region Class CommandHandler
    internal class GetAllStandardsQueryHandler : IRequestHandler<GetAllStandardsQuery, List<StandardDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllStandardsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<StandardDto>> Handle(GetAllStandardsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Standard>().Entities
                .ProjectTo<StandardDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion
    }

    #endregion
}
