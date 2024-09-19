using Abp.Application.Services;
using Abp.Domain.Repositories;
using System.Threading.Tasks;

public class ProductAppService : ApplicationService, IProductAppService
{
    private readonly IRepository<Product, int> _productRepository;

    public ProductAppService(IRepository<Product, int> productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ProductDto> GetProductAsync(int productId)
    {
        var product = await _productRepository.GetAsync(productId);
        return ObjectMapper.Map<ProductDto>(product);
    }
}
