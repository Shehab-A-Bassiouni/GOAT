using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers
{
    public static class ProductManager
    {
        public static void Add(string serial, string name, int stock, double price, string description, string image) {
            Product product = new()
            {
                Serial = serial,
                Name = name,
                Stock = stock,
                Price = price,
                Description = description,
                Image = image
            };

            EntityRepository repository = new EntityRepository();
            repository.Add(product);
        }
    }
}
