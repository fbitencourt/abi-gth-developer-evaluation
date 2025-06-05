namespace Ambev.DeveloperEvaluation.Domain.ValueObjects.Products
{
    public record ProductInfo
    {
        public string Name { get; }
        public string Description { get; }
        public ProductInfo(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
