using System.Threading.Tasks;

public interface IBusPublisher
{
    Task PublishAsync<T>(T message) where T : class;
}
