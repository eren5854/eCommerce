using FluentValidation;

namespace eCommerceServer.Application.Features.ProductBrands.UpdateProductBrand;
public sealed class UpdateProductBrandCommandValidator : AbstractValidator<UpdateProductBrandCommand>
{
    public UpdateProductBrandCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Name).MinimumLength(1).MaximumLength(50).NotEmpty();
    }
}
