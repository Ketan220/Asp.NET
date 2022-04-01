using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication26.Models;

namespace WebApplication26.Controllers
{
    public class EvenController : Controller
    {
        // GET: Even
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EvenModel e)
        {
            int num1 = e.num;
            string res;
            if(num1%2==0)
            {
                 res="Number is Even";
            }
            else
            {
                res="Number is Odd";
            }

            ViewBag.result = res;
            return View();

        }
    }
}