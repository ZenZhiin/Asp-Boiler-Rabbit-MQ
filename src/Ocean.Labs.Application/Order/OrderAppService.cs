using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using System;
using System.Threading.Tasks;
using Ocean.Labs.Model;

public class OrderAppService : ApplicationService, IOrderAppService
{
    private readonly IRepository<Order, int> _orderRepository;
    private readonly IRepository<ProductStock, int> _productStockRepository;
    private readonly IBusPublisher _busPublisher;
    private readonly IProductRepository _productRepository;

    public OrderAppService(
        IRepository<Order, int> orderRepository,
        IRepository<ProductStock, int> productStockRepository,
        IBusPublisher busPublisher,
        IProductRepository productRepository)
    {
        _orderRepository = orderRepository;
        _productStockRepository = productStockRepository;
        _busPublisher = busPublisher;
        _productRepository = productRepository;
    }

    public async Task CreateOrderAsync(CreateOrderDto input)
    {
        // Calculate order amount
        var product = await _productRepository.GetAsync(input.ProductId);
        var orderAmount = product.Price * input.Quantity;

        // Create and save order
        var order = new Order
        {
            ProductId = input.ProductId,
            OrderNumber = GenerateOrderNumber(),
            Quantity = input.Quantity,
            Amount = orderAmount
        };
        await _orderRepository.InsertAsync(order);

        // Publish event to RabbitMQ
        await _busPublisher.PublishAsync(new OrderCreatedEvent(order));
    }

    private string GenerateOrderNumber()
    {
        return Guid.NewGuid().ToString();
    }
}
