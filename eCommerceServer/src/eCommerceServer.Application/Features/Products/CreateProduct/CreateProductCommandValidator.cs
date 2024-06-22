using FluentValidation;

namespace eCommerceServer.Application.Features.Products.CreateProduct;
public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name).MinimumLength(3).MaximumLength(100).NotEmpty();
        RuleFor(x => x.Description).MaximumLength(3).MaximumLength(500);
    }
}
