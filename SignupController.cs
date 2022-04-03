using Microsoft.AspNetCore.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SignupModel u)
        {
            ViewBag.username = u.username;
            ViewBag.gender=u.gender;

            if(u.java==true)
            {
                ViewBag.java = "Java";
            }
            else if(u.dotnet==true)
            {
                ViewBag.dotnet = "dotnet";
            }

            var selectedValue = u.SelectCityType;
            ViewBag.CityType = selectedValue.ToString();

            return View();
        }
    }
}
