using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;
using System.Threading.Tasks;

public class BusPublisher : IBusPublisher
{
    private readonly IModel _channel;

    public BusPublisher(IModel channel)
    {
        _channel = channel;
    }

    public Task PublishAsync<T>(T message) where T : class
    {
        var messageBody = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

        // Define properties, e.g., delivery mode, priority, etc.
        var properties = _channel.CreateBasicProperties();
        properties.Persistent = true;

        _channel.BasicPublish(
            exchange: "",  // Default exchange
            routingKey: "orderQueue", // Routing to orderQueue
            basicProperties: properties,
            body: messageBody);

        return Task.CompletedTask;
    }
}
