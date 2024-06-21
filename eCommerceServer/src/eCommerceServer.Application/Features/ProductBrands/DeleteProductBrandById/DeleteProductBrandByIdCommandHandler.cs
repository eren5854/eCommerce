using eCommerceServer.Domain.ProductBrands;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.DeleteProductBrandById;
internal class DeleteProductBrandByIdCommandHandler(IProductBrandRepository productBrandRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteProductBrandByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteProductBrandByIdCommand request, CancellationToken cancellationToken)
    {
        ProductBrand productBrand = await productBrandRepository.GetByExpressionAsync(x => x.Id == request.Id, cancellationToken);

        if (productBrand is null)
        {
            return Result<string>.Failure("ProductBrand not found");
        }

        productBrand.IsDeleted = true;
        productBrandRepository.Update(productBrand);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("ProductBrand delete is successful");
    }
}
