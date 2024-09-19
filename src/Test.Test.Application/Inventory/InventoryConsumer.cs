using Abp.EntityFrameworkCore.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading.Tasks;
using Test.Test.Model;

public class InventoryConsumer
{
    private readonly IProductStockRepository _productStockRepository;
    private readonly IModel _channel;

    public InventoryConsumer(IProductStockRepository productStockRepository, IModel channel)
    {
        _productStockRepository = productStockRepository;
        _channel = channel;
    }

    public void StartConsuming()
    {
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var orderCreatedEvent = JsonConvert.DeserializeObject<OrderCreatedEvent>(message);

            await UpdateStockAsync(orderCreatedEvent.Order);
        };

        _channel.BasicConsume(queue: "orderQueue", autoAck: true, consumer: consumer);
    }

    private async Task UpdateStockAsync(Order order)
    {
        // Execute stored procedure to update stock
        await _productStockRepository.GetDbContext().Database.ExecuteSqlRawAsync(
            "EXEC UpdateStock @ProductId, @Quantity",
            new SqlParameter("@ProductId", order.ProductId),
            new SqlParameter("@Quantity", order.Quantity));
    }
}
