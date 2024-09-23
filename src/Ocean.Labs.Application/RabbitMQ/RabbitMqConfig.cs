using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

namespace Ocean.Labs.RabbitMQ
{
    public class RabbitMqConfig
    {
        private readonly ConnectionFactory _connectionFactory;

        public RabbitMqConfig(string hostname, string username, string password)
        {
            _connectionFactory = new ConnectionFactory
            {
                HostName = hostname,
                UserName = username,
                Password = password
            };
        }

        public IConnection GetConnection()
        {
            return _connectionFactory.CreateConnection();
        }

        public IModel GetChannel()
        {
            var connection = GetConnection();
            return connection.CreateModel();
        }
    }
}