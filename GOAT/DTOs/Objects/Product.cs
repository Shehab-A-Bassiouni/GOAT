using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Product : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string ImagePath { get; set; }
        public required int Stock { get; set; }
        public required int Price { get; set; }
        public required string Size { get; set; }
        public required string Colors { get; set; }
    }
}
