using Microsoft.AspNetCore.Mvc;

namespace WebApplication33.Controllers
{
    public class ClientsideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
