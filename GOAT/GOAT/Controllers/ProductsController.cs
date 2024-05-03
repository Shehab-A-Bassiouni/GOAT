using Microsoft.AspNetCore.Mvc;
using BLL.Managers;
using DTOs.Objects;
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
        public IActionResult Add(int param)
        {
            return View();
        }

     
    }
}
