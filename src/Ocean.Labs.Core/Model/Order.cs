﻿using Abp.Domain.Entities;

namespace Ocean.Labs.Model
{
    public class Order : Entity<int>
    {
        public string OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
