using Microsoft.AspNetCore.Mvc;
using WebApplication30.Models;

namespace WebApplication30.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc, PasswordModel um)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BasicPassword = fc["BasicPassword"];

                ViewBag.StrongPassword = um.ConfirmPassword;
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
