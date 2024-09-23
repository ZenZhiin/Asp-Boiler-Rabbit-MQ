﻿using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ocean.Labs.Model
{
    public class Order : Entity<int>
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
