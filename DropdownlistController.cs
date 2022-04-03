using Microsoft.AspNetCore.Mvc;
using WebApplication30.Models;

namespace WebApplication30.Controllers
{
    public class DropdownlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(DropdownlistModel m)
        {
            var selectedValue = m.SelectTeaType;
            ViewBag.TeaType = selectedValue.ToString();
            return View();
        }

    }
}
