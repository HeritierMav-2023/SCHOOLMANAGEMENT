using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Entities;

namespace SchoolManagements.Application.Features.Standards.Commands.CreateStandards
{
    public class StandardCreatedEvent : BaseEvent
    {
        //1-Propriétes
        public Standard? Standard { get; }

        //2-Constructors
        public StandardCreatedEvent(Standard standard)
        {
            Standard = standard;
        }
    }

}
