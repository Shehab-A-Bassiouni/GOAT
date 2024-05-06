using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class RelatedProducts : BaseEntity
    {
        public required string Name { get; set; }
        public required List<Product> Products { get; set; }
    }
}