using eCommerceServer.Application.Features.Products.CreateProduct;
using eCommerceServer.Application.Features.Products.DeleteProductById;
using eCommerceServer.Application.Features.Products.GetAllProduct;
using eCommerceServer.Application.Features.Products.UpdateProduct;
using eCommerceServer.WebAPI.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.WebAPI.Controllers;

public class ProductsController : ApiController
{
    public ProductsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetAllProductQuery(), cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
    [HttpGet]
    public async Task<IActionResult> DeleteById(Guid Id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteProductByIdCommand(Id), cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
}
