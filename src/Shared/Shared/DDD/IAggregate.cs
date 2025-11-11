namespace Shared.DDD;

public interface IAggregate<TKey> : IAggregate, IEntity<TKey> { }

public interface IAggregate : IEntity
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    IDomainEvent[] ClearDomainEvents();
}
