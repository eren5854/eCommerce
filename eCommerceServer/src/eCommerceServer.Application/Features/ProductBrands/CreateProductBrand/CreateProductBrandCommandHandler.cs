using AutoMapper;
using eCommerceServer.Domain.ProductBrands;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.CreateProductBrand;
internal sealed class CreateProductBrandCommandHandler(
    IProductBrandRepository productBrandRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork) : IRequestHandler<CreateProductBrandCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateProductBrandCommand request, CancellationToken cancellationToken)
    {
        var isNameExists = await productBrandRepository.AnyAsync(x => x.Name == new Domain.Shared.Name(request.Name), cancellationToken);
        if (isNameExists)
        {
            return Result<string>.Failure("ProductBrand name already exists");
        }

        ProductBrand productBrand = mapper.Map<ProductBrand>(request);
        productBrand.CreatedBy = "Admin";
        productBrand.CreatedDate = DateTime.Now;

        await productBrandRepository.AddAsync(productBrand);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("ProductBrand crate is successful");
    }
}
