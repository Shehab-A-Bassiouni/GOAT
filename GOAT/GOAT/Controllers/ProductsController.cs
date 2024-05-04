using Microsoft.AspNetCore.Mvc;
using DTOs.Objects;
using BLL.Managers;
using GOAT.Data;
namespace GOAT.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IWebHostEnvironment _hosting;
        public ProductsController(IWebHostEnvironment hosting) { 
            _hosting = hosting;
        }
        public IActionResult Display()
        {
            List<Product> products = ProductManager.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ImageFileVM imageFileVM = new();
            return View(imageFileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product product ,ImageFileVM imageFileVM)
        {
            string fileName = "";
            if (imageFileVM.Image != null && imageFileVM.Image.Length > 0)
            {
                var uploadsFolder = Path.Combine(_hosting.WebRootPath,"Data", "Products");
                var filePath = Path.Combine(uploadsFolder, imageFileVM.Image.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     imageFileVM.Image.CopyTo(stream);
                }
                fileName = imageFileVM.Image.FileName;
            }

            product.ImagePath = fileName;
            ProductManager.Add(product);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Search(string input)
        {
            return View();
        }
    }
}
