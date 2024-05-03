using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Product :BaseEntity
    {
     
        public required string Name { get; set; }
        public string? Description { get; set; }

        public required string ImagePath { get; set; }

        public required int Stock { get; set; }

        public required double Price { get; set; }
    }
}
