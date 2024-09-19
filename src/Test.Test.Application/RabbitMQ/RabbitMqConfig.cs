using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

public static class RabbitMqConfig
{
    public static void AddRabbitMq(this IServiceCollection services)
    {
        services.AddSingleton<IConnection>(sp =>
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };
            return factory.CreateConnection();
        });

        services.AddSingleton<IModel>(sp =>
        {
            var connection = sp.GetRequiredService<IConnection>();
            var channel = connection.CreateModel();
            channel.QueueDeclare(queue: "orderQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);
            return channel;
        });
    }
}
