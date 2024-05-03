using DTOs.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Mappers
{
    public static class ProductMapper
    {
      

        public static Product MapToDTO(string name, string? description, string imagePath, int stock, double price) { 
            return new Product 
            { 
                Name = name, 
                Description = description,
                ImagePath = imagePath, 
                Stock = stock,
                Price = price
             };     
        }
    }
}
