﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Labs.Model
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
