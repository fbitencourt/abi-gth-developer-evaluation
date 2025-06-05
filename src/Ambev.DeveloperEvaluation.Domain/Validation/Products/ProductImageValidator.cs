using Ambev.DeveloperEvaluation.Domain.ValueObjects.Products;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation.Products
{
    public class ProductImageValidator : AbstractValidator<ProductImage>
    {
        public ProductImageValidator()
        {
            RuleFor(image => image.Url)
                .NotEmpty()
                .WithMessage("Image URL cannot be empty.")
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Image URL must be a valid absolute URI.")
                .MaximumLength(2000)
                .WithMessage("Image URL cannot exceed 2000 characters.");
        }
    }
}
