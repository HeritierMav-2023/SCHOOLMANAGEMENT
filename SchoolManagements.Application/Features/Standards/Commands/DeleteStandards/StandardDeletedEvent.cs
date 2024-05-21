using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Application.Features.Standards.Commands.DeleteStandards
{
    public class StandardDeletedEvent : BaseEvent
    {
        //1-Propriétes
        public Standard? Standard { get; }

        //2-Constructors
        public StandardDeletedEvent(Standard standard)
        {
            Standard = standard;
        }
    }
}
