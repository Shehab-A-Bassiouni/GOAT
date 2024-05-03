using GOAT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;

namespace GOAT.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductVM product)
        {
            BL.Managers.ProductManager.Add("dwdw",product.Name,product.Stock , product.Price , product.Description , "dfw");
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
