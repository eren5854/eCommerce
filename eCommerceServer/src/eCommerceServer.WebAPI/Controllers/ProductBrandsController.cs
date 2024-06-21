using eCommerceServer.Application.Features.ProductBrands.CreateProductBrand;
using eCommerceServer.Application.Features.ProductBrands.DeleteProductBrandById;
using eCommerceServer.Application.Features.ProductBrands.UpdateProductBrand;
using eCommerceServer.WebAPI.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.WebAPI.Controllers;

public class ProductBrandsController : ApiController
{
    public ProductBrandsController(IMediator mediator) : base(mediator)
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductBrandCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductBrandCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet]
    public async Task<IActionResult> DeleteById(Guid Id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteProductBrandByIdCommand(Id), cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
}
