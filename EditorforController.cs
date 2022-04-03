using Microsoft.AspNetCore.Mvc;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    public class EditorforController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EditorforModel u)
        {
            ViewBag.Username = u.UserName;
            ViewBag.Age=u.Age;
            ViewBag.City=u.City;
           
            if(u.isHandicapped==true)
            {
                ViewBag.hd = "I'm Handicapped";
            }
            else
            {
                ViewBag.hd = "I'm not handicapped";
            }
            return View(); 

        }
    }
}
