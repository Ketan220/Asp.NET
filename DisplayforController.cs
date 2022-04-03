using Microsoft.AspNetCore.Mvc;
using WebApplication30.Models;

namespace WebApplication30.Controllers
{
    public class DisplayforController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc, DisplayforModel um)
        {
            if (ModelState.IsValid)
            {
                um.UserName = fc["UserName"];
                return View(um);
            }
            else
            {
                return View();
            }

        }
    }
}
