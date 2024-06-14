using BLL.Managers;
using DTOs.Objects;
using Microsoft.AspNetCore.Mvc;

namespace GOAT.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Display()
        {
            List<Category> Categories = CategoryManager.GetAll();
            return View(Categories);
        }


    }
}
