using Microsoft.AspNetCore.Mvc;
using WebApplication32.Models;

namespace WebApplication32.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(FormCollection fc)
        {
            ViewBag.Id = fc["Id"];
            ViewBag.Name = fc["Name"];
            bool chk = Convert.ToBoolean(fc["Addon"].Split(',')[0]);
            ViewBag.Addon = chk;

            return View("Index");
        }


    }
}
