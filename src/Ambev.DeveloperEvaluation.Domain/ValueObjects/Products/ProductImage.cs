namespace Ambev.DeveloperEvaluation.Domain.ValueObjects.Products
{
    public record ProductImage
    {
        public string Url { get; }

        public ProductImage(string url)
        {
            Url = url;
        }

    }
}
