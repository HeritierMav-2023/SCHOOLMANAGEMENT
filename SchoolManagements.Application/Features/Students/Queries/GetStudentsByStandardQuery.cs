using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;


namespace SchoolManagements.Application.Features.Students.Queries
{
    public record GetStudentsByStandardQuery : IRequest<List<StudentsDto>>
    {
        public int StandardId { get; set; }

        public GetStudentsByStandardQuery()
        {

        }

        public GetStudentsByStandardQuery(int standardId)
        {
            StandardId = standardId;
        }
    }

    //Handlers
    internal class GetStudentsByStandardQueryHandler: IRequestHandler<GetStudentsByStandardQuery, List<StudentsDto>>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetStudentsByStandardQueryHandler(IUnitOfWork unitOfWork, IStudentRepository studentRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<List<StudentsDto>> Handle(GetStudentsByStandardQuery request, CancellationToken cancellationToken)
        {
            var entityStudentList = await _studentRepository.GetStudentByStandards(request.StandardId);
            if (entityStudentList == null)
            {
                throw new ArgumentException($"Entity \"{entityStudentList}\" was not found.");
            }
            return _mapper.Map<List<StudentsDto>>(entityStudentList);
        }
        #endregion
    }

}
