using FluentValidation;

namespace eCommerceServer.Application.Features.Categories.UpdateCategory;
public sealed class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c =>c.Name).MinimumLength(3).MaximumLength(30).NotEmpty();
    }
}
