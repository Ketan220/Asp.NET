using Microsoft.AspNetCore.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class Radiobutton1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Radiobutton1Model u)
        {
            ViewBag.TeaType=u.TeaType;
            ViewBag.HotelType=u.HotelType;
            return View();
        }
    }
}
