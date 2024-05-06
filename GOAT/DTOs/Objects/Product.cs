using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Product : BaseEntity
    {
        public required string Serial { get; set; } 
        public required string Name { get; set; } 
        public string? Description { get; set; }
        [ForeignKey("Category")]
        public required int CategoryID { get; set; } 
        public required Category Category { get; set; } 
        public required string ImagePath { get; set; } 
        public required int Stock { get; set; } 
        public required int Price { get; set; } 
        public required string Size { get; set; } 
        public string? Colors { get; set; }
        [ForeignKey("RelatedProducts")]
        public  int? RelatedProductsID { get; set; }
        public  RelatedProducts? RelatedProducts { get; set; }

    }
}
