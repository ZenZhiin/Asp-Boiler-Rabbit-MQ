using Abp.Domain.Entities;

public class Product : Entity<int>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
