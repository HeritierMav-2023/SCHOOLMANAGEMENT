using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;

namespace SchoolManagements.Application.Features.Students.Commands.DeleteStudents
{
    public record DeleteStudentCommand : IRequest<string>, IMapFrom<StudentsDto>
    {
        public int studentId { get; set; }
        public DeleteStudentCommand()
        {
            
        }
        public DeleteStudentCommand(int id)
        {
            studentId = id;
        }
    }


    internal class CreateStudentCommandHandler : IRequestHandler<DeleteStudentCommand, string>
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

        public async Task<string> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentData = await _unitOfWork.Repository<Student>().GetByIdAsync(request.studentId);

            if(studentData != null)
            {
                await _unitOfWork.Repository<Student>().DeleteAsync(studentData);
                studentData.AddDomainEvent(new StudentDeletedEvent(studentData));

                await _unitOfWork.Save(cancellationToken);

                return string.Format($"{studentData.Id}, Student Data Deleted !!");
            }
            else
                return string.Format($"Student Data Not Found !!");
        }

        #endregion
    }
}
