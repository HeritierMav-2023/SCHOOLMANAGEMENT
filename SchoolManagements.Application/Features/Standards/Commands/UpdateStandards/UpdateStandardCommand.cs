using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Standards.Commands.UpdateStandards
{
    public record UpdateStandardCommand : IRequest<string>, IMapFrom<StandardDto>
    {
        public int StandardId { get; set; }
        public string? StandardName { get; set; }
        public string? StandardCapacity { get; set; }
    }

    #region Class CommandHandler

    internal class UpdateStandardCommandHandler : IRequestHandler<UpdateStandardCommand, string>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors DI
        public UpdateStandardCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<string> Handle(UpdateStandardCommand request, CancellationToken cancellationToken)
        {
            var standardData = await _unitOfWork.Repository<Standard>().GetByIdAsync(request.StandardId);
            if (standardData != null)
            {
                standardData.StandardName = request.StandardName;
                standardData.StandardCapacity = request.StandardCapacity;
                standardData.ModifiedDate = DateTime.UtcNow;

                await _unitOfWork.Repository<Standard>().UpdateAsync(standardData);
                standardData.AddDomainEvent(new StandardUpdatedEvent(standardData));
                await _unitOfWork.Save(cancellationToken);

                return string.Format($" Id : {standardData.Id}, Standard Updated !!");
            }
          else
            return string.Format($" Standard Not Found !!");
        }
        #endregion
    }
    #endregion
}
