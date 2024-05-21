using AutoMapper;
using MediatR;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Application.Mapping;
using SchoolManagements.Domain.Entities;

namespace SchoolManagements.Application.Features.Standards.Commands.CreateStandards
{
    public record CreateStandardCommand : IRequest<string>, IMapFrom<StandardDto>
    {
        public string? StandardName { get; set; }
        public string? StandardCapacity { get; set; }
    }

    #region Class CommandHandler

    internal class CreateStandardCommandHandler : IRequestHandler<CreateStandardCommand, string>
    {
        #region Propriétes
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors DI
        public CreateStandardCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Ovveride Methods
        public async Task<string> Handle(CreateStandardCommand request, CancellationToken cancellationToken)
        {
            var standardData = new Standard()
            {
                StandardName = request.StandardName,
                StandardCapacity = request.StandardCapacity,
                CreatedDate = DateTime.UtcNow
            };

            await _unitOfWork.Repository<Standard>().AddAsync(standardData);
            standardData.AddDomainEvent(new StandardCreatedEvent(standardData));
            await _unitOfWork.Save(cancellationToken);

            return string.Format($" Id : {standardData.Id}, Standard  Created !!");
        }
        #endregion
    }
    #endregion
}
