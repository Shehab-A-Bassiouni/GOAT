using DAL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product : BaseEntity
    {
        public required string Serial { get; set; }
        public required string Name { get; set; }
        public required int Stock { get; set; }
        public required double Price { get; set; }
        public required string Image { get; set; }
        public string? Description { get; set; }
    }
}
