using Microsoft.AspNetCore.Mvc;

namespace GOAT.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
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
