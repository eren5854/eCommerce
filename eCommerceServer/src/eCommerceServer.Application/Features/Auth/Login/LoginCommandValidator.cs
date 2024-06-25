using FluentValidation;

namespace eCommerceServer.Application.Features.Auth.Login;
public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(p => p.EmailOrUserName).MinimumLength(3).WithMessage("Email or user name must be 3 character");
        RuleFor(p => p.Password).MinimumLength(8).WithMessage("Password must be min 8 character");
    }
}
