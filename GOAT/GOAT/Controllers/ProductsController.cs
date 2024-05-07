using Microsoft.AspNetCore.Mvc;
using DTOs.Objects;
using BLL.Managers;
using GOAT.Data;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            product.IsExist = true;
            ProductManager.Add(product);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            ProductManager.Delete(id);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductManager.Update(product);
            return View();
        }


        public IActionResult Search(int id)
        {
            Product product = ProductManager.GetByID(id);
            string jsonData = JsonSerializer.Serialize(product);
            return Content(jsonData, "application/json");
        }

      
    }
}
