using Microsoft.AspNetCore.Mvc;

namespace WebApplication32.Controllers
{
    public class StronglyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form2(Models.StronglyModel sm)
        {
            ViewBag.Id = sm.Id;
            ViewBag.Name = sm.Name;
            if (sm.Addon == true)
                ViewBag.Addon = "Selected";
            else
                ViewBag.Addon = "Not Selected";

            return View("Index");
        }

    }
}
