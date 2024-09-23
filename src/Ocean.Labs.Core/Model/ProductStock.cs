using Abp.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Ocean.Labs.Model
{
    public class ProductStock : Entity<int>
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public async Task UpdateStockAsync(int productId, int quantity)
        {
           
        }
    }
}
