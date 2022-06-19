using ClassEntities;
using Microsoft.AspNetCore.Mvc;

namespace Loja_OnlineWeb.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            return View();
        }
    }
}
