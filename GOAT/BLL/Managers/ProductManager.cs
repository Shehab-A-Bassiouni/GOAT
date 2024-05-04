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
        public static void Add(Product product) {
            IRepository<Product> repository = new Repository<Product>();
            repository.Add(product);
        }

        public static List<Product> GetAll() {
            IRepository<Product> repository = new Repository<Product>();
            return repository.GetAll();
        }

      

        public static Product GetByID(int id) { 
            IRepository<Product> repository = new Repository<Product>();
             return repository.GetByID(id);
        }

        public static void Update(Product product) { 
            IRepository<Product> repository = new Repository<Product>();
            repository.Update(product);
        }

        public static void Delete(int id)
        {
            IRepository<Product> repository = new Repository<Product>();
            repository.DeleteByID(id);
        }

    }
}
