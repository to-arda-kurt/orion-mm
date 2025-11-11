namespace Catalog.Product.Models;

public class Product : Entity<Guid>
{
    public string Name { get; private set; } = default!;
    public List<string> Categories { get; private set; } = [ ];
    public string Description { get; private set; } = default!;
    public string ImageFileName { get; private set; } = default!;
    public decimal Price { get; private set; }

    public static Product Create(
        string name,
        List<string> categories,
        string description,
        string imageFileName,
        decimal price
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price, nameof(price));

        return new Product
        {
            Id = Guid.NewGuid(),
            Name = name,
            Categories = categories,
            Description = description,
            ImageFileName = imageFileName,
            Price = price
        };
    }

    public void Update(
        string name,
        List<string> categories,
        string description,
        string imageFileName,
        decimal price
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price, nameof(price));

        Name = name;
        Categories = categories;
        Description = description;
        ImageFileName = imageFileName;
        Price = price;
    }
}
