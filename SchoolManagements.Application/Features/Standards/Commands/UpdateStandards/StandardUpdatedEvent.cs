using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Standards.Commands.UpdateStandards
{
    public class StandardUpdatedEvent : BaseEvent
    {
        //1-Propriétes
        public Standard? Standard { get;}

        //2-Constructors
        public StandardUpdatedEvent(Standard standard)
        {
            Standard = standard;
        }
    }
}
