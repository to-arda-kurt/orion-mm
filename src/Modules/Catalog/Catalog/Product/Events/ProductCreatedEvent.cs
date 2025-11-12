namespace Catalog.Product.Events;

public record ProductCreatedEvent(ProductModel Product) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}
