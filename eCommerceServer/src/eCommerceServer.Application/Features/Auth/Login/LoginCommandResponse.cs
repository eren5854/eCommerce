using eCommerceServer.Domain.Identity;

namespace eCommerceServer.Application.Features.Auth.Login;
public sealed record LoginCommandResponse(
    string Token,
    string RefreshToken,
    DateTime RefreshTokenExpires);
