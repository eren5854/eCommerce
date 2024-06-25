using eCommerceServer.Application.Features.Auth.Login;
using eCommerceServer.Domain.Identity;

namespace eCommerceServer.Application.Services;
public interface IJwtProvider
{
    Task<LoginCommandResponse> CreateToken(AppUser user);
}
