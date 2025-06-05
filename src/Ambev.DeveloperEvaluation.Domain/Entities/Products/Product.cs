using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.ValueObjects.Products;

namespace Ambev.DeveloperEvaluation.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        public SKU? SKU { get; private set; }

        public ProductInfo? Info { get; private set; }

        public Price? Price { get; private set; }

        public ProductImage? Image { get; private set; }

        private Product() { }

        public Product(
            SKU sku,
            ProductInfo info,
            Price price,
            ProductImage productImage)
        {
            SKU = sku;
            Info = info;
            Price = price;
            Image = productImage;
        }
    }
}
