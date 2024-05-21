using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Students.Commands.UpdateStudents
{
    public record UpdateStudentCommand : IRequest<string>, IMapFrom<StudentsDto>
    {
        public int studentId { get; set; }
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

    internal class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, string>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors DI
        public UpdateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods
        public async Task<string> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            //a faire voir coment recupéré la clé standard ID
            //var standard = await _unitOfWork.Repository<Standard>().GetByIdAsync()

            var studentData = await _unitOfWork.Repository<Student>().GetByIdAsync(request.studentId);
            if(studentData != null) 
            {
                studentData.AdmissionNo = request.AdmissionNo;
                studentData.EnrollmentNo = request.EnrollmentNo;
                studentData.UniqueStudentAttendanceNumber = request.UniqueStudentAttendanceNumber;
                studentData.StudentName = request.StudentName;
                studentData.StudentDOB = request.StudentDOB;
                studentData.StudentReligion = request.StudentReligion;
                studentData.StudentBloodGroup = request.StudentBloodGroup;
                studentData.StudentNationality = request.StudentNationality;
                studentData.StudentNIDNumber = request.StudentNIDNumber;
                studentData.StudentContactNumber1 = request.StudentContactNumber1;
                studentData.StudentContactNumber2 = request.StudentContactNumber2;
                studentData.StudentEmail = request.StudentEmail;
                studentData.PermanentAddress = request.PermanentAddress;
                studentData.TemporaryAddress = request.TemporaryAddress;
                studentData.FatherContactNumber = request.FatherContactNumber;
                studentData.FatherNID = request.FatherNID;
                studentData.MotherName = request.MotherName;
                studentData.MotherNID = request.MotherNID;
                studentData.MotherContactNumber = request.MotherContactNumber;
                studentData.LocalGuardianContactNumber = request.LocalGuardianContactNumber;
                studentData.LocalGuardianName = request.LocalGuardianName;
                studentData.CreatedDate = null;
                studentData.ModifiedDate = DateTime.UtcNow;
                studentData.DeletededDate = null;

                await _unitOfWork.Repository<Student>().UpdateAsync(studentData);
                studentData.AddDomainEvent(new StudentUpdatedEvent(studentData));
                await _unitOfWork.Save(cancellationToken);

                return  string.Format($"{studentData.Id}, Student Updated !!");
            }
            else
            {
                return string.Format($"Student Not Found !!");
            }
        }
        #endregion
    }
}
