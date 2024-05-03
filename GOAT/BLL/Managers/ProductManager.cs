using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs.Mappers;
using DTOs.Objects;
using DAL.Repository;
namespace BLL.Managers
{
    public static class ProductManager
    {
        public static void Add(string name, string? description, string imagePath, int stock, double price) {
            Product product = ProductMapper.MapToDTO(name, description, imagePath, stock, price);
            IRepository<Product> repository = new Repository();
        }
    }
}
