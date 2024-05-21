using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Standards.Commands.DeleteStandards
{
    //public record DeleteStandardCommand
    //{
    //}
    public record DeleteStandardCommand : IRequest<string>, IMapFrom<StudentsDto>
    {
        public int standardId { get; set; }
        public DeleteStandardCommand()
        {

        }
        public DeleteStandardCommand(int id)
        {
            standardId = id;
        }
    }


    internal class DeleteStandardCommandHandler : IRequestHandler<DeleteStandardCommand, string>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors DI
        public DeleteStandardCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Ovveride Methods

        public async Task<string> Handle(DeleteStandardCommand request, CancellationToken cancellationToken)
        {
            var standardData = await _unitOfWork.Repository<Standard>().GetByIdAsync(request.standardId);

            if (standardData != null)
            {
                standardData.DeletededDate = DateTime.UtcNow;

                await _unitOfWork.Repository<Standard>().DeleteAsync(standardData);
                standardData.AddDomainEvent(new StandardDeletedEvent(standardData));

                await _unitOfWork.Save(cancellationToken);

                return string.Format($" Id :{standardData.Id}, Standard Data Deleted !!");
            }
            else
                return string.Format($"Standard Data Not Found !!");
        }

        #endregion
    }
}
