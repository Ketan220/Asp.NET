using Microsoft.AspNetCore.Mvc;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    public class HiddenforController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc, HiddenforModel um)
        {
            ViewBag.basicname = fc["BasicHiddenName"];

            ViewBag.id = um.UserId;
            ViewBag.name = um.UserName;
            return View(um);
        }

    }
}
