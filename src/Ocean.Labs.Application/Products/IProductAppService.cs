using System.Threading.Tasks;

public interface IProductAppService
{
    Task<ProductDto> GetProductAsync(int productId);
}
