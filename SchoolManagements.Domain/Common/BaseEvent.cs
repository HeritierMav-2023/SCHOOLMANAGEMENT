using MediatR;



namespace SchoolManagements.Domain.Common
{
    public abstract class BaseEvent : INotification
    {
        public DateTime DateOccured { get; protected set; } = DateTime.UtcNow;
    }
}
