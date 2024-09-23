using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Labs.Model
{
    public class ProductStock : Entity<int>
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
