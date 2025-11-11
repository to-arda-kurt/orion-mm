using MediatR;

namespace Shared.DDD;

public interface IDomainEvent : INotification
{
    Guid EntityId => Guid.NewGuid();
    public DateTime CreatedAt => DateTime.UtcNow;
    public string EventType => GetType().AssemblyQualifiedName ?? string.Empty;
}
