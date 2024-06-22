using eCommerceServer.Domain.Products;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.DeleteProductById;
internal sealed class DeleteProductByIdCommandHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteProductByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.GetByExpressionAsync(x => x.Id == request.Id, cancellationToken);
        if (product is null)
        {
            return Result<string>.Failure("Product not found");
        }

        product.IsDeleted = true;
        productRepository.Update(product);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("Product delete is successful");
    }
}
