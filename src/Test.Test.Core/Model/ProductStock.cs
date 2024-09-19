using Abp.Domain.Entities;


namespace Test.Test.Model
{
    public class ProductStock : Entity<int>
    {
       public int ProductId { get; set; }

       public int Quantity { get; set; }
    }
}
