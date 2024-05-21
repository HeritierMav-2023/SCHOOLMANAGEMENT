using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Queries
{
    public record GetAllStudentsQuery : IRequest<List<StudentsDto>>;

    internal class GetAllStudentsQueryHandler: IRequestHandler<GetAllStudentsQuery, List<StudentsDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllStudentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<StudentsDto>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Student>().Entities
                .ProjectTo<StudentsDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion
    }

}
