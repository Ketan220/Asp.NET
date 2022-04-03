using Microsoft.AspNetCore.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class Checkbox2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Checkbox2Model cb)
        {
            int n1 = cb.num1;
            int n2 = cb.num2;
            
            if(cb.add==true)
            {
                ViewBag.add = n1 +n2;
            }
            if(cb.sub==true)
            {
                ViewBag.sub = n1-n2;    
            }
            if(cb.mul==true)
            {
                ViewBag.mul = n1*n2;    
            }
            return View();  
        }
    }
}
