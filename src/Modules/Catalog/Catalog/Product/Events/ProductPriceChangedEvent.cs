namespace Catalog.Product.Events;

public record ProductPriceChangedEvent(ProductModel Product, decimal NewPrice) : IDomainEvent { }
