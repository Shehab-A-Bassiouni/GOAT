﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required int Stock { get; set; }
        public required int Price { get; set; }
        public required string Description { get; set; }
    }
}
