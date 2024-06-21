using FluentValidation;

namespace eCommerceServer.Application.Features.Categories.CreateCategory;
public sealed class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(c => c.Name).MinimumLength(3).MaximumLength(30).NotEmpty();
    }
}
