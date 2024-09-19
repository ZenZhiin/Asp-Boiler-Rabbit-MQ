using System.Threading.Tasks;

public interface IOrderAppService
{
    Task CreateOrderAsync(CreateOrderDto input);
}
