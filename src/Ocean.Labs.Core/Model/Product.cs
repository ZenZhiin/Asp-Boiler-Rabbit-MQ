using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Ocean.Labs.Model
{
    public class Product : Entity<int>
    {
        [Key]
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
