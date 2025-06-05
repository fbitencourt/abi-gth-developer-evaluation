using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.ValueObjects.Products
{
    public record Price
    {
        public decimal Value { get; }

        public Currency Currency { get; }

        public Price(decimal value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }
    }
}
