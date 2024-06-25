using eCommerceServer.Application.Services;
using eCommerceServer.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eCommerceServer.Application.Features.Auth.Login;
internal sealed class LoginCommandHandler(
    UserManager<AppUser> userManager,
    SignInManager<AppUser> signInManager,
    IJwtProvider jwtProvider) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
{
    //public async Task<Result<LoginCommandResponse>> GetTokenByRefreshTokenAsync(string refreshToken, CancellationToken cancellationToken)
    //{
    //    AppUser? user = await userManager.Users.Where(p => p.RefreshToken == refreshToken).FirstOrDefaultAsync(cancellationToken);
    //    if (user is null)
    //    {
    //        return (500, "Refresh token unavailable");
    //    }

    //    var loginResponse = await jwtProvider.CreateToken(user);
    //    return loginResponse;
    //}
    public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        string emailOrUserName = request.EmailOrUserName.ToUpper();
        AppUser? user = await userManager.Users
            .FirstOrDefaultAsync(p => p.UserName == emailOrUserName ||
            p.Email == emailOrUserName,
            cancellationToken);
        if (user is null)
        {
            return (500, "User not found");
        }

        SignInResult signInResult = await signInManager.CheckPasswordSignInAsync(user, request.Password, true);

        if (signInResult.IsLockedOut)
        {
            TimeSpan? timeSpan = user.LockoutEnd - DateTime.UtcNow;
            if(timeSpan is not null)
            {
                return (500, $"Şifre 3 defa yanlış girildi {Math.Ceiling(timeSpan.Value.TotalMinutes)} dakika bekleyin");
            }
            else
            {
                return (500, "5 dakika bekleyin");
            }
        }

        if (signInResult.IsNotAllowed)
        {
            return (500, "Mail adresi onaylı değil");
        }

        if (!signInResult.Succeeded)
        {
            return (500, "Şifre Hatalı");
        }

        var loginResponse = await jwtProvider.CreateToken(user);

        return loginResponse;
    }
}
