using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Category:BaseEntity
    {
        public  required string Name { get; set; }
        public string? Description { get; set; }
        public List<Product>? Products { get; set; }
    }
}
