using System.Threading.Tasks;

public interface IProductAppService
{
    Task<ProductDto> GetProductAsync(int productId);

    Task<ProductDto> CreateProductAsync(string name, decimal price);
}
