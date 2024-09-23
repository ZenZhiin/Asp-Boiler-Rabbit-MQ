using Test.Test.Model;

public class OrderCreatedEvent
{
    public Order Order { get; }

    public OrderCreatedEvent(Order order)
    {
        Order = order;
    }
}