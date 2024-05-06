using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs.Objects;
using DAL.Repository;
using DAL.CustomRepositories;
using DTOs;
namespace BLL.Managers
{
    public static class ProductManager
    {
        public static SaveState Add(Product product)
        {
            ProductRepo ProductRepo = new();
           return ProductRepo.Add(product);
        }

        public static List<Product> GetAll() {
            ProductRepo ProductRepo = new();
            return ProductRepo.GetAll();
        }

        public static Product GetByID(int id) {
            ProductRepo ProductRepo = new();
            return ProductRepo.GetByID(id);
        }

        public static SaveState Update(Product product) {
            ProductRepo ProductRepo = new();
           return ProductRepo.Update(product);
        }

        public static SaveState Delete(int id)
        {
            ProductRepo ProductRepo = new();
           return ProductRepo.DeleteByID(id);
        }

    }
}
