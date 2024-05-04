using BLL.Utilities;
using GOAT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GOAT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProductsListLoader.LoadAllProductsToList();
            return View();
        }

    }
}
