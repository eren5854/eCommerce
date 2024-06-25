using eCommerceServer.Application.Features.Auth.Login;
using eCommerceServer.WebAPI.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.WebAPI.Controllers;

[AllowAnonymous]
public sealed class AuthController : ApiController
{
    public AuthController(IMediator mediator) : base(mediator)
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet]
    public async Task<IActionResult> GetTokenByRefreshToken(string refreshToken, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(refreshToken, cancellationToken);
        return Ok(result);
    }
}
