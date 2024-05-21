using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Queries
{
    public record GetStudentsByIdQuery: IRequest<StudentsDto>
    {
        public int studentId { get; set; }

        public GetStudentsByIdQuery()
        {
            
        }
        public GetStudentsByIdQuery(int id)
        {
            studentId = id; 
        }
    }
    internal class GetStudentsByIdQueryHandler : IRequestHandler<GetStudentsByIdQuery, StudentsDto>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetStudentsByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<StudentsDto> Handle(GetStudentsByIdQuery request, CancellationToken cancellationToken)
        {
            var entityStudent = await _unitOfWork.Repository<Student>().GetByIdAsync(request.studentId);
            if (entityStudent == null)
            {
                throw new ArgumentException($"Entity \"{entityStudent}\" was not found.");
            }
            return _mapper.Map<StudentsDto>(entityStudent);
        }

        #endregion
    }
}
