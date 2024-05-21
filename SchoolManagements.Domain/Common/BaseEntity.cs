using SchoolManagements.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;


namespace SchoolManagements.Domain.Common
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        //declaration de la liste de événements du domaines+
        private readonly List<BaseEvent> _domainEvents = new();

        [NotMapped]
        public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();
        public void AddDomainEvent(BaseEvent domainEvent) => _domainEvents.Add(domainEvent);
        public void RemoveDomainEvent(BaseEvent domainEvent) => _domainEvents.Remove(domainEvent);
        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
