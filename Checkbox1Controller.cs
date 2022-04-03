using Microsoft.AspNetCore.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class Checkbox1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Checkbox1Model ch)
        {
           if(ch.Tea==true)
           {
                ViewBag.Tea = "Yor selected tea";
           }
           if(ch.Loundry==true)
            {
                ViewBag.Loundry = "You selected loundry";
            }
           if(ch.Breakfast==true)
            {
                ViewBag.Breakfast = "You selected breakfast";
            }
           return View();
        }
    }
 
   
}
