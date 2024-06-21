using AutoMapper;
using eCommerceServer.Domain.ProductBrands;
using eCommerceServer.Domain.Shared;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.UpdateProductBrand;
internal sealed class UpdateProductBrandCommandHandler(IProductBrandRepository productBrandRepository, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductBrandCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateProductBrandCommand request, CancellationToken cancellationToken)
    {
        ProductBrand? productBrand = await productBrandRepository.GetByExpressionAsync(x => x.Id == request.Id, cancellationToken);
        if (productBrand is null)
        {
            return Result<string>.Failure("ProductBrand not found");
        }

        if (productBrand.Name.Value != request.Name)
        {
            var isNameExists = await productBrandRepository.AnyAsync(x => x.Name == new Name(request.Name), cancellationToken);
            if (isNameExists)
            {
                return Result<string>.Failure("ProductBrand name already exists");
            }
        }

        mapper.Map(request, productBrand);
        productBrand.UpdatedBy = "Admin";
        productBrand.UpdatedDate = DateTime.Now;

        productBrandRepository.Update(productBrand);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("Update is successful");
    }
}
