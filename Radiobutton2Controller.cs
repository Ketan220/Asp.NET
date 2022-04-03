using Microsoft.AspNetCore.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class Radiobutton2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Radiobutton2Model r)
        {
            int bal = 1000;
           
             int balance = bal + r.amt;
             ViewBag.Balance = balance;

          
              int withdraw = balance - r.amt;
              ViewBag.withdraw = withdraw;


           
            
                
              

            return View();
        }
    }
}
