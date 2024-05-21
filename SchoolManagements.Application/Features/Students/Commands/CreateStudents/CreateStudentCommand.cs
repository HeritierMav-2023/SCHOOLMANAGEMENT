using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Commands.CreateStudents
{
    public record CreateStudentCommand : IRequest<string>,IMapFrom<StudentsDto>
    {
        public int? AdmissionNo { get; set; }
        public int? EnrollmentNo { get; set; }
        public int UniqueStudentAttendanceNumber { get; set; }
        public string? StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        //public GenderList? StudentGender { get; set; }
        public string? StudentReligion { get; set; }
        public string? StudentBloodGroup { get; set; }
        public string? StudentNationality { get; set; }
        public string? StudentNIDNumber { get; set; }
        public string? StudentContactNumber1 { get; set; }
        public string? StudentContactNumber2 { get; set; }
        public string? StudentEmail { get; set; }
        public string? PermanentAddress { get; set; }
        public string? TemporaryAddress { get; set; }
        public string? FatherName { get; set; }
        public string? FatherNID { get; set; }
        public string? FatherContactNumber { get; set; }
        public string? MotherName { get; set; }
        public string? MotherNID { get; set; }
        public string? MotherContactNumber { get; set; }
        public string? LocalGuardianName { get; set; }
        public string? LocalGuardianContactNumber { get; set; }
        public int? StandardId { get; set; } = 0;
    }
    //Command Handler
    internal class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, string>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors DI
        public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods
        public async Task<string> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            //a faire voir coment recupéré la clé standard ID
            //var standard = await _unitOfWork.Repository<Standard>().GetByIdAsync()

            var studentData = new Student()
            {
              AdmissionNo = request.AdmissionNo,
              EnrollmentNo = request.EnrollmentNo,
              UniqueStudentAttendanceNumber = request.UniqueStudentAttendanceNumber,
              StudentName = request.StudentName,
              StudentDOB = request.StudentDOB,
              StudentReligion = request.StudentReligion,
              StudentBloodGroup = request.StudentBloodGroup,
              StudentNationality = request.StudentNationality,
              StudentNIDNumber = request.StudentNIDNumber,
              StudentContactNumber1 = request.StudentContactNumber1,
              StudentContactNumber2 = request.StudentContactNumber2,
              StudentEmail = request.StudentEmail,
              PermanentAddress = request.PermanentAddress,
              TemporaryAddress = request.TemporaryAddress,
              FatherContactNumber = request.FatherContactNumber,
              FatherNID = request.FatherNID,
              MotherName = request.MotherName,
              MotherNID = request.MotherNID,
              MotherContactNumber = request.MotherContactNumber,
              LocalGuardianContactNumber = request.LocalGuardianContactNumber,
              LocalGuardianName = request.LocalGuardianName,
              CreatedDate = DateTime.UtcNow,
              ModifiedDate = null,
              DeletededDate = null,
            };
            await _unitOfWork.Repository<Student>().AddAsync(studentData);
            studentData.AddDomainEvent(new StudentCreatedEvent(studentData));
            await _unitOfWork.Save(cancellationToken);

            return string.Format($"{studentData.Id }, Student Created !!");
        }
        #endregion
    }
}
