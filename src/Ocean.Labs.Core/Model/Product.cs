using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ocean.Labs.Model
{
    public class Product : Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product( string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
