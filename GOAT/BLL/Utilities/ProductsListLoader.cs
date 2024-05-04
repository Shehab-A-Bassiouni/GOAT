using BLL.Managers;
using DTOs.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Utilities
{
    public static class ProductsListLoader
    {
        public static List<string> ProductsNamesList { get; set; } = new();

        public static bool IsListNull() { 
            return ProductsNamesList is null;
        }

        public static void LoadAllProductsToList() {
            var products = ProductManager.GetAll();
            foreach (var product in products)
            {
                ProductsNamesList.Add(product.Name);
            }
        }
        public static void AddToProductList(Product product) {
              ProductsNamesList.Add(product.Name);
        }
    }
}
