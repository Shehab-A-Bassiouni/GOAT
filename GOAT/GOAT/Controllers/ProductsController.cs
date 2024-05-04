using Microsoft.AspNetCore.Mvc;
using DTOs.Objects;
using BLL.Managers;
namespace GOAT.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Display()
        {
            List<Product> products = ProductManager.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product product)
        {
            product.ImagePath = "ges";
            ProductManager.Add(product);
            return NoContent();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
