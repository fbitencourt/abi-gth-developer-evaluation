using Ambev.DeveloperEvaluation.Domain.ValueObjects.Products;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation.Products
{
    public class PriceValidator : AbstractValidator<Price>
    {
        public PriceValidator()
        {
            RuleFor(price => price.Value)
                .GreaterThan(0)
                .WithMessage("Price must be greater than zero.");

            RuleFor(price => price.Currency)
                .IsInEnum()
                .WithMessage("Currency must be a valid enum value.");
        }
    }
}
