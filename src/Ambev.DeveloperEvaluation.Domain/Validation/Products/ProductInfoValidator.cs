using Ambev.DeveloperEvaluation.Domain.ValueObjects.Products;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation.Products
{
    internal class ProductInfoValidator : AbstractValidator<ProductInfo>
    {
        public ProductInfoValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty()
                .WithMessage("Product name cannot be empty.")
                .MaximumLength(100)
                .WithMessage("Product name cannot exceed 100 characters.");

            RuleFor(product => product.Description)
                .NotEmpty()
                .WithMessage("Product description cannot be empty.")
                .MaximumLength(500)
                .WithMessage("Product description cannot exceed 500 characters.");
        }
    }
}
