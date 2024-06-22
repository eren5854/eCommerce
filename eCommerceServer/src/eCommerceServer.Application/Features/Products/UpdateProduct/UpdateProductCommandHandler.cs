using AutoMapper;
using eCommerceServer.Domain.Products;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.UpdateProduct;
internal class UpdateProductCommandHandler(
    IProductRepository productRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.GetByExpressionAsync(x => x.Id == request.Id, cancellationToken);
        if (product is null)
        {
            return Result<string>.Failure("Product not found");
        }

        mapper.Map(request, product);
        product.UpdatedBy = "Admin";
        product.UpdatedDate = DateTime.Now;

        productRepository.Update(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("Product update is successful");
    }
}
