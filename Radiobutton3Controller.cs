using Microsoft.AspNetCore.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class Radiobutton3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult sayhello(Radiobutton3Model r)
        {

            ViewBag.city=r.city;

            int count = 0;
            int res = 0;
            if(r.delhi==true)
            {
               res = count++;
            }
            else if(r.mumbai==true)
            {
                res=count++;    
            }
            else if(r.bhopal==true)
            {
                res = count++;
            }
            ViewBag.res=res;

            return View();
        }


    }
}
