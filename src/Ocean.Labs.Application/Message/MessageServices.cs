using Ocean.Labs.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Ocean.Labs.Message
{
public class MessagingService
{
    private readonly RabbitMqConfig _rabbitMqConfig;
    public MessagingService(RabbitMqConfig rabbitMqConfig)
    {
            _rabbitMqConfig = rabbitMqConfig;
        }

        public void SendMessage(string message)
        {
            using (var channel = _rabbitMqConfig.GetChannel())
            {
                channel.QueueDeclare(queue: "orderQueue",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                        routingKey: "orderQueue",
                                        basicProperties: null,
                                        body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
        }

        public void ReceiveMessages()
        {
            using (var channel = _rabbitMqConfig.GetChannel())
            {
                channel.QueueDeclare(queue: "orderQueue",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                };

                channel.BasicConsume(queue: "orderQueue",
                                        autoAck: true,
                                        consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
