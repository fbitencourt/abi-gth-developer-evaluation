using Ambev.DeveloperEvaluation.Domain.ValueObjects.Products;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation.Products
{
    public class SKUValidator : AbstractValidator<SKU>
    {
        public SKUValidator()
        {
            RuleFor(sku => sku.Value)
                .NotEmpty().WithMessage("SKU cannot be empty.")
                .Matches(@"^[A-Z0-9]+$").WithMessage("SKU must consist of uppercase letters and numbers only.")
                .Length(1, 20).WithMessage("SKU must be between 1 and 20 characters long.");
        }
    }
}
