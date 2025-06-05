namespace Ambev.DeveloperEvaluation.Domain.ValueObjects.Products
{
    public record SKU
    {
        public string Value { get; }

        public SKU(string value)
        {
            Value = value.ToUpperInvariant();
        }
    }

}
