using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Ocean.Labs.Model
{
    public class ProductStock : Entity<int>
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public async Task UpdateStockAsync(int productId, int quantity)
        {
           
        }
    }
}
