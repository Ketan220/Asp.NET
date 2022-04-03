using Microsoft.AspNetCore.Mvc;
using WebApplication30.Models;

namespace WebApplication30.Controllers
{
    public class TextareaforController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TextareaforModel u)
        {
            ViewBag.name = u.Name;
            return View();
        }
        
    }
}
