using FluentValidation;

namespace eCommerceServer.Application.Features.ProductBrands.CreateProductBrand;
public sealed class CreateProductBrandCommandValidator : AbstractValidator<CreateProductBrandCommand>
{
    public CreateProductBrandCommandValidator()
    {
        RuleFor(c => c.Name).MinimumLength(1).MaximumLength(50).NotEmpty();
    }
}
