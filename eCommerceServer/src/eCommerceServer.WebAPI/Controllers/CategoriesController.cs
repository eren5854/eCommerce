using eCommerceServer.Application.Features.Categories.CreateCategory;
using eCommerceServer.Application.Features.Categories.DeleteCategoryById;
using eCommerceServer.Application.Features.Categories.GetAllCategory;
using eCommerceServer.Application.Features.Categories.UpdateCategory;
using eCommerceServer.WebAPI.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.WebAPI.Controllers;

public class CategoriesController : ApiController
{
    public CategoriesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetAllCategoryQuery(), cancellationToken);
        return StatusCode(result.StatusCode, result);

    }

    [HttpGet]
    public async Task<IActionResult> DeleteById(Guid Id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteCategoryByIdCommand(Id), cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
}
